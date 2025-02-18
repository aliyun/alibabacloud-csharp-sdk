// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetRoleAclOnObjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetRoleAclOnObjectResponseBodyData Data { get; set; }
        public class GetRoleAclOnObjectResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The operations that were performed on the object.</para>
            /// </summary>
            [NameInMap("actions")]
            [Validation(Required=false)]
            public List<string> Actions { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1366d16686529650188023ef87f</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
