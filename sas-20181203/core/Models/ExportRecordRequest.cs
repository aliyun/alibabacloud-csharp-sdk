// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ExportRecordRequest : TeaModel {
        /// <summary>
        /// <para>The type of the file to export. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>virusScanExport</b>: The detail export of virus scan tasks. This parameter is required when ExportType is set to virusScanExport.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>virusScanExport</para>
        /// </summary>
        [NameInMap("ExportFileType")]
        [Validation(Required=false)]
        public string ExportFileType { get; set; }

        /// <summary>
        /// <para>The type of the detection result list to export. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>assetInstance</b>: The server list in Asset Center.</description></item>
        /// <item><description><b>user</b>: The Asset Fingerprints list of accounts.</description></item>
        /// <item><description><b>port</b>: The Asset Fingerprints list of ports.</description></item>
        /// <item><description><b>process</b>: The Asset Fingerprints list of processes.</description></item>
        /// <item><description><b>sca</b>: The Asset Fingerprints list of middleware.</description></item>
        /// <item><description><b>database</b>: The Asset Fingerprints list of databases.</description></item>
        /// <item><description><b>web</b>: The Asset Fingerprints list of web services.</description></item>
        /// <item><description><b>software</b>: The Asset Fingerprints list of software.</description></item>
        /// <item><description><b>cron</b>: The Asset Fingerprints list of scheduled nodes.</description></item>
        /// <item><description><b>autorun</b>: The Asset Fingerprints list of startup items.</description></item>
        /// <item><description><b>lkm</b>: The Asset Fingerprints list of kernel modules.</description></item>
        /// <item><description><b>webserver</b>: The Asset Fingerprints list of websites.</description></item>
        /// <item><description><b>virusScanExport</b>: The list of virus scan node details.</description></item>
        /// <item><description><b>imageVulExport</b>: The image system vulnerability list.</description></item>
        /// <item><description><b>imageBaseLineExport</b>: The image baseline check result list.</description></item>
        /// <item><description><b>imageAffectedMaliciousExport</b>: The image malicious sample check result list.</description></item>
        /// <item><description><b>baselineCspm</b>: The detection result list of cloud platform configuration checks.</description></item>
        /// <item><description><b>attack</b>: The list of attack analysis alerting events.</description></item>
        /// <item><description><b>attackEvent</b>: The list of network defense alerting events.</description></item>
        /// <item><description><b>accessKey</b>: The list of AccessKey leak detection alerting events.</description></item>
        /// <item><description><b>exportObjectScanEvents</b>: The list of malicious file detection alerting events.</description></item>
        /// <item><description><b>domainDetail</b>: The website assets.</description></item>
        /// <item><description><b>assetsPropertyScaProcessDetail</b>: The protected processes of Runtime Application Self-Protection (RASP).</description></item>
        /// <item><description><b>exportHcWarning</b>: The system baseline risk list.</description></item>
        /// <item><description><b>raspAttackAlert</b>: The list of RASP attack alerting.</description></item>
        /// <item><description><b>raspApplicationConfiguration</b>: The list of RASP application configurations.</description></item>
        /// <item><description><b>raspWeaknessDetection</b>: The list of RASP weakness detections.</description></item>
        /// <item><description><b>raspInMemoryWebshellDetection</b>: The list of RASP in-memory webshell detection alerting.</description></item>
        /// <item><description><b>raspInMemoryWebshellInsertion</b>: The list of RASP in-memory webshell injection alerting.</description></item>
        /// <item><description><b>listAgentExport</b>: The agent list.</description></item>
        /// <item><description><b>listSkillExport</b>: The skill list.</description></item>
        /// <item><description><b>listModelExport</b>: The model list.</description></item>
        /// <item><description><b>listAiAgentEventExport</b>: The AI agent risk list.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>database</para>
        /// </summary>
        [NameInMap("ExportType")]
        [Validation(Required=false)]
        public string ExportType { get; set; }

        /// <summary>
        /// <para>Specifies the language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies the filter conditions for the exported content.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When <b>ExportType</b> is set to <b>assetInstance</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>MachineTypes</b>: the asset types. Separate multiple values with commas.</description></item>
        /// <item><description><b>Criteria</b>: the combined filter conditions in JSON array format, such as <c>[{&quot;name&quot;:&quot;fieldName&quot;,&quot;value&quot;:&quot;value&quot;},...]</c>. If you specify multiple values for the same field, a multi-value filter is applied. Multiple conditions are combined by using the OR operator by default. Valid values for <b>name</b>:<remarks>
        /// <list type="bullet">
        /// <item><description><b>internetIp</b>: the public IP address.</description></item>
        /// <item><description><b>intranetIp</b>: the private IP address.</description></item>
        /// <item><description><b>instanceName</b>: the instance name.</description></item>
        /// <item><description><b>instanceId</b>: the instance ID.</description></item>
        /// <item><description><b>vpcInstanceId</b>: the VPC instance ID.</description></item>
        /// <item><description><b>machineType</b>: the asset type.</description></item>
        /// <item><description><b>osName</b>: the operating system name.</description></item>
        /// <item><description><b>osType</b>: the operating system type. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>linux</b>: Linux.</description></item>
        /// <item><description><b>windows</b>: Windows.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>hcStatus</b>: the baseline risk status. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>NO</b>: No baseline risks.</description></item>
        /// <item><description><b>YES</b>: Baseline risks exist.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>vulStatus</b>: the vulnerability risk status. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>NO</b>: No vulnerability risks.</description></item>
        /// <item><description><b>YES</b>: Vulnerability risks exist.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>asapVulStatus</b>: the urgent vulnerability risk status. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>NO</b>: No urgent vulnerability risks.</description></item>
        /// <item><description><b>YES</b>: Urgent vulnerability risks exist.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>alarmStatus</b>: the alert status. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>NO</b>: No alerts.</description></item>
        /// <item><description><b>YES</b>: Alerts exist.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>riskStatus</b>: the overall risk status. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>NO</b>: No risks.</description></item>
        /// <item><description><b>YES</b>: Risks exist.</description></item>
        /// <item><description><b>UNKNOWN</b>: Unknown.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>clientStatus</b>: the client status. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>online</b>: Online.</description></item>
        /// <item><description><b>offline</b>: Offline.</description></item>
        /// <item><description><b>pause</b>: Paused.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>clientSubStatus</b>: the client sub-status. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>online</b>: Online.</description></item>
        /// <item><description><b>offline</b>: Offline.</description></item>
        /// <item><description><b>pause</b>: Paused.</description></item>
        /// <item><description><b>stopped</b>: Stopped.</description></item>
        /// <item><description><b>uninstalled</b>: Uninstalled.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>runningStatus</b>: the running status. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>Running</b>: Running.</description></item>
        /// <item><description><b>notRunning</b>: Not running.</description></item>
        /// <item><description><b>UNKNOWN</b>: Unknown.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>tagName</b>: the tag name.</description></item>
        /// <item><description><b>tagKeyValue</b>: the tag key-value pair.</description></item>
        /// <item><description><b>vendorAuthAlias</b>: the alias of the cloud service provider account.</description></item>
        /// <item><description><b>vendorUid</b>: the UID of the cloud service provider account.</description></item>
        /// <item><description><b>vendorUserName</b>: the name of the cloud service provider account.</description></item>
        /// <item><description><b>clusterId</b>: the cluster ID.</description></item>
        /// <item><description><b>clusterIdList</b>: the cluster IDs. Separate multiple IDs with commas.</description></item>
        /// <item><description><b>namespace</b>: the namespace.</description></item>
        /// <item><description><b>appName</b>: the application name.</description></item>
        /// <item><description><b>serviceId</b>: the service ID in the container dimension.</description></item>
        /// <item><description><b>clusterNodeStatus</b>: the cluster node status. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The asset is a cluster node.</description></item>
        /// <item><description><b>false</b>: The asset is not a cluster node.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>groupName</b>: the asset group name.</description></item>
        /// <item><description><b>groupId</b>: the asset group ID.</description></item>
        /// <item><description><b>regionId</b>: the region ID.</description></item>
        /// <item><description><b>importance</b>: the importance level. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>important</b>: Important asset.</description></item>
        /// <item><description><b>general</b>: General asset.</description></item>
        /// <item><description><b>test</b>: Test asset.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>newInstance</b>: the identifier for newly added assets. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>NO</b>: Not a newly added asset.</description></item>
        /// <item><description><b>YES</b>: Newly added asset.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>containerStatus</b>: the container status. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>NO</b>: No containers.</description></item>
        /// <item><description><b>YES</b>: Containers exist.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>exposedStatus</b>: the exposure status. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>NO</b>: Not exposed.</description></item>
        /// <item><description><b>YES</b>: Exposed.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>aiStatus</b>: the AI asset status. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>true</b>: AI asset.</description></item>
        /// <item><description><b>false</b>: Non-AI asset.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>authVersion</b>: the client version. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition.</description></item>
        /// <item><description><b>3</b>: Enterprise Edition.</description></item>
        /// <item><description><b>5</b>: Advanced Edition.</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition.</description></item>
        /// <item><description><b>7</b>: Ultimate Edition.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>ipList</b>: the IP addresses. Separate multiple IP addresses with commas.</description></item>
        /// <item><description><b>uuidList</b>: the asset UUIDs.</description></item>
        /// <item><description><b>ecsType</b>: the instance type.</description></item>
        /// <item><description><b>alisecguardStatus</b>: the status of the protection plugin. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Online.</description></item>
        /// <item><description><b>1</b>: Disabled.</description></item>
        /// <item><description><b>2</b>: Offline.</description></item>
        /// <item><description><b>-99</b>: Installation failed.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>alihipsStatus</b>: the status of the host intrusion prevention plugin. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Online.</description></item>
        /// <item><description><b>1</b>: Disabled.</description></item>
        /// <item><description><b>2</b>: Offline.</description></item>
        /// <item><description><b>-99</b>: Installation failed.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>alinetStatus</b>: the status of the network protection plugin. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Online.</description></item>
        /// <item><description><b>1</b>: Disabled.</description></item>
        /// <item><description><b>2</b>: Offline.</description></item>
        /// <item><description><b>-99</b>: Installation failed.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>alidetStatus</b>: the status of the detection plugin. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Online.</description></item>
        /// <item><description><b>1</b>: Disabled.</description></item>
        /// <item><description><b>2</b>: Offline.</description></item>
        /// <item><description><b>-99</b>: Installation failed.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>yundunMonitorStatus</b>: the status of the monitoring plugin. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Online.</description></item>
        /// <item><description><b>1</b>: Disabled.</description></item>
        /// <item><description><b>2</b>: Offline.</description></item>
        /// <item><description><b>-99</b>: Installation failed.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>Importance</b>: the importance level.</description></item>
        /// <item><description><b>LogicalExp</b>: the logical operator used to combine multiple conditions. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>AND</b>: All conditions must be met.</description></item>
        /// <item><description><b>OR</b>: Any condition is met. This is the default value.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>user</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>User</b>: the account name.</description></item>
        /// <item><description><b>IsRoot</b>: specifies whether the account has root permissions. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Yes.</description></item>
        /// <item><description><b>2</b>: No.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>LastLoginTimeStart</b>: the start time of the query range for the last logon time. Unit: milliseconds.</description></item>
        /// <item><description><b>LastLoginTimeEnd</b>: the end time of the query range for the last logon time. Unit: milliseconds.</description></item>
        /// <item><description><b>uuid</b>: the asset UUIDs. Separate multiple UUIDs with commas.</description></item>
        /// <item><description><b>remark</b>: the remarks. This parameter matches the server name, public IP address, and private IP address at the same time.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>port</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>port</b>: the port number.</description></item>
        /// <item><description><b>procName</b>: the process name.</description></item>
        /// <item><description><b>bindIp</b>: the bound IP address.</description></item>
        /// <item><description><b>remark</b>: the remarks. This parameter matches the server name, public IP address, and private IP address at the same time.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>process</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>name</b>: the process name.</description></item>
        /// <item><description><b>user</b>: the user that runs the process.</description></item>
        /// <item><description><b>cmdline</b>: the command line.</description></item>
        /// <item><description><b>procTimeStart</b>: the start time of the query range for the process startup time. Unit: milliseconds.</description></item>
        /// <item><description><b>procTimeEnd</b>: the end time of the query range for the process startup time. Unit: milliseconds.</description></item>
        /// <item><description><b>uuid</b>: the asset UUIDs. Separate multiple UUIDs with commas. Only the data of the specified assets is exported.</description></item>
        /// <item><description><b>remark</b>: the remarks. This parameter matches the server name, public IP address, and private IP address at the same time.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>sca</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>scaName</b>: the middleware name.</description></item>
        /// <item><description><b>scaVersion</b>: the middleware version.</description></item>
        /// <item><description><b>port</b>: the port.</description></item>
        /// <item><description><b>pid</b>: the process ID.</description></item>
        /// <item><description><b>user</b>: the user.</description></item>
        /// <item><description><b>processStartedStart</b>: the start time of the query range for the process startup time. Unit: milliseconds.</description></item>
        /// <item><description><b>processStartedEnd</b>: the end time of the query range for the process startup time. Unit: milliseconds.</description></item>
        /// <item><description><b>searchItem</b>: the search field name. This parameter is used together with <b>searchInfo</b> to specify the field by which to search. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>name</b>: searches by component name. In this case, set <b>searchInfo</b> to the component name.</description></item>
        /// <item><description><b>type</b>: searches by component type. In this case, set <b>searchInfo</b> to the component type.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>searchInfo</b>: the search value. This parameter is used together with <b>searchItem</b>.</description></item>
        /// <item><description><b>uuid</b>: the asset UUIDs. Separate multiple UUIDs with commas. Only the data of the specified assets is exported.</description></item>
        /// <item><description><b>remark</b>: the remarks. This parameter matches the server name, public IP address, and private IP address at the same time.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>database</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>port</b>: the port.</description></item>
        /// <item><description><b>pid</b>: the process ID.</description></item>
        /// <item><description><b>user</b>: the user.</description></item>
        /// <item><description><b>ScaVersion</b>: the version.</description></item>
        /// <item><description><b>processStartedStart</b>: the start time of the query range for the process startup time. Unit: milliseconds.</description></item>
        /// <item><description><b>processStartedEnd</b>: the end time of the query range for the process startup time. Unit: milliseconds.</description></item>
        /// <item><description><b>searchItem</b>: the search field name. This parameter is used together with <b>searchInfo</b> to specify the field by which to search. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>name</b>: searches by database name. In this case, set <b>searchInfo</b> to the component name.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>searchInfo</b>: the search value. This parameter is used together with <b>searchItem</b>.</description></item>
        /// <item><description><b>uuid</b>: the asset UUIDs. Separate multiple UUIDs with commas. Only the data of the specified assets is exported.</description></item>
        /// <item><description><b>remark</b>: the remarks. This parameter matches the server name, public IP address, and private IP address at the same time.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>web</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>scaName</b>: the web service name.</description></item>
        /// <item><description><b>scaNamePattern</b>: the component name for fuzzy search.</description></item>
        /// <item><description><b>scaVersion</b>: the version.</description></item>
        /// <item><description><b>bizType</b>: the type. Set the value to <b>sca_web</b>.</description></item>
        /// <item><description><b>port</b>: the port.</description></item>
        /// <item><description><b>pid</b>: the process ID.</description></item>
        /// <item><description><b>user</b>: the user.</description></item>
        /// <item><description><b>processStartedStart</b>: the start time of the query range for the process startup time. Unit: milliseconds.</description></item>
        /// <item><description><b>processStartedEnd</b>: the end time of the query range for the process startup time. Unit: milliseconds.</description></item>
        /// <item><description><b>searchItem</b>: the search field name. This parameter is used together with <b>searchInfo</b> to specify the field by which to search. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>name</b>: searches by component name. In this case, set <b>searchInfo</b> to the component name.</description></item>
        /// <item><description><b>type</b>: searches by component type. In this case, set <b>searchInfo</b> to the component type.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>searchInfo</b>: the search value. This parameter is used together with <b>searchItem</b>.</description></item>
        /// <item><description><b>uuid</b>: the asset UUIDs. Separate multiple UUIDs with commas. Only the data of the specified assets is exported.</description></item>
        /// <item><description><b>remark</b>: the remarks. This parameter matches the server name, public IP address, and private IP address at the same time.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>software</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>name</b>: the software name.</description></item>
        /// <item><description><b>softwareVersion</b>: the version.</description></item>
        /// <item><description><b>path</b>: the software startup path.</description></item>
        /// <item><description><b>installTimeStart</b>: the start time of the query range for the software update time. Unit: milliseconds.</description></item>
        /// <item><description><b>installTimeEnd</b>: the end time of the query range for the software update time. Unit: milliseconds.</description></item>
        /// <item><description><b>uuid</b>: the asset UUIDs. Separate multiple UUIDs with commas. Only the data of the specified assets is exported.</description></item>
        /// <item><description><b>remark</b>: the remarks. This parameter matches the server name, public IP address, and private IP address at the same time.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>cron</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>source</b>: the task path.</description></item>
        /// <item><description><b>user</b>: the account name.</description></item>
        /// <item><description><b>uuid</b>: the asset UUIDs. Separate multiple UUIDs with commas. Only the data of the specified assets is exported.</description></item>
        /// <item><description><b>remark</b>: the remarks. This parameter matches the server name, public IP address, and private IP address at the same time.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>autorun</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>itemName</b>: the startup item path.</description></item>
        /// <item><description><b>uuid</b>: the asset UUIDs. Separate multiple UUIDs with commas. Only the data of the specified assets is exported.</description></item>
        /// <item><description><b>remark</b>: the remarks. This parameter matches the server name, public IP address, and private IP address at the same time.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>lkm</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>itemName</b>: the kernel module name.</description></item>
        /// <item><description><b>uuid</b>: the asset UUIDs. Separate multiple UUIDs with commas. Only the data of the specified assets is exported.</description></item>
        /// <item><description><b>remark</b>: the remarks. This parameter matches the server name, public IP address, and private IP address at the same time.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>webserver</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>itemName</b>: the site domain name.</description></item>
        /// <item><description><b>uuid</b>: the asset UUIDs. Separate multiple UUIDs with commas. Only the data of the specified assets is exported.</description></item>
        /// <item><description><b>remark</b>: the remarks. This parameter matches the server name, public IP address, and private IP address at the same time.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>virusScanExport</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>status</b>: the scan task status. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>INIT</b>: Pending.</description></item>
        /// <item><description><b>START</b>: Started.</description></item>
        /// <item><description><b>DISTRIBUTE</b>: Dispatched.</description></item>
        /// <item><description><b>PROCESSING</b>: In progress.</description></item>
        /// <item><description><b>BEGIN</b>: Begun.</description></item>
        /// <item><description><b>SUCCESS</b>: Completed.</description></item>
        /// <item><description><b>FAIL</b>: Failed.</description></item>
        /// <item><description><b>TIMEOUT</b>: Timed out.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>imageVulExport</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>Type</b>: the vulnerability type. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: CVE vulnerability.</description></item>
        /// <item><description><b>sca</b>: SCA vulnerability (Software Composition Analysis vulnerability).</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>aliasName</b>: the alias of the vulnerability name.</description></item>
        /// <item><description><b>Necessity</b>: the vulnerability priority. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>asap</b>: High.</description></item>
        /// <item><description><b>later</b>: Medium.</description></item>
        /// <item><description><b>nntf</b>: Low.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>Dealed</b>: the handling status. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>y</b>: Handled.</description></item>
        /// <item><description><b>n</b>: Unhandled.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>RepoInstanceId</b>: the image repository instance ID.</description></item>
        /// <item><description><b>RepoName</b>: the image repository name.</description></item>
        /// <item><description><b>RepoNamespace</b>: the image repository namespace.</description></item>
        /// <item><description><b>Uuids</b>: the asset UUIDs. Separate multiple UUIDs with commas.</description></item>
        /// <item><description><b>ScanRange</b>: the scan scope. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>image</b>: Image scan.</description></item>
        /// <item><description><b>container</b>: Container runtime image scan.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>IsLatest</b>: specifies whether to export only the latest image versions. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Exports only the latest image versions.</description></item>
        /// <item><description><b>false</b>: No limit.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>imageBaseLineExport</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>scanRange</b>: the scan scope. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>image</b>: Image scan.</description></item>
        /// <item><description><b>container</b>: Container runtime image scan.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>CriteriaType</b>: the combined condition type. This parameter is used together with <b>Criteria</b>. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>BaselineNameAlias</b>: filters by baseline name. In this case, set <b>Criteria</b> to the baseline name.</description></item>
        /// <item><description><b>BaselineClassAlias</b>: filters by baseline category. In this case, set <b>Criteria</b> to the baseline category name.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>Criteria</b>: the value of the combined condition. This parameter is used together with <b>CriteriaType</b>.</description></item>
        /// <item><description><b>RiskLevel</b>: the risk level. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>high</b>: High.</description></item>
        /// <item><description><b>medium</b>: Medium.</description></item>
        /// <item><description><b>low</b>: Low.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>BaselineNameKey</b>: the baseline name.</description></item>
        /// <item><description><b>RepoInstanceId</b>: the image repository instance ID.</description></item>
        /// <item><description><b>RepoName</b>: the image repository name.</description></item>
        /// <item><description><b>RepoNamespace</b>: the image repository namespace.</description></item>
        /// <item><description><b>RepoRegionId</b>: the region of the image repository.</description></item>
        /// <item><description><b>ImageDigest</b>: the image digest.</description></item>
        /// <item><description><b>ImageTag</b>: the image tag.</description></item>
        /// <item><description><b>ImageUuid</b>: the image asset UUID.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>imageAffectedMaliciousExport</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>Levels</b>: the risk levels. Separate multiple levels with commas. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>serious</b>: Urgent.</description></item>
        /// <item><description><b>suspicious</b>: Suspicious.</description></item>
        /// <item><description><b>remind</b>: Reminder.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>MaliciousMd5</b>: the MD5 hash of the malicious sample.</description></item>
        /// <item><description><b>FuzzyMaliciousName</b>: the name of the malicious sample for fuzzy search.</description></item>
        /// <item><description><b>RepoInstanceId</b>: the image repository instance ID.</description></item>
        /// <item><description><b>RepoNamespace</b>: the image repository namespace.</description></item>
        /// <item><description><b>RepoName</b>: the image repository name.</description></item>
        /// <item><description><b>ImageDigest</b>: the image digest.</description></item>
        /// <item><description><b>ScanRange</b>: the scan scope. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>image</b>: Image scan.</description></item>
        /// <item><description><b>container</b>: Container runtime image scan.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>baselineCspm</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>CheckKey</b>: the check item name.</description></item>
        /// <item><description><b>Statuses</b>: the check result statuses. The value is a JSON array. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>PASS</b>: Passed.</description></item>
        /// <item><description><b>NOT_PASS</b>: Failed.</description></item>
        /// <item><description><b>CHECKING</b>: Checking.</description></item>
        /// <item><description><b>NOT_CHECK</b>: Not checked.</description></item>
        /// <item><description><b>WHITELIST</b>: Whitelisted.</description></item>
        /// <item><description><b>FAILED</b>: Check failed.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>RiskLevels</b>: the risk levels. The value is a JSON array. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>HIGH</b>: High.</description></item>
        /// <item><description><b>MEDIUM</b>: Medium.</description></item>
        /// <item><description><b>LOW</b>: Low.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>OperationTypes</b>: specifies whether fixing is supported. The value is a JSON array. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>SUPPORT_REPAIR</b>: Supported.</description></item>
        /// <item><description><b>NOT_SUPPORT_REPAIR</b>: Not supported.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>Vendors</b>: the cloud service providers. The value is a JSON array. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>ALIYUN</b>: Alibaba Cloud.</description></item>
        /// <item><description><b>AWS</b>: Amazon Web Services (AWS).</description></item>
        /// <item><description><b>MICROSOFT</b>: Microsoft Azure.</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: Huawei Cloud.</description></item>
        /// <item><description><b>TENCENT</b>: Tencent Cloud.</description></item>
        /// <item><description><b>VOLCENGINE</b>: Volcengine.</description></item>
        /// <item><description><b>GOOGLE</b>: Google Cloud.</description></item>
        /// <item><description><b>STATECLOUD</b>: Tianyi Cloud.</description></item>
        /// <item><description><b>BAIDUCLOUD</b>: Baidu Cloud.</description></item>
        /// <item><description><b>UCLOUD</b>: UCloud.</description></item>
        /// <item><description><b>KINGSOFTCLOUD</b>: Kingsoft Cloud.</description></item>
        /// <item><description><b>ORACLECLOUD</b>: Oracle Cloud.</description></item>
        /// <item><description><b>KSPM</b>: Other (Kubernetes).</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>InstanceTypes</b>: the asset types. The value is a JSON array.</description></item>
        /// <item><description><b>InstanceSubTypes</b>: the asset subtypes. The value is a JSON array.</description></item>
        /// <item><description><b>InstanceIds</b>: the asset instance IDs. The value is a JSON array.</description></item>
        /// <item><description><b>CheckIds</b>: the check item IDs. The value is a JSON array. You can specify up to 500 IDs.</description></item>
        /// <item><description><b>CheckTypes</b>: the check types. The value is a JSON array. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>CUSTOM</b>: Custom.</description></item>
        /// <item><description><b>SYSTEM</b>: Predefined.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>StandardIds</b>: the compliance standard IDs. The value is a JSON array.</description></item>
        /// <item><description><b>RequirementIds</b>: the compliance requirement IDs. The value is a JSON array.</description></item>
        /// <item><description><b>CustomParam</b>: specifies whether custom parameters are supported. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>attack</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>Type</b>: the attack analysis data type. Exact match. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>TOTAL</b>: Total attack statistics.</description></item>
        /// <item><description><b>TREND</b>: Attack trend data.</description></item>
        /// <item><description><b>PIE_CHART</b>: Attack type distribution data.</description></item>
        /// <item><description><b>SOURCE_TOP</b>: Top source IP addresses of attacks.</description></item>
        /// <item><description><b>CLIENT_TOP</b>: Top attacked assets.</description></item>
        /// <item><description><b>DETAILS</b>: Attack details (paginated). Used when exporting the detail list.</description></item>
        /// <item><description><b>ATTACK_SCREEN</b>: Attack dashboard data.</description></item>
        /// <item><description><b>GC_LEVEL</b>: Security level data.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>StartTime</b>: the start time of the query range for the attack time. Unit: milliseconds.</description></item>
        /// <item><description><b>EndTime</b>: the end time of the query range for the attack time. Unit: milliseconds.</description></item>
        /// <item><description><b>Data</b>: the data payload, which can be a JSON string or an encoded string.</description></item>
        /// <item><description><b>Base64</b>: specifies whether to decode the <b>Data</b> parameter. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Decodes the <b>Data</b> parameter by using Base64.</description></item>
        /// <item><description><b>false</b>: Does not decode the <b>Data</b> parameter.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>attackEvent</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>AttackType</b>: the attack type. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>9</b>: SQL Server brute-force attack.</description></item>
        /// <item><description><b>5</b>: SSH brute-force attack.</description></item>
        /// <item><description><b>6</b>: RDP brute-force attack.</description></item>
        /// <item><description><b>101</b>: Java Struts2 attack interception.</description></item>
        /// <item><description><b>102</b>: Redis attack interception.</description></item>
        /// <item><description><b>103</b>: AntSword web shell communication.</description></item>
        /// <item><description><b>104</b>: Chopper web shell communication.</description></item>
        /// <item><description><b>133</b>: XISE web shell communication.</description></item>
        /// <item><description><b>161</b>: Web shell upload.</description></item>
        /// <item><description><b>209</b>: PHP web shell upload.</description></item>
        /// <item><description><b>210</b>: JSP web shell upload.</description></item>
        /// <item><description><b>211</b>: ASP web shell upload.</description></item>
        /// <item><description><b>215</b>: Web shell upload with a special extension.</description></item>
        /// <item><description><b>ai_webshell</b>: Intelligent defense against web shell upload.</description></item>
        /// <item><description><b>java_common_rce</b>: Interception of common Java RCE vulnerabilities.</description></item>
        /// <item><description><b>alinet_webrce</b>: Adaptive web attack defense.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>StartTime</b>: the start time of the query range for the attack time. Unit: milliseconds.</description></item>
        /// <item><description><b>EndTime</b>: the end time of the query range for the attack time. Unit: milliseconds.</description></item>
        /// <item><description><b>AttackInstance</b>: the attacked asset. This parameter matches the server name, public IP address, and private IP address at the same time.</description></item>
        /// <item><description><b>SrcIp</b>: the source IP address of the attack.</description></item>
        /// <item><description><b>RemoteIp</b>: the actual source IP address.</description></item>
        /// <item><description><b>DstPort</b>: the destination port.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>accessKey</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>Status</b>: the handling status. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>dealed</b>: Handled.</description></item>
        /// <item><description><b>pending</b>: Unhandled.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>Query</b>: the AccessKey ID.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>exportObjectScanEvents</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>AiDetect</b>: specifies whether the event is detected by AI. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>RiskLevel</b>: the risk level. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>high</b>: High.</description></item>
        /// <item><description><b>medium</b>: Medium.</description></item>
        /// <item><description><b>low</b>: Low.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>Status</b>: the status. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Unhandled.</description></item>
        /// <item><description><b>1</b>: Manually handled.</description></item>
        /// <item><description><b>2</b>: Whitelisted.</description></item>
        /// <item><description><b>3</b>: Ignored.</description></item>
        /// <item><description><b>4</b>: Access denied.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>TimeStart</b>: the start time of the query range for the latest detection time. Unit: milliseconds.</description></item>
        /// <item><description><b>TimeEnd</b>: the end time of the query range for the latest detection time. Unit: milliseconds.</description></item>
        /// <item><description><b>EventName</b>: the threat tag.</description></item>
        /// <item><description><b>Md5</b>: the MD5 hash of the file.</description></item>
        /// <item><description><b>OssKey</b>: the file name.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>domainDetail</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>fuzzyDomain</b>: the domain name for fuzzy search.</description></item>
        /// <item><description><b>domainType</b>: the domain name type. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>root</b>: Root domain name.</description></item>
        /// <item><description><b>sub</b>: Subdomain name.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>exportHcWarning</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>CheckWarningStatusList</b>: the status list. The value is a JSON array. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Failed.</description></item>
        /// <item><description><b>3</b>: Passed.</description></item>
        /// <item><description><b>6</b>: Whitelisted.</description></item>
        /// <item><description><b>8</b>: Fixed.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>UuidList</b>: the asset UUIDs. The value is a JSON array.</description></item>
        /// <item><description><b>CheckLevel</b>: the risk level. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>high</b>: High.</description></item>
        /// <item><description><b>medium</b>: Medium.</description></item>
        /// <item><description><b>low</b>: Low.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>Source</b>: the source. Set the value to <b>default</b>.</description></item>
        /// <item><description><b>RiskType</b>: the risk type. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>hc_custom</b>: Custom baseline.</description></item>
        /// <item><description><b>cis</b>: CIS benchmarks.</description></item>
        /// <item><description><b>hc_exploit</b>: Unauthorized access.</description></item>
        /// <item><description><b>hc_djbh</b>: Classified protection compliance.</description></item>
        /// <item><description><b>weak_password</b>: Weak password.</description></item>
        /// <item><description><b>hw_security</b>: Basic protection security practices.</description></item>
        /// <item><description><b>hc_container</b>: Container security.</description></item>
        /// <item><description><b>hc_best_secruity</b>: Best security practices.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>RiskName</b>: the baseline name.</description></item>
        /// <item><description><b>CheckItemFuzzy</b>: the check item name for fuzzy search.</description></item>
        /// <item><description><b>CleartextPwd</b>: the export method for weak password baseline check results. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Exports weak passwords after data masking.</description></item>
        /// <item><description><b>1</b>: Exports weak passwords in plaintext.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>StrategyId</b>: the policy ID.</description></item>
        /// <item><description><b>GroupId</b>: the asset group ID.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>assetsPropertyScaProcessDetail</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>uuid</b>: the asset UUID.</description></item>
        /// <item><description><b>pid</b>: the process ID.</description></item>
        /// <item><description><b>remark</b>: the remarks. This parameter matches the server name, public IP address, and private IP address at the same time.</description></item>
        /// <item><description><b>cmdline</b>: the command line.</description></item>
        /// <item><description><b>bizType</b>: the component type.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>raspAttackAlert</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>day</b>: the number of days to query. If this parameter is empty, the query is based on the specified time range. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Today.</description></item>
        /// <item><description><b>7</b>: Last 7 days.</description></item>
        /// <item><description><b>30</b>: Last 30 days.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>StartTimestamp</b>: the start time. Unit: milliseconds.</description></item>
        /// <item><description><b>EndTimestamp</b>: the end time. Unit: milliseconds.</description></item>
        /// <item><description><b>Severity</b>: the severity level. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>high</b>: High.</description></item>
        /// <item><description><b>medium</b>: Medium.</description></item>
        /// <item><description><b>low</b>: Low.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>HandlerType</b>: the handling action. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>monitor</b>: Monitor.</description></item>
        /// <item><description><b>block</b>: Block.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>HandleStatus</b>: the handling status. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Unhandled.</description></item>
        /// <item><description><b>1</b>: Handled.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>AttackUrl</b>: the request URL.</description></item>
        /// <item><description><b>Hostname</b>: the hostname.</description></item>
        /// <item><description><b>Remote</b>: the attacker IP address.</description></item>
        /// <item><description><b>Pid</b>: the process ID.</description></item>
        /// <item><description><b>ApplicationId</b>: the application ID.</description></item>
        /// <item><description><b>RaspType</b>: the application language. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>java</b>: Java.</description></item>
        /// <item><description><b>php</b>: PHP.</description></item>
        /// <item><description><b>python</b>: Python.</description></item>
        /// <item><description><b>nodejs</b>: Node.js.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>AttackType</b>: the attack type. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>file_read</b>: Arbitrary file read.</description></item>
        /// <item><description><b>sql</b>: SQL injection.</description></item>
        /// <item><description><b>xxe</b>: XXE.</description></item>
        /// <item><description><b>ssrf</b>: SSRF.</description></item>
        /// <item><description><b>rce</b>: Remote command execution.</description></item>
        /// <item><description><b>file</b>: Malicious file read and write.</description></item>
        /// <item><description><b>thread_inject</b>: Thread injection.</description></item>
        /// <item><description><b>file_upload</b>: Malicious file upload.</description></item>
        /// <item><description><b>file_list</b>: Directory traversal.</description></item>
        /// <item><description><b>memory_shell</b>: In-memory webshell injection.</description></item>
        /// <item><description><b>jni</b>: JNI injection.</description></item>
        /// <item><description><b>dns</b>: Malicious DNS query.</description></item>
        /// <item><description><b>reflect</b>: Malicious reflection call.</description></item>
        /// <item><description><b>file_delete</b>: Arbitrary file deletion.</description></item>
        /// <item><description><b>jndi</b>: JNDI injection.</description></item>
        /// <item><description><b>read_object</b>: Deserialization attack.</description></item>
        /// <item><description><b>dangerous_protocol</b>: Dangerous protocol usage.</description></item>
        /// <item><description><b>attach</b>: Malicious attach.</description></item>
        /// <item><description><b>expression</b>: Expression injection.</description></item>
        /// <item><description><b>engine</b>: Engine injection.</description></item>
        /// <item><description><b>beans</b>: Malicious beans binding.</description></item>
        /// <item><description><b>classloader</b>: Malicious class loading.</description></item>
        /// <item><description><b>jstl</b>: JSTL arbitrary file inclusion.</description></item>
        /// <item><description><b>callable</b>: Callback function execution.</description></item>
        /// <item><description><b>unserialize</b>: Deserialization.</description></item>
        /// <item><description><b>include</b>: Malicious file inclusion.</description></item>
        /// <item><description><b>eval</b>: Arbitrary code execution.</description></item>
        /// <item><description><b>template</b>: Server-side template injection.</description></item>
        /// <item><description><b>process_binding</b>: Malicious process binding.</description></item>
        /// <item><description><b>fork</b>: Malicious process creation.</description></item>
        /// <item><description><b>file_link</b>: Malicious file link.</description></item>
        /// <item><description><b>file_write</b>: Arbitrary file write.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>raspApplicationConfiguration</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>ProtectionSwitch</b>: the protection switch. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>RaspType</b>: the application language. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>java</b>: Java.</description></item>
        /// <item><description><b>php</b>: PHP.</description></item>
        /// <item><description><b>python</b>: Python.</description></item>
        /// <item><description><b>nodejs</b>: Node.js.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>ProtectionMode</b>: the protection mode. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>monitor</b>: Monitor.</description></item>
        /// <item><description><b>block</b>: Block.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>ApplicationName</b>: the application group name.</description></item>
        /// <item><description><b>SortField</b>: the sort field. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>authorizedProcess</b>: Authorized processes.</description></item>
        /// <item><description><b>accessedProcess</b>: Connected processes.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>SortOrder</b>: the sort order. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>desc</b>: Descending.</description></item>
        /// <item><description><b>asc</b>: Ascending.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>raspWeaknessDetection</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>day</b>: the number of days to query. If this parameter is empty, the query is based on the specified time range. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Today.</description></item>
        /// <item><description><b>7</b>: Last 7 days.</description></item>
        /// <item><description><b>30</b>: Last 30 days.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>StartTimestamp</b>: the start time of the check time range. Unit: milliseconds.</description></item>
        /// <item><description><b>EndTimestamp</b>: the end time of the check time range. Unit: milliseconds.</description></item>
        /// <item><description><b>CheckState</b>: the status. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>0</b>: To be confirmed.</description></item>
        /// <item><description><b>1</b>: Confirmed.</description></item>
        /// <item><description><b>2</b>: False positive.</description></item>
        /// <item><description><b>3</b>: Ignored.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>Severity</b>: the risk level. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>high</b>: High.</description></item>
        /// <item><description><b>medium</b>: Medium.</description></item>
        /// <item><description><b>low</b>: Low.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>Type</b>: the weakness type. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>fastjson</b>: Insecure Fastjson configuration.</description></item>
        /// <item><description><b>jmx_config</b>: Insecure JMX configuration.</description></item>
        /// <item><description><b>jndi_config</b>: Insecure JNDI configuration.</description></item>
        /// <item><description><b>log4j</b>: Insecure Log4j component.</description></item>
        /// <item><description><b>rhino_config</b>: Insecure Rhino configuration.</description></item>
        /// <item><description><b>risk_start_up_param</b>: Insecure startup parameters.</description></item>
        /// <item><description><b>shiro</b>: Weak Shiro key.</description></item>
        /// <item><description><b>spring_config</b>: Insecure Spring configuration.</description></item>
        /// <item><description><b>weak_auth</b>: Weak server-side password.</description></item>
        /// <item><description><b>xml_config</b>: Insecure XML configuration.</description></item>
        /// <item><description><b>sql_connection</b>: Weak database password.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>ApplicationId</b>: the application ID.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>raspInMemoryWebshellDetection</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>day</b>: the number of days to query. If this parameter is empty, the query is based on the specified time range. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Today.</description></item>
        /// <item><description><b>7</b>: Last 7 days.</description></item>
        /// <item><description><b>30</b>: Last 30 days.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>StartTimestamp</b>: the start time of the check time range. Unit: milliseconds.</description></item>
        /// <item><description><b>EndTimestamp</b>: the end time of the check time range. Unit: milliseconds.</description></item>
        /// <item><description><b>HandlerType</b>: the handling action. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>monitor</b>: Monitor.</description></item>
        /// <item><description><b>block</b>: Block.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>ApplicationId</b>: the application ID.</description></item>
        /// <item><description><b>Confidence</b>: the confidence level. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>high</b>: High.</description></item>
        /// <item><description><b>medium</b>: Medium.</description></item>
        /// <item><description><b>low</b>: Low.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>HandleStatus</b>: the handling status. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Unhandled.</description></item>
        /// <item><description><b>1</b>: Automatically handled.</description></item>
        /// <item><description><b>2</b>: Manually handled.</description></item>
        /// <item><description><b>3</b>: Ignored.</description></item>
        /// <item><description><b>4</b>: False positive.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>ClassName</b>: the class name.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>raspInMemoryWebshellInsertion</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>day</b>: the number of days to query. If this parameter is empty, the query is based on the specified time range. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Today.</description></item>
        /// <item><description><b>7</b>: Last 7 days.</description></item>
        /// <item><description><b>30</b>: Last 30 days.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>StartTimestamp</b>: the start time of the check time range. Unit: milliseconds.</description></item>
        /// <item><description><b>EndTimestamp</b>: the end time of the check time range. Unit: milliseconds.</description></item>
        /// <item><description><b>HandlerType</b>: the handling action. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>monitor</b>: Monitor.</description></item>
        /// <item><description><b>block</b>: Block.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>ApplicationId</b>: the application ID.</description></item>
        /// <item><description><b>Severity</b>: the attack severity level. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>high</b>: High.</description></item>
        /// <item><description><b>medium</b>: Medium.</description></item>
        /// <item><description><b>low</b>: Low.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>AttackUrl</b>: the request URL.</description></item>
        /// <item><description><b>Hostname</b>: the hostname.</description></item>
        /// <item><description><b>Remote</b>: the attacker IP address.</description></item>
        /// <item><description><b>Pid</b>: the process ID.</description></item>
        /// <item><description><b>RaspType</b>: the application language. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>java</b>: Java.</description></item>
        /// <item><description><b>php</b>: PHP.</description></item>
        /// <item><description><b>python</b>: Python.</description></item>
        /// <item><description><b>nodejs</b>: Node.js.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>When <b>ExportType</b> is set to <b>listAgentExport</b>, the JSON supports the following filter conditions:<remarks>
        /// <list type="bullet">
        /// <item><description><b>Vendor</b>: the agent vendor. Set the value to the vendor type ID. Valid values:<remarks>
        /// <list type="bullet">
        /// <item><description><b>300</b>: Dify.</description></item>
        /// <item><description><b>301</b>: Alibaba Cloud Model Studio.</description></item>
        /// <item><description><b>302</b>: PAI.</description></item>
        /// <item><description><b>303</b>: Volcengine.</description></item>
        /// <item><description><b>304</b>: Agent Run.</description></item>
        /// <item><description><b>305</b>: OpenClaw.</description></item>
        /// <item><description><b>306</b>: ZeroClaw.</description></item>
        /// <item><description><b>307</b>: Hermes Agent.</description></item>
        /// <item><description><b>308</b>: QwenPaw.</description></item>
        /// <item><description><b>309</b>: CoPaw.</description></item>
        /// <item><description><b>310</b>: Gemini.</description></item>
        /// <item><description><b>311</b>: Claude.</description></item>
        /// <item><description><b>312</b>: CodeX.</description></item>
        /// <item><description><b>313</b>: OpenCode.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Vendor&quot;:&quot;UNKNOWN&quot;,&quot;CurrentPage&quot;:1,&quot;PageSize&quot;:10,&quot;OrderBy&quot;:&quot;CheckTime&quot;,&quot;Order&quot;:&quot;desc&quot;}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the member accounts in the resource folder belong.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain the value of this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1232428423234****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

    }

}
