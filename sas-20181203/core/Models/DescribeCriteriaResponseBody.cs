// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCriteriaResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of asset query criteria.</para>
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<DescribeCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class DescribeCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// <para>The specific structured property values of the asset that correspond to the entered fuzzy match value. The value is in JSON format and contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>vendor</b>: The provider.</description></item>
            /// <item><description><b>regionIds</b>: The supported regions.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;vendor&quot;:0,&quot;regionIds&quot;:{&quot;default&quot;:[&quot;ap-southeast-1&quot;,&quot;ap-northeast-2&quot;,&quot;ap-southeast-3&quot;,&quot;ap-southeast-5&quot;,&quot;ap-southeast-7&quot;,&quot;me-central-1&quot;]}},{&quot;vendor&quot;:1,&quot;regionIds&quot;:{&quot;default&quot;:[&quot;outside-of-aliyun&quot;]}}]</para>
            /// </summary>
            [NameInMap("MultiValues")]
            [Validation(Required=false)]
            public string MultiValues { get; set; }

            /// <summary>
            /// <para>The name of the corresponding query criterion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>internetIp</b>: The public IP address.</description></item>
            /// <item><description><b>intranetIp</b>: The private IP address.</description></item>
            /// <item><description><b>instanceName</b>: The instance name.</description></item>
            /// <item><description><b>instanceId</b>: The instance ID.</description></item>
            /// <item><description><b>machineType</b>: The instance type.</description></item>
            /// <item><description><b>clusterIdList</b>: The list of cluster IDs.</description></item>
            /// <item><description><b>vpcInstanceId</b>: The ID of the VPC to which the instance belongs.</description></item>
            /// <item><description><b>osName</b>: The operating system.</description></item>
            /// <item><description><b>osType</b>: The system type.</description></item>
            /// <item><description><b>hcStatus</b>: Whether baseline risks exist.</description></item>
            /// <item><description><b>vulStatus</b>: Whether vulnerabilities exist.</description></item>
            /// <item><description><b>asapVulStatus</b>: Whether urgent vulnerabilities exist.</description></item>
            /// <item><description><b>alarmStatus</b>: Whether security alerts exist.</description></item>
            /// <item><description><b>riskStatus</b>: Whether risks exist.</description></item>
            /// <item><description><b>clientStatus</b>: Whether the client is online.</description></item>
            /// <item><description><b>clientSubStatus</b>: The client sub-status.</description></item>
            /// <item><description><b>runningStatus</b>: The running status.</description></item>
            /// <item><description><b>tagName</b>: The tag name.</description></item>
            /// <item><description><b>vendorAuthAlias</b>: The alias of the authorized account.</description></item>
            /// <item><description><b>vendorUid</b>: The ID of the authorized account.</description></item>
            /// <item><description><b>vendorUserName</b>: The name of the authorized account.</description></item>
            /// <item><description><b>namespace</b>: The namespace.</description></item>
            /// <item><description><b>appName</b>: The application name.</description></item>
            /// <item><description><b>groupName</b>: The group name.</description></item>
            /// <item><description><b>regionId</b>: The region.</description></item>
            /// <item><description><b>groupId</b>: The group ID.</description></item>
            /// <item><description><b>newInstance</b>: Whether the asset is newly added.</description></item>
            /// <item><description><b>containerStatus</b>: Whether containers exist.</description></item>
            /// <item><description><b>importance</b>: The asset importance.</description></item>
            /// <item><description><b>exposedStatus</b>: Whether the server is exposed.</description></item>
            /// <item><description><b>clusterId</b>: The cluster ID.</description></item>
            /// <item><description><b>authVersion</b>: The authorized edition.</description></item>
            /// <item><description><b>flag</b>: The cloud provider.</description></item>
            /// <item><description><b>ipList</b>: The list of IP addresses.</description></item>
            /// <item><description><b>uuidList</b>: The list of UUIDs.</description></item>
            /// <item><description><b>aiStatus</b>: Whether AI components exist.</description></item>
            /// <item><description><b>tagKeyValue</b>: The ECS tag.</description></item>
            /// <item><description><b>ecsType</b>: The server type.</description></item>
            /// <item><description><b>alisecguardStatus</b>: The self-protection status.</description></item>
            /// <item><description><b>alihipsStatus</b>: The AliHips status.</description></item>
            /// <item><description><b>alinetStatus</b>: The AliNet status.</description></item>
            /// <item><description><b>alidetectStatus</b>: The endpoint engine status.</description></item>
            /// <item><description><b>yundunMonitorStatus</b>: The information collection component status.</description></item>
            /// <item><description><b>clusterNodeStatus</b>: Whether the instance is a cluster node.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>internetIp</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the query criterion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>input</b>: You must manually enter the query field.</description></item>
            /// <item><description><b>select</b>: You must select the subtype of the query criterion from a drop-down list.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>input</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The specific property values of the asset that correspond to the entered fuzzy match value.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If <b>Name</b> is <b>machineType</b>, valid values:<remarks>
            /// <list type="bullet">
            /// <item><description><b>38</b>: Elastic Container Instance.</description></item>
            /// <item><description><b>51</b>: RunD container instance.</description></item>
            /// <item><description><b>52</b>: RunC container instance.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>If <b>Name</b> is <b>osType</b>, valid values:<remarks>
            /// <list type="bullet">
            /// <item><description><b>linux</b>: Linux.</description></item>
            /// <item><description><b>windows</b>: Windows.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>If <b>Name</b> is <b>hcStatus</b>, valid values:<remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No.</description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>If <b>Name</b> is <b>vulStatus</b>, valid values:<remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No.</description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>If <b>Name</b> is <b>asapVulStatus</b>, valid values:<remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No.</description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>If <b>Name</b> is <b>alarmStatus</b>, valid values:<remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No.</description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>If <b>Name</b> is <b>riskStatus</b>, valid values:<remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No.</description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// <item><description><b>UNKNOWN</b>: Unknown.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>If <b>Name</b> is <b>clientStatus</b>, valid values:<remarks>
            /// <list type="bullet">
            /// <item><description><b>online</b>: Online.</description></item>
            /// <item><description><b>offline</b>: Offline.</description></item>
            /// <item><description><b>pause</b>: Protection paused.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>If <b>Name</b> is <b>clientSubStatus</b>, valid values:<remarks>
            /// <list type="bullet">
            /// <item><description><b>online</b>: Online.</description></item>
            /// <item><description><b>offline</b>: Offline.</description></item>
            /// <item><description><b>pause</b>: Protection paused.</description></item>
            /// <item><description><b>stopped</b>: Stopped.</description></item>
            /// <item><description><b>uninstalled</b>: Uninstalled.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>If <b>Name</b> is <b>runningStatus</b>, valid values:<remarks>
            /// <list type="bullet">
            /// <item><description><b>Running</b>: Running.</description></item>
            /// <item><description><b>notRunning</b>: Stopped.</description></item>
            /// <item><description><b>UNKNOWN</b>: Unknown.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>If <b>Name</b> is <b>importance</b>, valid values:<remarks>
            /// <list type="bullet">
            /// <item><description><b>important</b>: Important.</description></item>
            /// <item><description><b>general</b>: General.</description></item>
            /// <item><description><b>test</b>: Test.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>If <b>Name</b> is <b>containerStatus</b>, valid values:<remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No.</description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>If <b>Name</b> is <b>exposedStatus</b>, valid values:<remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No.</description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>If <b>Name</b> is <b>authVersion</b>, valid values:<remarks>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Free Edition.</description></item>
            /// <item><description><b>3</b>: Enterprise Edition.</description></item>
            /// <item><description><b>5</b>: Advanced Edition.</description></item>
            /// <item><description><b>6</b>: Anti-virus Edition.</description></item>
            /// <item><description><b>7</b>: Ultimate Edition.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>If <b>Name</b> is <b>flag</b>, valid values:<remarks>
            /// <list type="bullet">
            /// <item><description><b>0|8|15</b>: Alibaba Cloud.</description></item>
            /// <item><description><b>1</b>: Non-cloud host.</description></item>
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
            /// <item><description><b>17</b>: CTyun.</description></item>
            /// <item><description><b>18</b>: Baidu Cloud.</description></item>
            /// <item><description><b>19</b>: UCloud.</description></item>
            /// <item><description><b>20</b>: Kingsoft Cloud.</description></item>
            /// <item><description><b>21</b>: Oracle Cloud.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>If <b>Name</b> is <b>aiStatus</b>, valid values:<remarks>
            /// <list type="bullet">
            /// <item><description><b>NO</b>: No.</description></item>
            /// <item><description><b>YES</b>: Yes.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>If <b>Name</b> is <b>ecsType</b>, valid values:<remarks>
            /// <list type="bullet">
            /// <item><description><b>8</b>: Simple Application Server.</description></item>
            /// <item><description><b>11</b>: Lingjun.</description></item>
            /// <item><description><b>15</b>: RDS Custom.</description></item>
            /// <item><description><b>!8</b>: ECS instance.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>If <b>Name</b> is <b>alisecguardStatus</b>, valid values:<remarks>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Plugin online.</description></item>
            /// <item><description><b>1</b>: Disabled.</description></item>
            /// <item><description><b>2</b>: Plugin offline.</description></item>
            /// <item><description><b>-99</b>: Installation failed.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>If <b>Name</b> is <b>alihipsStatus</b>, valid values:<remarks>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Plugin online.</description></item>
            /// <item><description><b>1</b>: Disabled.</description></item>
            /// <item><description><b>2</b>: Plugin offline.</description></item>
            /// <item><description><b>-99</b>: Installation failed.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>If <b>Name</b> is <b>alinetStatus</b>, valid values:<remarks>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Plugin online.</description></item>
            /// <item><description><b>1</b>: Disabled.</description></item>
            /// <item><description><b>2</b>: Plugin offline.</description></item>
            /// <item><description><b>-99</b>: Installation failed.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>If <b>Name</b> is <b>alidetectStatus</b>, valid values:<remarks>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Plugin online.</description></item>
            /// <item><description><b>1</b>: Disabled.</description></item>
            /// <item><description><b>2</b>: Plugin offline.</description></item>
            /// <item><description><b>-99</b>: Installation failed.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>If <b>Name</b> is <b>yundunMonitorStatus</b>, valid values:<remarks>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Plugin online.</description></item>
            /// <item><description><b>1</b>: Disabled.</description></item>
            /// <item><description><b>2</b>: Plugin offline.</description></item>
            /// <item><description><b>-99</b>: Installation failed.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// <item><description>If <b>Name</b> is <b>clusterNodeStatus</b>, valid values:<remarks>
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
        /// <para>The request ID. It is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8E6DDACF-99AF-5939-AFFD-FCCD3B01E724</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
