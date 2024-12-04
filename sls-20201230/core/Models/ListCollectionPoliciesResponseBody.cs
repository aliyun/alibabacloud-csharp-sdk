// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListCollectionPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentCount")]
        [Validation(Required=false)]
        public int? CurrentCount { get; set; }

        /// <summary>
        /// <para>The data of the policies that are matched against the query conditions. The data is returned based on paginated results.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListCollectionPoliciesResponseBodyData> Data { get; set; }
        public class ListCollectionPoliciesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The configuration for centralized storage.</para>
            /// </summary>
            [NameInMap("centralizeConfig")]
            [Validation(Required=false)]
            public ListCollectionPoliciesResponseBodyDataCentralizeConfig CentralizeConfig { get; set; }
            public class ListCollectionPoliciesResponseBodyDataCentralizeConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>your-sls-logstore-in-beijing</para>
                /// </summary>
                [NameInMap("destLogstore")]
                [Validation(Required=false)]
                public string DestLogstore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>your-sls-project-in-beijing</para>
                /// </summary>
                [NameInMap("destProject")]
                [Validation(Required=false)]
                public string DestProject { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("destRegion")]
                [Validation(Required=false)]
                public string DestRegion { get; set; }

                /// <summary>
                /// <para>The data retention period for centralized storage. Unit: days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>your-sls-logstore-ttl</para>
                /// </summary>
                [NameInMap("destTTL")]
                [Validation(Required=false)]
                public int? DestTTL { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("centralizeEnabled")]
            [Validation(Required=false)]
            public bool? CentralizeEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>access_log</para>
            /// </summary>
            [NameInMap("dataCode")]
            [Validation(Required=false)]
            public string DataCode { get; set; }

            [NameInMap("dataConfig")]
            [Validation(Required=false)]
            public ListCollectionPoliciesResponseBodyDataDataConfig DataConfig { get; set; }
            public class ListCollectionPoliciesResponseBodyDataDataConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("dataProject")]
                [Validation(Required=false)]
                public string DataProject { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("dataRegion")]
                [Validation(Required=false)]
                public string DataRegion { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("internalPolicy")]
            [Validation(Required=false)]
            public bool? InternalPolicy { get; set; }

            [NameInMap("policyConfig")]
            [Validation(Required=false)]
            public ListCollectionPoliciesResponseBodyDataPolicyConfig PolicyConfig { get; set; }
            public class ListCollectionPoliciesResponseBodyDataPolicyConfig : TeaModel {
                [NameInMap("instanceIds")]
                [Validation(Required=false)]
                public List<string> InstanceIds { get; set; }

                [NameInMap("regions")]
                [Validation(Required=false)]
                public List<string> Regions { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("resourceMode")]
                [Validation(Required=false)]
                public string ResourceMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;tag1&quot;:&quot;value1&quot;,&quot;tag2&quot;:&quot;value2&quot;}</para>
                /// </summary>
                [NameInMap("resourceTags")]
                [Validation(Required=false)]
                public Dictionary<string, object> ResourceTags { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>your_log_policy</para>
            /// </summary>
            [NameInMap("policyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>148***********50</para>
            /// </summary>
            [NameInMap("policyUid")]
            [Validation(Required=false)]
            public string PolicyUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("productCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("resourceDirectory")]
            [Validation(Required=false)]
            public ListCollectionPoliciesResponseBodyDataResourceDirectory ResourceDirectory { get; set; }
            public class ListCollectionPoliciesResponseBodyDataResourceDirectory : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>all,custom</para>
                /// </summary>
                [NameInMap("accountGroupType")]
                [Validation(Required=false)]
                public string AccountGroupType { get; set; }

                [NameInMap("members")]
                [Validation(Required=false)]
                public List<string> Members { get; set; }

            }

        }

        [NameInMap("statistics")]
        [Validation(Required=false)]
        public List<ListCollectionPoliciesResponseBodyStatistics> Statistics { get; set; }
        public class ListCollectionPoliciesResponseBodyStatistics : TeaModel {
            [NameInMap("policySourceList")]
            [Validation(Required=false)]
            public List<ListCollectionPoliciesResponseBodyStatisticsPolicySourceList> PolicySourceList { get; set; }
            public class ListCollectionPoliciesResponseBodyStatisticsPolicySourceList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>policy_name1_from148</para>
                /// </summary>
                [NameInMap("policyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>148***********50</para>
                /// </summary>
                [NameInMap("policyUid")]
                [Validation(Required=false)]
                public string PolicyUid { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("productCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
