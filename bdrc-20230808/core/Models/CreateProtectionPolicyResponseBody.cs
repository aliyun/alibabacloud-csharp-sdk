// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class CreateProtectionPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateProtectionPolicyResponseBodyData Data { get; set; }
        public class CreateProtectionPolicyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the protection policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p-123***7890</para>
            /// </summary>
            [NameInMap("ProtectionPolicyId")]
            [Validation(Required=false)]
            public string ProtectionPolicyId { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34081B20-C4C0-514F-93F6-8EEC3D1A587E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
