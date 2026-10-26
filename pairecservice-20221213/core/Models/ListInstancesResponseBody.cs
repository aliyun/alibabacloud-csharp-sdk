// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance list.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyInstances> Instances { get; set; }
        public class ListInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The billing method of the instance. Only subscription is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Subscription</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The commodity code of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>airec_developers_public_cn</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The instance configuration.</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesConfig Config { get; set; }
            public class ListInstancesResponseBodyInstancesConfig : TeaModel {
                /// <summary>
                /// <para>The list of modeling environments.</para>
                /// </summary>
                [NameInMap("DataManagements")]
                [Validation(Required=false)]
                public List<ListInstancesResponseBodyInstancesConfigDataManagements> DataManagements { get; set; }
                public class ListInstancesResponseBodyInstancesConfigDataManagements : TeaModel {
                    /// <summary>
                    /// <para>The component code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>storage</para>
                    /// </summary>
                    [NameInMap("ComponentCode")]
                    [Validation(Required=false)]
                    public string ComponentCode { get; set; }

                    /// <summary>
                    /// <para>The metadata.</para>
                    /// </summary>
                    [NameInMap("Meta")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Meta { get; set; }

                    /// <summary>
                    /// <para>The component type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OSS</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The list of service engines.</para>
                /// </summary>
                [NameInMap("Engines")]
                [Validation(Required=false)]
                public List<ListInstancesResponseBodyInstancesConfigEngines> Engines { get; set; }
                public class ListInstancesResponseBodyInstancesConfigEngines : TeaModel {
                    /// <summary>
                    /// <para>The component code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>feature</para>
                    /// </summary>
                    [NameInMap("ComponentCode")]
                    [Validation(Required=false)]
                    public string ComponentCode { get; set; }

                    /// <summary>
                    /// <para>The metadata.</para>
                    /// </summary>
                    [NameInMap("Meta")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Meta { get; set; }

                    /// <summary>
                    /// <para>The component type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Hologres</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The list of supporting features.</para>
                /// </summary>
                [NameInMap("Monitors")]
                [Validation(Required=false)]
                public List<ListInstancesResponseBodyInstancesConfigMonitors> Monitors { get; set; }
                public class ListInstancesResponseBodyInstancesConfigMonitors : TeaModel {
                    /// <summary>
                    /// <para>The component code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>featuresets</para>
                    /// </summary>
                    [NameInMap("ComponentCode")]
                    [Validation(Required=false)]
                    public string ComponentCode { get; set; }

                    /// <summary>
                    /// <para>The metadata.</para>
                    /// </summary>
                    [NameInMap("Meta")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Meta { get; set; }

                    /// <summary>
                    /// <para>The component type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Platform</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The instance expiration time. The time follows the ISO 8601 standard and is displayed in the UTC time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-14T00:00:00Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The instance creation time. The time follows the ISO 8601 standard and is displayed in the UTC time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-13T17:34:52Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The instance update time. The time follows the ISO 8601 standard and is displayed in the UTC time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-05T09:02:30Z</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pairec-test1</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The configuration related to the operations tool.</para>
            /// </summary>
            [NameInMap("OperatingTool")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesOperatingTool OperatingTool { get; set; }
            public class ListInstancesResponseBodyInstancesOperatingTool : TeaModel {
                /// <summary>
                /// <para>Specifies whether the operations tool is enabled for the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Enabled.</description></item>
                /// <item><description>false: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsEnable")]
                [Validation(Required=false)]
                public bool? IsEnable { get; set; }

            }

            /// <summary>
            /// <para>The region ID. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cn-shenzhen: Shenzhen.</description></item>
            /// <item><description>cn-hangzhou: Hangzhou.</description></item>
            /// <item><description>cn-beijing: Beijing.</description></item>
            /// <item><description>cn-shanghai: Shanghai.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Initializing: Initializing.</description></item>
            /// <item><description>Stopped: Stopped.</description></item>
            /// <item><description>Running: Running.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Initializing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>basic: Basic Edition.</description></item>
            /// <item><description>highleve: Upgraded Edition.</description></item>
            /// <item><description>advance: Advanced Edition.</description></item>
            /// <item><description>standard: Standard Edition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BDB621CB-A81E-5D39-8793-39A365CBCC74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of items in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
