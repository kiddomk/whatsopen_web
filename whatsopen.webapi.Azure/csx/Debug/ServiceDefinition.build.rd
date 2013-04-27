﻿<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="whatsopen.webapi.Azure" generation="1" functional="0" release="0" Id="d0531361-194c-463e-bbec-8ee81968db67" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="whatsopen.webapi.AzureGroup" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="whatsopen.webapi:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/whatsopen.webapi.Azure/whatsopen.webapi.AzureGroup/LB:whatsopen.webapi:Endpoint1" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="whatsopen.webapi:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/whatsopen.webapi.Azure/whatsopen.webapi.AzureGroup/Mapwhatsopen.webapi:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="whatsopen.webapiInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/whatsopen.webapi.Azure/whatsopen.webapi.AzureGroup/Mapwhatsopen.webapiInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:whatsopen.webapi:Endpoint1">
          <toPorts>
            <inPortMoniker name="/whatsopen.webapi.Azure/whatsopen.webapi.AzureGroup/whatsopen.webapi/Endpoint1" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="Mapwhatsopen.webapi:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/whatsopen.webapi.Azure/whatsopen.webapi.AzureGroup/whatsopen.webapi/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="Mapwhatsopen.webapiInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/whatsopen.webapi.Azure/whatsopen.webapi.AzureGroup/whatsopen.webapiInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="whatsopen.webapi" generation="1" functional="0" release="0" software="C:\Users\Jun Seki\Documents\GitHub\whatsopen\whatsopen.webapi.Azure\csx\Debug\roles\whatsopen.webapi" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="1792" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;whatsopen.webapi&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;whatsopen.webapi&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/whatsopen.webapi.Azure/whatsopen.webapi.AzureGroup/whatsopen.webapiInstances" />
            <sCSPolicyFaultDomainMoniker name="/whatsopen.webapi.Azure/whatsopen.webapi.AzureGroup/whatsopen.webapiFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyFaultDomain name="whatsopen.webapiFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="whatsopen.webapiInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="a1a20687-43f7-40d6-afa7-e1d36b1f0c17" ref="Microsoft.RedDog.Contract\ServiceContract\whatsopen.webapi.AzureContract@ServiceDefinition.build">
      <interfacereferences>
        <interfaceReference Id="37b9c84d-4c34-4f5f-8049-f1868149960c" ref="Microsoft.RedDog.Contract\Interface\whatsopen.webapi:Endpoint1@ServiceDefinition.build">
          <inPort>
            <inPortMoniker name="/whatsopen.webapi.Azure/whatsopen.webapi.AzureGroup/whatsopen.webapi:Endpoint1" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>