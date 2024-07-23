// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopsPolicyGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The modification results.</para>
        /// </summary>
        [NameInMap("ModifyResults")]
        [Validation(Required=false)]
        public List<ModifyDesktopsPolicyGroupResponseBodyModifyResults> ModifyResults { get; set; }
        public class ModifyDesktopsPolicyGroupResponseBodyModifyResults : TeaModel {
            /// <summary>
            /// <para>The result of the modification. A value of success indicates that the policy is modified. If the policy failed to be modified, an error message is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The ID of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-7w78ozhjcwa3u****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The error message returned if the request failed. This parameter is not returned if the value of Code is success.``</para>
            /// 
            /// <b>Example:</b>
            /// <para>The specified param DesktopId ecd-ia2zw38bi6cm7**** is not found.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
