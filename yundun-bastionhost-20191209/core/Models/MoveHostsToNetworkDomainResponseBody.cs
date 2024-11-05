// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class MoveHostsToNetworkDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F9B9E190-9C8E-5FEE-B963-7E9F1FD7FB4E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the call.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<MoveHostsToNetworkDomainResponseBodyResults> Results { get; set; }
        public class MoveHostsToNetworkDomainResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The return code that indicates whether the host is added to the network domain.</para>
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
            /// <para>The host ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// <para>The error message that is returned.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

    }

}
