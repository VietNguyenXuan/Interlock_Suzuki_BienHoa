using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BarcodeScannerUsbUtility.Controls
{
  using MqttLib;
  public class MqttClient : IDisposable
  {
    private static string _connString;
    private static string _clientId;
    IMqtt _client;
    public MqttClient(string connString, string clientId)
    {
      _connString = connString;
      _clientId = clientId;
      _client = MqttClientFactory.CreateClient(_connString, _clientId);
      _client.Connect(true);
      
    }


    public int Publish(MqttParcel mqttParcel )
    {
      //_client.Connect();
      int ret = _client.Publish(mqttParcel);
      //_client.Disconnect();
      return ret;
    }

    public bool Connect()
    {
      //_client.Connect();
      bool ret = _client.IsConnected;
      //_client.Disconnect();
      return ret;
    }

    #region IDisposable Patern
    private bool disposedValue;
    

    protected virtual void Dispose(bool disposing)
    {
      if (!disposedValue)
      {
        if (disposing)
        {
          // TODO: dispose managed state (managed objects)
        }

        // TODO: free unmanaged resources (unmanaged objects) and override finalizer
        // TODO: set large fields to null
        disposedValue = true;
      }
    }

    // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    ~MqttClient()
    {
      // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
      Dispose(disposing: false);
    }

    public void Dispose()
    {
      // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
      Dispose(disposing: true);
      GC.SuppressFinalize(this);
    }
    #endregion
  }
}
