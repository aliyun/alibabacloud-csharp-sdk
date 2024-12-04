// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetCollectionPolicyResponseBody : TeaModel {
        [NameInMap("collectionPolicy")]
        [Validation(Required=false)]
        public GetCollectionPolicyResponseBodyCollectionPolicy CollectionPolicy { get; set; }
        public class GetCollectionPolicyResponseBodyCollectionPolicy : TeaModel {
            [NameInMap("centralizeConfig")]
            [Validation(Required=false)]
            public GetCollectionPolicyResponseBodyCollectionPolicyCentralizeConfig CentralizeConfig { get; set; }
            public class GetCollectionPolicyResponseBodyCollectionPolicyCentralizeConfig : TeaModel {
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
            public GetCollectionPolicyResponseBodyCollectionPolicyDataConfig DataConfig { get; set; }
            public class GetCollectionPolicyResponseBodyCollectionPolicyDataConfig : TeaModel {
                [NameInMap("dataProject")]
                [Validation(Required=false)]
                public string DataProject { get; set; }

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

            [NameInMap("internalPolicy")]
            [Validation(Required=false)]
            public bool? InternalPolicy { get; set; }

            [NameInMap("policyConfig")]
            [Validation(Required=false)]
            public GetCollectionPolicyResponseBodyCollectionPolicyPolicyConfig PolicyConfig { get; set; }
            public class GetCollectionPolicyResponseBodyCollectionPolicyPolicyConfig : TeaModel {
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
            public GetCollectionPolicyResponseBodyCollectionPolicyResourceDirectory ResourceDirectory { get; set; }
            public class GetCollectionPolicyResponseBodyCollectionPolicyResourceDirectory : TeaModel {
                [NameInMap("accountGroupType")]
                [Validation(Required=false)]
                public string AccountGroupType { get; set; }

                [NameInMap("members")]
                [Validation(Required=false)]
                public List<string> Members { get; set; }

            }

        }

    }

}
