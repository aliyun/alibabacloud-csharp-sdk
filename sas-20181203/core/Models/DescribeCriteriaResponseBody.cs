// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCriteriaResponseBody : TeaModel {
        /// <summary>
        /// <para>List of asset query condition information.</para>
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<DescribeCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class DescribeCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// <para>The structured attribute values of the assets that match the keyword. The value of this parameter is in the JSON format and contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>vendor</b>: providers.</description></item>
            /// <item><description><b>regionIds</b>: IDs of supported regions</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;vendor&quot;:0,&quot;regionIds&quot;:{&quot;default&quot;:[&quot;ap-southeast-1&quot;,&quot;ap-northeast-2&quot;,&quot;ap-southeast-3&quot;,&quot;ap-southeast-5&quot;,&quot;ap-southeast-7&quot;,&quot;me-central-1&quot;]}},{&quot;vendor&quot;:1,&quot;regionIds&quot;:{&quot;default&quot;:[&quot;outside-of-aliyun&quot;]}}]</para>
            /// </summary>
            [NameInMap("MultiValues")]
            [Validation(Required=false)]
            public string MultiValues { get; set; }

            /// <summary>
            /// <para>The name of the search condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>internetIp</b>: Public IP Address. </description></item>
            /// <item><description><b>intranetIp</b>: Private IP Address.</description></item>
            /// <item><description><b>instanceName</b>: Instance Name.</description></item>
            /// <item><description><b>instanceId</b>: Instance ID. </description></item>
            /// <item><description><b>machineType</b>: Instance Type. </description></item>
            /// <item><description><b>clusterIdList</b>: Cluster ID list. </description></item>
            /// <item><description><b>vpcInstanceId</b>: VPC ID. </description></item>
            /// <item><description><b>osName</b>: OS. </description></item>
            /// <item><description><b>osType</b>: OS type. </description></item>
            /// <item><description><b>hcStatus</b>: Whether Baseline Risk Exists. </description></item>
            /// <item><description><b>vulStatus</b>: Whether Vulnerability Exists. </description></item>
            /// <item><description><b>asapVulStatus</b>: Whether there is an urgent vulnerability. </description></item>
            /// <item><description><b>alarmStatus</b>: Whether Alert Exists. </description></item>
            /// <item><description><b>riskStatus</b>: Whether there is a risk. </description></item>
            /// <item><description><b>clientStatus</b>: Whether it is online. </description></item>
            /// <item><description><b>clientSubStatus</b>: Client sub-status. </description></item>
            /// <item><description><b>runningStatus</b>: Power-on status. </description></item>
            /// <item><description><b>tagName</b>: Tag name. </description></item>
            /// <item><description><b>vendorAuthAlias</b>: Authorized account remarks. </description></item>
            /// <item><description><b>vendorUid</b>: Authorized account ID. </description></item>
            /// <item><description><b>vendorUserName</b>: Authorized account name. </description></item>
            /// <item><description><b>namespace</b>: Namespace. </description></item>
            /// <item><description><b>appName</b>: Application name. </description></item>
            /// <item><description><b>groupName</b>: Group name. </description></item>
            /// <item><description><b>regionId</b>: Region. </description></item>
            /// <item><description><b>groupId</b>: Group ID. </description></item>
            /// <item><description><b>newInstance</b>: Whether it is a new asset. </description></item>
            /// <item><description><b>containerStatus</b>: Whether there is a container. </description></item>
            /// <item><description><b>importance</b>: Asset importance. </description></item>
            /// <item><description><b>exposedStatus</b>: Whether it is an exposed server. </description></item>
            /// <item><description><b>clusterId</b>: Cluster ID. </description></item>
            /// <item><description><b>authVersion</b>: Authorization version. </description></item>
            /// <item><description><b>flag</b>: Cloud provider. </description></item>
            /// <item><description><b>ipList</b>: IP list. </description></item>
            /// <item><description><b>uuidList</b>: UUID. </description></item>
            /// <item><description><b>aiStatus</b>: Whether there is an AI component. </description></item>
            /// <item><description><b>tagKeyValue</b>: ECS tag. </description></item>
            /// <item><description><b>ecsType</b>: Server type. </description></item>
            /// <item><description><b>alisecguardStatus</b>: Self-protection status. </description></item>
            /// <item><description><b>alihipsStatus</b>: AliHips status. </description></item>
            /// <item><description><b>alinetStatus</b>: AliNet status. </description></item>
            /// <item><description><b>alidetectStatus</b>: Endpoint engine status. </description></item>
            /// <item><description><b>yundunMonitorStatus</b>: Information collection component status. </description></item>
            /// <item><description><b>clusterNodeStatus</b>: Whether it is a cluster node.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>internetIp</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the search condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>input</b>: The search condition needs to be specified.</description></item>
            /// <item><description><b>select</b>: The search condition is an option that can be selected from the drop-down list.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>input</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The attribute values of the assets that match the keyword.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>When <b>Name</b> is <b>machineType</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>38</b>: Elastic Container Instance. </description></item>
            /// <item><description><b>51</b>: RunD Container Instance. </description></item>
            /// <item><description><b>52</b>: RunC Container Instance.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>osType</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>linux</b>: Linux. </description></item>
            /// <item><description><b>windows</b>: Windows.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>hcStatus</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No. </description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>vulStatus</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No. </description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>asapVulStatus</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No.</description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>alarmStatus</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No. </description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>riskStatus</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No. </description></item>
            /// <item><description><b>YES</b>: Yes. </description></item>
            /// <item><description><b>UNKNOWN</b>: Unknown.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>clientStatus</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>online</b>: Online. </description></item>
            /// <item><description><b>offline</b>: Offline. </description></item>
            /// <item><description><b>pause</b>: Protection Suspended.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>clientSubStatus</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>online</b>: Online. </description></item>
            /// <item><description><b>offline</b>: Offline. </description></item>
            /// <item><description><b>pause</b>: Protection Suspended. </description></item>
            /// <item><description><b>stopped</b>: Server Shutdown. </description></item>
            /// <item><description><b>uninstalled</b>: Not Installed.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>runningStatus</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>Running</b>: On. </description></item>
            /// <item><description><b>notRunning</b>: Off. </description></item>
            /// <item><description><b>UNKNOWN</b>: Unknown.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>importance</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>important</b>: Important. </description></item>
            /// <item><description><b>general</b>: Normal. </description></item>
            /// <item><description><b>test</b>: Test.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>containerStatus</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No. </description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>exposedStatus</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No. </description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>authVersion</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Basic. </description></item>
            /// <item><description><b>3</b>: Enterprise. </description></item>
            /// <item><description><b>5</b>: Advanced.</description></item>
            /// <item><description><b>6</b>: Anti-virus. </description></item>
            /// <item><description><b>7</b>: Ultimate.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>flag</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>0|8|15</b>: Alibaba Cloud. </description></item>
            /// <item><description><b>1</b>: External Host. </description></item>
            /// <item><description><b>2</b>: IDC. </description></item>
            /// <item><description><b>3</b>: Tencent Cloud. </description></item>
            /// <item><description><b>4</b>: Huawei Cloud. </description></item>
            /// <item><description><b>5</b>: Azure. </description></item>
            /// <item><description><b>7</b>: AWS. </description></item>
            /// <item><description><b>9</b>: SAE. </description></item>
            /// <item><description><b>10</b>: PAI. </description></item>
            /// <item><description><b>13</b>: ACS. </description></item>
            /// <item><description><b>14</b>: Volcano Cloud. </description></item>
            /// <item><description><b>16</b>: Google Cloud.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>aiStatus</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No. </description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>ecsType</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>8</b>: Simple Application Server. </description></item>
            /// <item><description><b>11</b>: LINGJUN GPU-accelerated Bare Metal Instance. </description></item>
            /// <item><description><b>15</b>: RDS Custom. </description></item>
            /// <item><description><b>!8</b>: Host.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>alisecguardStatus</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Plug-in Online. </description></item>
            /// <item><description><b>1</b>: Plug-in Disabled. </description></item>
            /// <item><description><b>2</b>: Plug-in Offline. </description></item>
            /// <item><description><b>-99</b>: The installation failed.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>alihipsStatus</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Plug-in Online. </description></item>
            /// <item><description><b>1</b>: Plug-in Disabled. </description></item>
            /// <item><description><b>2</b>: Plug-in Offline. </description></item>
            /// <item><description><b>-99</b>: The installation failed.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>alinetStatus</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Plug-in Online. </description></item>
            /// <item><description><b>1</b>: Plug-in Disabled. </description></item>
            /// <item><description><b>2</b>: Plug-in Offline. </description></item>
            /// <item><description><b>-99</b>: The installation failed.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>alidetectStatus</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Plug-in Online. </description></item>
            /// <item><description><b>1</b>: Plug-in Disabled. </description></item>
            /// <item><description><b>2</b>: Plug-in Offline. </description></item>
            /// <item><description><b>-99</b>: The installation failed.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>yundunMonitorStatus</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Plug-in Online. </description></item>
            /// <item><description><b>1</b>: Plug-in Disabled. </description></item>
            /// <item><description><b>2</b>: Plug-in Offline. </description></item>
            /// <item><description><b>-99</b>: The installation failed.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>clusterNodeStatus</b>, the enum values are: <remarks>
            /// <list type="bullet">
            /// <item><description><b>false</b>: No. </description></item>
            /// <item><description><b>true</b>: Yes.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>47.96.XX.XX</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public string Values { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8E6DDACF-99AF-5939-AFFD-FCCD3B01E724</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
