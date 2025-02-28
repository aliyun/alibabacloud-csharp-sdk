// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyInstances> Instances { get; set; }
        public class ListInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Subscription</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>airec_developers_public_cn</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("Config")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesConfig Config { get; set; }
            public class ListInstancesResponseBodyInstancesConfig : TeaModel {
                [NameInMap("DataManagements")]
                [Validation(Required=false)]
                public List<ListInstancesResponseBodyInstancesConfigDataManagements> DataManagements { get; set; }
                public class ListInstancesResponseBodyInstancesConfigDataManagements : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>storage</para>
                    /// </summary>
                    [NameInMap("ComponentCode")]
                    [Validation(Required=false)]
                    public string ComponentCode { get; set; }

                    [NameInMap("Meta")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Meta { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>OSS</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("Engines")]
                [Validation(Required=false)]
                public List<ListInstancesResponseBodyInstancesConfigEngines> Engines { get; set; }
                public class ListInstancesResponseBodyInstancesConfigEngines : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>feature</para>
                    /// </summary>
                    [NameInMap("ComponentCode")]
                    [Validation(Required=false)]
                    public string ComponentCode { get; set; }

                    [NameInMap("Meta")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Meta { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Hologres</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("Monitors")]
                [Validation(Required=false)]
                public List<ListInstancesResponseBodyInstancesConfigMonitors> Monitors { get; set; }
                public class ListInstancesResponseBodyInstancesConfigMonitors : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>featuresets</para>
                    /// </summary>
                    [NameInMap("ComponentCode")]
                    [Validation(Required=false)]
                    public string ComponentCode { get; set; }

                    [NameInMap("Meta")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Meta { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Platform</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-12-14 00:00:00.0</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-10-13 17:34:52.0</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-11-05 09:02:30.0</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pairec-test1</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("OperatingTool")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesOperatingTool OperatingTool { get; set; }
            public class ListInstancesResponseBodyInstancesOperatingTool : TeaModel {
                [NameInMap("IsEnable")]
                [Validation(Required=false)]
                public bool? IsEnable { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Initializing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BDB621CB-A81E-5D39-8793-39A365CBCC74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
