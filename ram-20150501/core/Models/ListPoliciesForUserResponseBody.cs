// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListPoliciesForUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the policy.</para>
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public ListPoliciesForUserResponseBodyPolicies Policies { get; set; }
        public class ListPoliciesForUserResponseBodyPolicies : TeaModel {
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public List<ListPoliciesForUserResponseBodyPoliciesPolicy> Policy { get; set; }
            public class ListPoliciesForUserResponseBodyPoliciesPolicy : TeaModel {
                /// <summary>
                /// <para>The time at which the policy is attached to the RAM user. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-01-23T12:33:18Z</para>
                /// </summary>
                [NameInMap("AttachDate")]
                [Validation(Required=false)]
                public string AttachDate { get; set; }

                /// <summary>
                /// <para>The current version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("DefaultVersion")]
                [Validation(Required=false)]
                public string DefaultVersion { get; set; }

                /// <summary>
                /// <para>The description of the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OSS administrator</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OSS-Administrator</para>
                /// </summary>
                [NameInMap("PolicyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

                /// <summary>
                /// <para>The type of the policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>System: system policy</description></item>
                /// <item><description>Custom: custom policy</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Custom</para>
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B8A4E7D-6CFF-471D-84DF-195A7A241ECB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
