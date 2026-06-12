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

            /// <summary>
            /// <para>Configurations for global log types, such as sls. This parameter is empty for other log types.</para>
            /// </summary>
            [NameInMap("dataConfig")]
            [Validation(Required=false)]
            public ListCollectionPoliciesResponseBodyDataDataConfig DataConfig { get; set; }
            public class ListCollectionPoliciesResponseBodyDataDataConfig : TeaModel {
                /// <summary>
                /// <para>The project for global logs. This parameter is used only for global log types, such as sls. If this parameter is empty, logs are collected to the default project of the account in the region specified by dataRegion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("dataProject")]
                [Validation(Required=false)]
                public string DataProject { get; set; }

                /// <summary>
                /// <para>The region where global logs are first collected. This parameter is used only for global log types, such as sls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
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

            /// <summary>
            /// <para>Indicates whether the policy is a built-in policy. Built-in policies cannot be modified or deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
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

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that owns the collection rule. If a resource directory administrator or delegated administrator creates the rule, this is the ID of that administrator\&quot;s account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>148***********50</para>
            /// </summary>
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

            /// <summary>
            /// <para>The configuration of the resource directory. This parameter is empty if no configuration is available.</para>
            /// </summary>
            [NameInMap("resourceDirectory")]
            [Validation(Required=false)]
            public ListCollectionPoliciesResponseBodyDataResourceDirectory ResourceDirectory { get; set; }
            public class ListCollectionPoliciesResponseBodyDataResourceDirectory : TeaModel {
                /// <summary>
                /// <para>The mode for selecting accounts in the resource directory. Valid values: all and custom.</para>
                /// 
                /// <b>Example:</b>
                /// <para>all,custom</para>
                /// </summary>
                [NameInMap("accountGroupType")]
                [Validation(Required=false)]
                public string AccountGroupType { get; set; }

                /// <summary>
                /// <para>The list of member accounts. This parameter is returned only if accountGroupType is set to custom.</para>
                /// </summary>
                [NameInMap("members")]
                [Validation(Required=false)]
                public List<string> Members { get; set; }

            }

        }

        /// <summary>
        /// <para>Statistics returned based on the query conditions.</para>
        /// </summary>
        [NameInMap("statistics")]
        [Validation(Required=false)]
        public List<ListCollectionPoliciesResponseBodyStatistics> Statistics { get; set; }
        public class ListCollectionPoliciesResponseBodyStatistics : TeaModel {
            /// <summary>
            /// <para>The list of collection rule sources.</para>
            /// </summary>
            [NameInMap("policySourceList")]
            [Validation(Required=false)]
            public List<ListCollectionPoliciesResponseBodyStatisticsPolicySourceList> PolicySourceList { get; set; }
            public class ListCollectionPoliciesResponseBodyStatisticsPolicySourceList : TeaModel {
                /// <summary>
                /// <para>The name of the collection rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>policy_name1_from148</para>
                /// </summary>
                [NameInMap("policyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account that owns the collection rule. If a resource directory administrator or delegated administrator creates the rule, this is the ID of that administrator\&quot;s account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>148***********50</para>
                /// </summary>
                [NameInMap("policyUid")]
                [Validation(Required=false)]
                public string PolicyUid { get; set; }

            }

            /// <summary>
            /// <para>The code of the Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
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
