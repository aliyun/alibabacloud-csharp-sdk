// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteCheckPolicyResponseBody : TeaModel {
        [NameInMap("Policys")]
        [Validation(Required=false)]
        public List<DeleteCheckPolicyResponseBodyPolicys> Policys { get; set; }
        public class DeleteCheckPolicyResponseBodyPolicys : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1000000000001</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testPolicyName</para>
            /// </summary>
            [NameInMap("PolicyShowName")]
            [Validation(Required=false)]
            public string PolicyShowName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>STANDARD</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F8B6F758-BCD4-597A-8A2C-DA5A552C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
