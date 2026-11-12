// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class GetClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The cluster details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetClusterResponseBodyData Data { get; set; }
        public class GetClusterResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PREPAY: Subscription.</description></item>
            /// <item><description>POSTPAY: Pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxljob-e0d018c6df8</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxl-job-test-1730427575152</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The cluster specifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>scx.dev.x1</description></item>
            /// <item><description>scx.small.x1</description></item>
            /// <item><description>scx.small.x2</description></item>
            /// <item><description>scx.medium.x1</description></item>
            /// <item><description>scx.medium.x2</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>scx.small.x2</para>
            /// </summary>
            [NameInMap("ClusterSpec")]
            [Validation(Required=false)]
            public string ClusterSpec { get; set; }

            /// <summary>
            /// <para>The cluster type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public int? ClusterType { get; set; }

            /// <summary>
            /// <para>The creation time. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-29 15:56:36</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The expiration time. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-29 15:56:36</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The engine type. Valid value: xxljob.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxljob</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>The DPI engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0.0</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The public domain name.</para>
            /// <remarks>
            /// <para>Not supported.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("InternetDomain")]
            [Validation(Required=false)]
            public string InternetDomain { get; set; }

            /// <summary>
            /// <para>The internal domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxljob-xxxxxx.schedulerx.mse.aliyuncs.com">http://xxljob-xxxxxx.schedulerx.mse.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("IntranetDomain")]
            [Validation(Required=false)]
            public string IntranetDomain { get; set; }

            /// <summary>
            /// <para>The IP whitelist. Separate multiple IP addresses with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.0/24</para>
            /// </summary>
            [NameInMap("IpWhitelist")]
            [Validation(Required=false)]
            public string IpWhitelist { get; set; }

            /// <summary>
            /// <para>The maximum number of tasks supported by the specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("JobNum")]
            [Validation(Required=false)]
            public int? JobNum { get; set; }

            /// <summary>
            /// <para>The configuration information of the Kubernetes server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;vSwitchIdList&quot;: [
            ///     &quot;xxx&quot;,
            ///     &quot;xxx&quot;
            ///   ],
            ///   &quot;cpu&quot;: xxx,
            ///   &quot;cpuUnit&quot;: &quot;xxx&quot;,
            ///   &quot;diskCapacity&quot;: xxx,
            ///   &quot;memoryCapacity&quot;: xxx,
            ///   &quot;zoneIds&quot;: [
            ///     &quot;xxx&quot;,
            ///     &quot;xxx&quot;
            ///   ],
            ///   &quot;securityGroupList&quot;: [
            ///     &quot;xxx&quot;
            ///   ],
            ///   &quot;eniCrossZone&quot;: &quot;xxx&quot;,
            ///   &quot;regionId&quot;: &quot;xxx&quot;,
            ///   &quot;instanceCount&quot;: xxx,
            ///   &quot;vpcId&quot;: &quot;xxx&quot;,
            ///   &quot;memoryUnit&quot;: &quot;xxx&quot;,
            ///   &quot;diskType&quot;: &quot;xxx&quot;,
            ///   &quot;appClusterId&quot;: &quot;xxx&quot;
            /// }</para>
            /// </summary>
            [NameInMap("KubeConfig")]
            [Validation(Required=false)]
            public string KubeConfig { get; set; }

            /// <summary>
            /// <para>The maximum number of tasks supported by the specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxJobNum")]
            [Validation(Required=false)]
            public int? MaxJobNum { get; set; }

            /// <summary>
            /// <para>The maximum number of supported workflows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxWorkflowNum")]
            [Validation(Required=false)]
            public int? MaxWorkflowNum { get; set; }

            /// <summary>
            /// <para>The product edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Developer Edition.</description></item>
            /// <item><description>2: Professional Edition.</description></item>
            /// <item><description>3: Enterprise Edition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public int? ProductType { get; set; }

            /// <summary>
            /// <para>The source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>schedulerx</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The peak scheduling rate per minute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Spm")]
            [Validation(Required=false)]
            public int? Spm { get; set; }

            /// <summary>
            /// <para>The cluster status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Creating.</description></item>
            /// <item><description>2: Running.</description></item>
            /// <item><description>3: Restarting.</description></item>
            /// <item><description>4: Destroying.</description></item>
            /// <item><description>5: Creation failed.</description></item>
            /// <item><description>6: Stopped.</description></item>
            /// <item><description>99: Deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The cluster tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;environment&quot;:&quot;test&quot;}</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// <para>The vSwitch information of the zones.</para>
            /// </summary>
            [NameInMap("VSwitches")]
            [Validation(Required=false)]
            public List<GetClusterResponseBodyDataVSwitches> VSwitches { get; set; }
            public class GetClusterResponseBodyDataVSwitches : TeaModel {
                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-8vbf1n216nshvfjdyff8a</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-k</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The DPI engine version life epoch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>STABLE: The version is stable.</description></item>
            /// <item><description>EXPIRED: The version has expired.</description></item>
            /// <item><description>OFFLINE: The version is offline.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STABLE</para>
            /// </summary>
            [NameInMap("VersionLifecycle")]
            [Validation(Required=false)]
            public string VersionLifecycle { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1fiz967u39lt8yuxcs0</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The number of executors.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("WorkerNum")]
            [Validation(Required=false)]
            public int? WorkerNum { get; set; }

            /// <summary>
            /// <para>The current number of workflows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("WorkflowNum")]
            [Validation(Required=false)]
            public int? WorkflowNum { get; set; }

            /// <summary>
            /// <para>The list of zones.</para>
            /// </summary>
            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<string> Zones { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter error: content is null.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request. It is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0DE9C33-992A-580B-89C4-B609A292748D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
