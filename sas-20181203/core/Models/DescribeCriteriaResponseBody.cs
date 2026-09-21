// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCriteriaResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of asset query conditions.</para>
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<DescribeCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class DescribeCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// <para>The structured property values of the asset that correspond to the fuzzy match value. The value is in JSON format and contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>vendor</b>: the provider.</description></item>
            /// <item><description><b>regionIds</b>: the supported regions.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;vendor&quot;:0,&quot;regionIds&quot;:{&quot;default&quot;:[&quot;ap-southeast-1&quot;,&quot;ap-northeast-2&quot;,&quot;ap-southeast-3&quot;,&quot;ap-southeast-5&quot;,&quot;ap-southeast-7&quot;,&quot;me-central-1&quot;]}},{&quot;vendor&quot;:1,&quot;regionIds&quot;:{&quot;default&quot;:[&quot;outside-of-aliyun&quot;]}}]</para>
            /// </summary>
            [NameInMap("MultiValues")]
            [Validation(Required=false)]
            public string MultiValues { get; set; }

            /// <summary>
            /// <para>The name of the query condition.</para>
            /// <list type="bullet">
            /// <item><description><b>internetIp</b>: public IP address.</description></item>
            /// <item><description><b>intranetIp</b>: private IP address.</description></item>
            /// <item><description><b>instanceName</b>: instance name.</description></item>
            /// <item><description><b>instanceId</b>: instance ID.</description></item>
            /// <item><description><b>machineType</b>: instance type.</description></item>
            /// <item><description><b>clusterIdList</b>: cluster ID list.</description></item>
            /// <item><description><b>vpcInstanceId</b>: VPC ID.</description></item>
            /// <item><description><b>osName</b>: operating system.</description></item>
            /// <item><description><b>osType</b>: system type.</description></item>
            /// <item><description><b>hcStatus</b>: whether baseline issues exist.</description></item>
            /// <item><description><b>vulStatus</b>: whether vulnerability issues exist.</description></item>
            /// <item><description><b>asapVulStatus</b>: whether high-priority vulnerabilities exist.</description></item>
            /// <item><description><b>alarmStatus</b>: whether security alerts exist.</description></item>
            /// <item><description><b>riskStatus</b>: whether risks exist.</description></item>
            /// <item><description><b>clientStatus</b>: whether the client is online.</description></item>
            /// <item><description><b>clientSubStatus</b>: client substatus.</description></item>
            /// <item><description><b>runningStatus</b>: running status.</description></item>
            /// <item><description><b>tagName</b>: tag name.</description></item>
            /// <item><description><b>vendorAuthAlias</b>: authorized account alias.</description></item>
            /// <item><description><b>vendorUid</b>: authorized account ID.</description></item>
            /// <item><description><b>vendorUserName</b>: authorized account name.</description></item>
            /// <item><description><b>namespace</b>: namespace.</description></item>
            /// <item><description><b>appName</b>: application name.</description></item>
            /// <item><description><b>groupName</b>: group name.</description></item>
            /// <item><description><b>regionId</b>: region.</description></item>
            /// <item><description><b>groupId</b>: group ID.</description></item>
            /// <item><description><b>newInstance</b>: whether the asset is newly added.</description></item>
            /// <item><description><b>containerStatus</b>: whether containers exist.</description></item>
            /// <item><description><b>importance</b>: asset importance.</description></item>
            /// <item><description><b>exposedStatus</b>: whether the server is exposed.</description></item>
            /// <item><description><b>clusterId</b>: cluster ID.</description></item>
            /// <item><description><b>authVersion</b>: authorization version.</description></item>
            /// <item><description><b>flag</b>: cloud provider.</description></item>
            /// <item><description><b>ipList</b>: IP list.</description></item>
            /// <item><description><b>uuidList</b>: UUID.</description></item>
            /// <item><description><b>aiStatus</b>: whether AI components exist.</description></item>
            /// <item><description><b>tagKeyValue</b>: ECS tag.</description></item>
            /// <item><description><b>ecsType</b>: server type.</description></item>
            /// <item><description><b>alisecguardStatus</b>: self-protection status.</description></item>
            /// <item><description><b>alihipsStatus</b>: AliHips status.</description></item>
            /// <item><description><b>alinetStatus</b>: AliNet status.</description></item>
            /// <item><description><b>alidetectStatus</b>: endpoint engine status.</description></item>
            /// <item><description><b>yundunMonitorStatus</b>: information collection component status.</description></item>
            /// <item><description><b>clusterNodeStatus</b>: whether the asset is a cluster node.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>internetIp</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the query condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>input</b>: You must manually enter the query field.</description></item>
            /// <item><description><b>select</b>: You must select a subtype of the query condition from the drop-down list.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>input</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The specific asset property values that correspond to the fuzzy match value.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>When <b>Name</b> is <b>machineType</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>38</b>: Elastic Container Instance.</description></item>
            /// <item><description><b>51</b>: RunD container instance.</description></item>
            /// <item><description><b>52</b>: RunC container instance.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>osType</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>linux</b>: Linux.</description></item>
            /// <item><description><b>windows</b>: Windows.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>hcStatus</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No.</description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>vulStatus</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No.</description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>asapVulStatus</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No.</description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>alarmStatus</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No.</description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>riskStatus</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No.</description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// <item><description><b>UNKNOWN</b>: Unknown.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>clientStatus</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>online</b>: Online.</description></item>
            /// <item><description><b>offline</b>: Offline.</description></item>
            /// <item><description><b>pause</b>: Protection paused.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>clientSubStatus</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>online</b>: Online.</description></item>
            /// <item><description><b>offline</b>: Offline.</description></item>
            /// <item><description><b>pause</b>: Protection paused.</description></item>
            /// <item><description><b>stopped</b>: Shut down.</description></item>
            /// <item><description><b>uninstalled</b>: Not installed.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>runningStatus</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>Running</b>: Running.</description></item>
            /// <item><description><b>notRunning</b>: Shut down.</description></item>
            /// <item><description><b>UNKNOWN</b>: Unknown.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>importance</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>important</b>: Important.</description></item>
            /// <item><description><b>general</b>: General.</description></item>
            /// <item><description><b>test</b>: Test.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>containerStatus</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No.</description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>exposedStatus</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No.</description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>authVersion</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Free Edition.</description></item>
            /// <item><description><b>3</b>: Enterprise Edition.</description></item>
            /// <item><description><b>5</b>: Premium Edition.</description></item>
            /// <item><description><b>6</b>: Anti-virus Edition.</description></item>
            /// <item><description><b>7</b>: Ultimate Edition.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>flag</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>0|8|15</b>: Alibaba Cloud.</description></item>
            /// <item><description><b>1</b>: Non-cloud server.</description></item>
            /// <item><description><b>2</b>: IDC.</description></item>
            /// <item><description><b>3</b>: Tencent Cloud.</description></item>
            /// <item><description><b>4</b>: Huawei Cloud.</description></item>
            /// <item><description><b>5</b>: Azure.</description></item>
            /// <item><description><b>7</b>: AWS.</description></item>
            /// <item><description><b>9</b>: SAE.</description></item>
            /// <item><description><b>10</b>: PAI.</description></item>
            /// <item><description><b>13</b>: ACS.</description></item>
            /// <item><description><b>14</b>: Volcengine.</description></item>
            /// <item><description><b>16</b>: Google Cloud.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>aiStatus</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No.</description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>ecsType</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>8</b>: Simple application server.</description></item>
            /// <item><description><b>11</b>: Lingjun.</description></item>
            /// <item><description><b>15</b>: RDS Custom.</description></item>
            /// <item><description><b>!8</b>: Host server.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>alisecguardStatus</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Plugin online.</description></item>
            /// <item><description><b>1</b>: Not enabled.</description></item>
            /// <item><description><b>2</b>: Plugin offline.</description></item>
            /// <item><description><b>-99</b>: Installation failed.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>alihipsStatus</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Plugin online.</description></item>
            /// <item><description><b>1</b>: Not enabled.</description></item>
            /// <item><description><b>2</b>: Plugin offline.</description></item>
            /// <item><description><b>-99</b>: Installation failed.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>alinetStatus</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Plugin online.</description></item>
            /// <item><description><b>1</b>: Not enabled.</description></item>
            /// <item><description><b>2</b>: Plugin offline.</description></item>
            /// <item><description><b>-99</b>: Installation failed.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>alidetectStatus</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Plugin online.</description></item>
            /// <item><description><b>1</b>: Not enabled.</description></item>
            /// <item><description><b>2</b>: Plugin offline.</description></item>
            /// <item><description><b>-99</b>: Installation failed.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>yundunMonitorStatus</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Plugin online.</description></item>
            /// <item><description><b>1</b>: Not enabled.</description></item>
            /// <item><description><b>2</b>: Plugin offline.</description></item>
            /// <item><description><b>-99</b>: Installation failed.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>When <b>Name</b> is <b>clusterNodeStatus</b>, the valid values are:<remarks>
            /// <list type="bullet">
            /// <item><description><b>false</b>: No.</description></item>
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
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8E6DDACF-99AF-5939-AFFD-FCCD3B01E724</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
