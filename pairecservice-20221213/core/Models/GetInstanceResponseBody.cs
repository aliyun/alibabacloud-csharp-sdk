// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The billing method of the instance. The value is fixed as Subscription.</para>
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
        /// <para>The instance configurations.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyConfig Config { get; set; }
        public class GetInstanceResponseBodyConfig : TeaModel {
            /// <summary>
            /// <para>The list of modeling environments.</para>
            /// </summary>
            [NameInMap("DataManagements")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyConfigDataManagements> DataManagements { get; set; }
            public class GetInstanceResponseBodyConfigDataManagements : TeaModel {
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
            public List<GetInstanceResponseBodyConfigEngines> Engines { get; set; }
            public class GetInstanceResponseBodyConfigEngines : TeaModel {
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
            /// <para>The list of monitoring components.</para>
            /// </summary>
            [NameInMap("Monitors")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyConfigMonitors> Monitors { get; set; }
            public class GetInstanceResponseBodyConfigMonitors : TeaModel {
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
        /// <para>The time when the instance was last updated.</para>
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
        /// <para>The operating tool configurations.</para>
        /// </summary>
        [NameInMap("OperatingTool")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyOperatingTool OperatingTool { get; set; }
        public class GetInstanceResponseBodyOperatingTool : TeaModel {
            /// <summary>
            /// <para>Indicates whether the operating tool is enabled for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>True: Enabled</para>
            /// </description></item>
            /// <item><description><para>False: Disabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("IsEnable")]
            [Validation(Required=false)]
            public bool? IsEnable { get; set; }

        }

        /// <summary>
        /// <para>The region ID. Valid values:<br>● cn-shenzhen: Shenzhen<br>● cn-hangzhou: Hangzhou<br>● cn-beijing: Beijing<br>● cn-shanghai: Shanghai<br><br><br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The instance status. Valid values:<br>● Initializing<br>● Stopped<br>● Running<br><br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>Initializing</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The instance type. Valid values:<br>● basic: Basic<br>● highlevel: High-level<br>● advanced: Advanced<br>● standard: Standard<br><br><br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
