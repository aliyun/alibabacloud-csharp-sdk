// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetApplicationGrantScopeResponseBody : TeaModel {
        /// <summary>
        /// <para>The permissions of the Developer API feature.</para>
        /// </summary>
        [NameInMap("ApplicationGrantScope")]
        [Validation(Required=false)]
        public GetApplicationGrantScopeResponseBodyApplicationGrantScope ApplicationGrantScope { get; set; }
        public class GetApplicationGrantScopeResponseBodyApplicationGrantScope : TeaModel {
            /// <summary>
            /// <para>The permissions of the Developer API feature.</para>
            /// </summary>
            [NameInMap("GrantScopes")]
            [Validation(Required=false)]
            public List<string> GrantScopes { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
