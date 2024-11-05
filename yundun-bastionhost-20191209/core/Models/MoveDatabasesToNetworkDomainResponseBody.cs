// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class MoveDatabasesToNetworkDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E5B1BC32-72B2-5BFD-BF75-5D38261264D1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The results of the call.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<MoveDatabasesToNetworkDomainResponseBodyResults> Results { get; set; }
        public class MoveDatabasesToNetworkDomainResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>Indicates whether the database is added to the network domain.</para>
            /// <remarks>
            /// <para>The code LICENSE_OUT_OF_LIMIT indicates that the network domain feature is not supported by the current Bastionhost edition.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The database ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>45</para>
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

            /// <summary>
            /// <para>The error message that is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>N/A</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

    }

}
