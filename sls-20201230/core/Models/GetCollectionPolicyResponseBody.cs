// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetCollectionPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the rule.</para>
        /// </summary>
        [NameInMap("collectionPolicy")]
        [Validation(Required=false)]
        public GetCollectionPolicyResponseBodyCollectionPolicy CollectionPolicy { get; set; }
        public class GetCollectionPolicyResponseBodyCollectionPolicy : TeaModel {
            /// <summary>
            /// <para>The configuration for centralized shipping.</para>
            /// </summary>
            [NameInMap("centralizeConfig")]
            [Validation(Required=false)]
            public GetCollectionPolicyResponseBodyCollectionPolicyCentralizeConfig CentralizeConfig { get; set; }
            public class GetCollectionPolicyResponseBodyCollectionPolicyCentralizeConfig : TeaModel {
                /// <summary>
                /// <para>The destination Logstore for centralized shipping.</para>
                /// 
                /// <b>Example:</b>
                /// <para>your-sls-logstore-in-beijing</para>
                /// </summary>
                [NameInMap("destLogstore")]
                [Validation(Required=false)]
                public string DestLogstore { get; set; }

                /// <summary>
                /// <para>The destination project for centralized shipping.</para>
                /// 
                /// <b>Example:</b>
                /// <para>your-sls-project-in-beijing</para>
                /// </summary>
                [NameInMap("destProject")]
                [Validation(Required=false)]
                public string DestProject { get; set; }

                /// <summary>
                /// <para>The destination region for centralized shipping.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("destRegion")]
                [Validation(Required=false)]
                public string DestRegion { get; set; }

                /// <summary>
                /// <para>The retention period of the destination Logstore. Unit: days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("destTTL")]
                [Validation(Required=false)]
                public int? DestTTL { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether centralized storage is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("centralizeEnabled")]
            [Validation(Required=false)]
            public bool? CentralizeEnabled { get; set; }

            /// <summary>
            /// <para>The code for the log type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>access_log</para>
            /// </summary>
            [NameInMap("dataCode")]
            [Validation(Required=false)]
            public string DataCode { get; set; }

            /// <summary>
            /// <para>The configuration that is supported only for global log types, such as when \<c>productCode\\</c> is \<c>sls\\</c>. Otherwise, this parameter is empty.</para>
            /// </summary>
            [NameInMap("dataConfig")]
            [Validation(Required=false)]
            public GetCollectionPolicyResponseBodyCollectionPolicyDataConfig DataConfig { get; set; }
            public class GetCollectionPolicyResponseBodyCollectionPolicyDataConfig : TeaModel {
                /// <summary>
                /// <para>This parameter is valid only for global log types, such as when \<c>productCode\\</c> is \<c>sls\\</c>. If this parameter is left empty, logs are collected to the default project of the account in the specified \<c>dataRegion\\</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("dataProject")]
                [Validation(Required=false)]
                public string DataProject { get; set; }

                /// <summary>
                /// <para>This parameter is supported only for global log types, such as when \<c>productCode\\</c> is \<c>sls\\</c>. This parameter specifies the region to which global logs are collected during the initial configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("dataRegion")]
                [Validation(Required=false)]
                public string DataRegion { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the rule is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Indicates whether the rule is a built-in rule. Built-in rules cannot be modified or deleted.</para>
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
            public GetCollectionPolicyResponseBodyCollectionPolicyPolicyConfig PolicyConfig { get; set; }
            public class GetCollectionPolicyResponseBodyCollectionPolicyPolicyConfig : TeaModel {
                /// <summary>
                /// <para>The instance IDs.</para>
                /// </summary>
                [NameInMap("instanceIds")]
                [Validation(Required=false)]
                public List<string> InstanceIds { get; set; }

                /// <summary>
                /// <para>The regions where the instances reside. Wildcard characters are supported.</para>
                /// </summary>
                [NameInMap("regions")]
                [Validation(Required=false)]
                public List<string> Regions { get; set; }

                /// <summary>
                /// <para>The collection pattern for resources.</para>
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
            /// <para>The name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>your_log_policy</para>
            /// </summary>
            [NameInMap("policyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the rule belongs. If the rule is created by a resource directory administrator or a delegated administrator, this parameter specifies the ID of the administrator\&quot;s Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>148***********50</para>
            /// </summary>
            [NameInMap("policyUid")]
            [Validation(Required=false)]
            public string PolicyUid { get; set; }

            /// <summary>
            /// <para>The code of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("productCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The configuration of the resource directory. This parameter is empty if no configuration is specified.</para>
            /// </summary>
            [NameInMap("resourceDirectory")]
            [Validation(Required=false)]
            public GetCollectionPolicyResponseBodyCollectionPolicyResourceDirectory ResourceDirectory { get; set; }
            public class GetCollectionPolicyResponseBodyCollectionPolicyResourceDirectory : TeaModel {
                /// <summary>
                /// <para>The mode for selecting accounts in the resource directory. Valid values: \<c>all\\</c> and \<c>custom\\</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>all,custom</para>
                /// </summary>
                [NameInMap("accountGroupType")]
                [Validation(Required=false)]
                public string AccountGroupType { get; set; }

                /// <summary>
                /// <para>The member accounts. This parameter is returned only when \<c>accountGroupType\\</c> is set to \<c>custom\\</c>.</para>
                /// </summary>
                [NameInMap("members")]
                [Validation(Required=false)]
                public List<string> Members { get; set; }

            }

        }

    }

}
