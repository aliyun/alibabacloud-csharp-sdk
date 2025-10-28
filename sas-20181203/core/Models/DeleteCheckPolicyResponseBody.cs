// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteCheckPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>List of deleted policy details.</para>
        /// </summary>
        [NameInMap("Policys")]
        [Validation(Required=false)]
        public List<DeleteCheckPolicyResponseBodyPolicys> Policys { get; set; }
        public class DeleteCheckPolicyResponseBodyPolicys : TeaModel {
            /// <summary>
            /// <para>Deleted policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000000000001</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            /// <summary>
            /// <para>The name of the custom policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testPolicyName</para>
            /// </summary>
            [NameInMap("PolicyShowName")]
            [Validation(Required=false)]
            public string PolicyShowName { get; set; }

            /// <summary>
            /// <para>Policy type for custom check rule:</para>
            /// <list type="bullet">
            /// <item><description><b>STANDARD</b>: Standard-level policy</description></item>
            /// <item><description><b>REQUIREMENT</b>: Requirement-level policy</description></item>
            /// <item><description><b>SECTION</b>: Section-level policy</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STANDARD</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8B6F758-BCD4-597A-8A2C-DA5A552C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
