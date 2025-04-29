// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class GetClusterResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetClusterResponseBodyData Data { get; set; }
        public class GetClusterResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxljob-e0d018c6df8</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxl-job-test-1730427575152</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>scx.small.x2</para>
            /// </summary>
            [NameInMap("ClusterSpec")]
            [Validation(Required=false)]
            public string ClusterSpec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-29 15:56:36</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-29 15:56:36</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxljob</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2.0.0</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            [NameInMap("InternetDomain")]
            [Validation(Required=false)]
            public string InternetDomain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://xxljob-xxxxxx.schedulerx.mse.aliyuncs.com">http://xxljob-xxxxxx.schedulerx.mse.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("IntranetDomain")]
            [Validation(Required=false)]
            public string IntranetDomain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("JobNum")]
            [Validation(Required=false)]
            public int? JobNum { get; set; }

            /// <summary>
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
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxJobNum")]
            [Validation(Required=false)]
            public int? MaxJobNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public int? ProductType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Spm")]
            [Validation(Required=false)]
            public int? Spm { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("VSwitches")]
            [Validation(Required=false)]
            public List<GetClusterResponseBodyDataVSwitches> VSwitches { get; set; }
            public class GetClusterResponseBodyDataVSwitches : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>vsw-8vbf1n216nshvfjdyff8a</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou-k</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            [NameInMap("VersionLifecycle")]
            [Validation(Required=false)]
            public string VersionLifecycle { get; set; }

            /// <summary>
            /// <para>VPC ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1fiz967u39lt8yuxcs0</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("WorkerNum")]
            [Validation(Required=false)]
            public int? WorkerNum { get; set; }

            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<string> Zones { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Parameter error: content is null.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D0DE9C33-992A-580B-89C4-B609A292748D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
