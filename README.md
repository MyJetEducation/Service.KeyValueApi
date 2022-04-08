# Service.WalletApi.KeyValueApi

![Release Service](https://github.com/MyJetWallet/Service.WalletApi.KeyValueApi/workflows/Release%20Service/badge.svg)

![CI test build](https://github.com/MyJetWallet/Service.WalletApi.KeyValueApi/workflows/CI%20test%20build/badge.svg)


# Local run

Add env variables:

`launchSettings.json`

```
{
  "profiles": {
    "Service.Wallet.Api": {
      "commandName": "Project",
      "launchBrowser": false,
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development",
        "ConsoleOutputLogLevel": "Default",
        "APP_VERSION": "1.0.0",
        "APP_COMPILATION_DATE": "2021-01-01 11:10:00",
        "SESSION_ENCODING_KEY": "*********",
        "HOSTNAME": "your name",
        "KONG_ZIPKIN_PLUGIN_SERVICE_NAME": "WALLET-API",
        "Kong": "123123",
        "KONG": "2222"
      }
    }
  }
}
```

