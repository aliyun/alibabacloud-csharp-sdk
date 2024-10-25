// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class GetBucketLifecycleResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A2583E8B-B930-4F59-ADC0-0E209A90C46E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The detailed information about the rule.</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public List<GetBucketLifecycleResponseBodyRule> Rule { get; set; }
        public class GetBucketLifecycleResponseBodyRule : TeaModel {
            /// <summary>
            /// <para>The expiration time.</para>
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public GetBucketLifecycleResponseBodyRuleExpiration Expiration { get; set; }
            public class GetBucketLifecycleResponseBodyRuleExpiration : TeaModel {
                /// <summary>
                /// <para>The expiration date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yyy-MM-DDThh:mm:ssZ</para>
                /// </summary>
                [NameInMap("CreatedBeforeDate")]
                [Validation(Required=false)]
                public string CreatedBeforeDate { get; set; }

                /// <summary>
                /// <para>The validity period, in days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Days")]
                [Validation(Required=false)]
                public string Days { get; set; }

            }

            /// <summary>
            /// <para>The unique ID of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ID")]
            [Validation(Required=false)]
            public string ID { get; set; }

            /// <summary>
            /// <para>The prefix that is applied to the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>image</para>
            /// </summary>
            [NameInMap("Prefix")]
            [Validation(Required=false)]
            public string Prefix { get; set; }

            /// <summary>
            /// <para>The status of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: The rule is periodically executed.</description></item>
            /// <item><description><b>Disabled</b>: The rule is ignored.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
