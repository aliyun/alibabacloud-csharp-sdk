// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserByMobileAccountResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>46e53***********270</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryUserByMobileAccountResponseBodyResult Result { get; set; }
        public class QueryUserByMobileAccountResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("BoundUserId")]
            [Validation(Required=false)]
            public string BoundUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ThirdAccountName")]
            [Validation(Required=false)]
            public string ThirdAccountName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
