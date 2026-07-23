// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyInstances> Instances { get; set; }
        public class ListInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The billing method of the instance. Only <c>Subscription</c> (prepaid) is supported.</para>
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
                /// <para>A list of data management configurations.</para>
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
                    /// <para>The metadata of the component.</para>
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
                /// <para>A list of service engines.</para>
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
                    /// <para>The metadata of the component.</para>
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
                /// <para>A list of monitoring components.</para>
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
                    /// <para>The metadata of the component.</para>
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
            /// <para>The time when the instance expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-14 00:00:00.0</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-13 17:34:52.0</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The time when the instance was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-05 09:02:30.0</para>
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
            /// <para>The configuration of the operating tool.</para>
            /// </summary>
            [NameInMap("OperatingTool")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesOperatingTool OperatingTool { get; set; }
            public class ListInstancesResponseBodyInstancesOperatingTool : TeaModel {
                /// <summary>
                /// <para>Specifies whether the operating tool is enabled for the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: The tool is enabled.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: The tool is disabled.</para>
                /// </description></item>
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
            /// <item><description><para><c>cn-shenzhen</c>: China (Shenzhen)</para>
            /// </description></item>
            /// <item><description><para><c>cn-hangzhou</c>: China (Hangzhou)</para>
            /// </description></item>
            /// <item><description><para><c>cn-beijing</c>: China (Beijing)</para>
            /// </description></item>
            /// <item><description><para><c>cn-shanghai</c>: China (Shanghai)</para>
            /// </description></item>
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
            /// <item><description><para><c>Initializing</c>: The instance is initializing.</para>
            /// </description></item>
            /// <item><description><para><c>Stopped</c>: The instance is stopped.</para>
            /// </description></item>
            /// <item><description><para><c>Running</c>: The instance is running.</para>
            /// </description></item>
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
            /// <item><description><para><c>basic</c>: Basic Edition</para>
            /// </description></item>
            /// <item><description><para><c>high-level</c>: High-level Edition</para>
            /// </description></item>
            /// <item><description><para><c>advanced</c>: Advanced Edition</para>
            /// </description></item>
            /// <item><description><para><c>standard</c>: Standard Edition</para>
            /// </description></item>
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
        /// <para>The total number of returned instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
