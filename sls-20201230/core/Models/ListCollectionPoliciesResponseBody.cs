// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListCollectionPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of collection rules returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentCount")]
        [Validation(Required=false)]
        public int? CurrentCount { get; set; }

        /// <summary>
        /// <para>The collection rules that are returned on the current page.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListCollectionPoliciesResponseBodyData> Data { get; set; }
        public class ListCollectionPoliciesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The configuration for centralized data shipping.</para>
            /// </summary>
            [NameInMap("centralizeConfig")]
            [Validation(Required=false)]
            public ListCollectionPoliciesResponseBodyDataCentralizeConfig CentralizeConfig { get; set; }
            public class ListCollectionPoliciesResponseBodyDataCentralizeConfig : TeaModel {
                /// <summary>
                /// <para>The destination Logstore for centralized data shipping.</para>
                /// 
                /// <b>Example:</b>
                /// <para>your-sls-logstore-in-beijing</para>
                /// </summary>
                [NameInMap("destLogstore")]
                [Validation(Required=false)]
                public string DestLogstore { get; set; }

                /// <summary>
                /// <para>The destination project for centralized data shipping.</para>
                /// 
                /// <b>Example:</b>
                /// <para>your-sls-project-in-beijing</para>
                /// </summary>
                [NameInMap("destProject")]
                [Validation(Required=false)]
                public string DestProject { get; set; }

                /// <summary>
                /// <para>The destination region for centralized data shipping.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("destRegion")]
                [Validation(Required=false)]
                public string DestRegion { get; set; }

                /// <summary>
                /// <para>The data retention period of the destination Logstore for centralized data shipping. Unit: days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("destTTL")]
                [Validation(Required=false)]
                public int? DestTTL { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether centralized data shipping is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("centralizeEnabled")]
            [Validation(Required=false)]
            public bool? CentralizeEnabled { get; set; }

            /// <summary>
            /// <para>The code of the log type.</para>
            /// 
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
                [NameInMap("dataProject")]
                [Validation(Required=false)]
                public string DataProject { get; set; }

                [NameInMap("dataRegion")]
                [Validation(Required=false)]
                public string DataRegion { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the collection rule is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("internalPolicy")]
            [Validation(Required=false)]
            public bool? InternalPolicy { get; set; }

            /// <summary>
            /// <para>The configuration of the collection rule.</para>
            /// </summary>
            [NameInMap("policyConfig")]
            [Validation(Required=false)]
            public ListCollectionPoliciesResponseBodyDataPolicyConfig PolicyConfig { get; set; }
            public class ListCollectionPoliciesResponseBodyDataPolicyConfig : TeaModel {
                /// <summary>
                /// <para>The IDs of the instances.</para>
                /// </summary>
                [NameInMap("instanceIds")]
                [Validation(Required=false)]
                public List<string> InstanceIds { get; set; }

                /// <summary>
                /// <para>The regions to which the instances belong.</para>
                /// </summary>
                [NameInMap("regions")]
                [Validation(Required=false)]
                public List<string> Regions { get; set; }

                /// <summary>
                /// <para>The resource collection mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("resourceMode")]
                [Validation(Required=false)]
                public string ResourceMode { get; set; }

                /// <summary>
                /// <para>The resource tags.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;tag1&quot;:&quot;value1&quot;,&quot;tag2&quot;:&quot;value2&quot;}</para>
                /// </summary>
                [NameInMap("resourceTags")]
                [Validation(Required=false)]
                public Dictionary<string, object> ResourceTags { get; set; }

            }

            /// <summary>
            /// <para>The name of the collection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>your_log_policy</para>
            /// </summary>
            [NameInMap("policyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            [NameInMap("policyUid")]
            [Validation(Required=false)]
            public string PolicyUid { get; set; }

            /// <summary>
            /// <para>The code of the Alibaba Cloud service.</para>
            /// 
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
                [NameInMap("policyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

                [NameInMap("policyUid")]
                [Validation(Required=false)]
                public string PolicyUid { get; set; }

            }

            [NameInMap("productCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

        }

        /// <summary>
        /// <para>The total number of collection rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
