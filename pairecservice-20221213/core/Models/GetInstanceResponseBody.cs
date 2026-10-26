// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetInstanceResponseBody : TeaModel {
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
        /// <para>The configuration of the instance.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyConfig Config { get; set; }
        public class GetInstanceResponseBodyConfig : TeaModel {
            /// <summary>
            /// <para>The modeling environments.</para>
            /// </summary>
            [NameInMap("DataManagements")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyConfigDataManagements> DataManagements { get; set; }
            public class GetInstanceResponseBodyConfigDataManagements : TeaModel {
                /// <summary>
                /// <para>The code of the component.</para>
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
                /// <para>The type of the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The service engines.</para>
            /// </summary>
            [NameInMap("Engines")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyConfigEngines> Engines { get; set; }
            public class GetInstanceResponseBodyConfigEngines : TeaModel {
                /// <summary>
                /// <para>The code of the component.</para>
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
                /// <para>The type of the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hologres</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The supporting features.</para>
            /// </summary>
            [NameInMap("Monitors")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyConfigMonitors> Monitors { get; set; }
            public class GetInstanceResponseBodyConfigMonitors : TeaModel {
                /// <summary>
                /// <para>The code of the component.</para>
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
                /// <para>The type of the component.</para>
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
        /// <para>The time when the instance expires. The time is displayed in UTC and follows the ISO 8601 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-14T00:00:00Z</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// <para>The Feature Store information.</para>
        /// </summary>
        [NameInMap("FeatureStoreInfo")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyFeatureStoreInfo FeatureStoreInfo { get; set; }
        public class GetInstanceResponseBodyFeatureStoreInfo : TeaModel {
            /// <summary>
            /// <para>The status of FeatureDB.</para>
            /// </summary>
            [NameInMap("FeatureDBStatus")]
            [Validation(Required=false)]
            public string FeatureDBStatus { get; set; }

            /// <summary>
            /// <para>The ID of the Feature Store instance.</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <para>The time when the instance was created. The time is displayed in UTC and follows the ISO 8601 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-13T04:55:12Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the instance was updated. The time is displayed in UTC and follows the ISO 8601 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-05T09:02:30Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-test1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The configurations of the operations tool.</para>
        /// </summary>
        [NameInMap("OperatingTool")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyOperatingTool OperatingTool { get; set; }
        public class GetInstanceResponseBodyOperatingTool : TeaModel {
            /// <summary>
            /// <para>Specifies whether the operations tool is enabled for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>True: Enabled.</description></item>
            /// <item><description>False: Disabled.</description></item>
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
        /// <para>The recommendation customization configurations.</para>
        /// </summary>
        [NameInMap("RecommendCustomization")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyRecommendCustomization RecommendCustomization { get; set; }
        public class GetInstanceResponseBodyRecommendCustomization : TeaModel {
            /// <summary>
            /// <para>Specifies whether recommendation customization is enabled.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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

}
