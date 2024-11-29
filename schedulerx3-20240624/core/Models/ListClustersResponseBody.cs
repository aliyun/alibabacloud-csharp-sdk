// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class ListClustersResponseBody : TeaModel {
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
        public ListClustersResponseBodyData Data { get; set; }
        public class ListClustersResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ListClustersResponseBodyDataRecords> Records { get; set; }
            public class ListClustersResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>PREPAY</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxljob-c20f7ec9a78</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxl-job-test-1730427510169</para>
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
                /// <para><a href="http://xxljob-b9e19e46c4e.schedulerx.mse.aliyuncs.com">http://xxljob-b9e19e46c4e.schedulerx.mse.aliyuncs.com</a></para>
                /// </summary>
                [NameInMap("IntranetDomain")]
                [Validation(Required=false)]
                public string IntranetDomain { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public int? ProductType { get; set; }

                [NameInMap("SpInstanceId")]
                [Validation(Required=false)]
                public string SpInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("VSwitches")]
                [Validation(Required=false)]
                public List<ListClustersResponseBodyDataRecordsVSwitches> VSwitches { get; set; }
                public class ListClustersResponseBodyDataRecordsVSwitches : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>vsw-8vbl54xzux86usy61r5zm</para>
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-h</para>
                    /// </summary>
                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

                /// <summary>
                /// <para>VPC ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1fxort6ag5h9752i305</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter error: content is null.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>39938688-0BAB-5AD8-BF02-F4910FAC7589</para>
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
