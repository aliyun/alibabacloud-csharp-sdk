// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyResourceCenterPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The modification results.</para>
        /// </summary>
        [NameInMap("ModifyResults")]
        [Validation(Required=false)]
        public List<ModifyResourceCenterPolicyResponseBodyModifyResults> ModifyResults { get; set; }
        public class ModifyResourceCenterPolicyResponseBodyModifyResults : TeaModel {
            /// <summary>
            /// <para>The verification result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CheckResult")]
            [Validation(Required=false)]
            public bool? CheckResult { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-e254cpyt9bb*****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51592A88-0F2C-55E6-AD2C-2AD9C10D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
