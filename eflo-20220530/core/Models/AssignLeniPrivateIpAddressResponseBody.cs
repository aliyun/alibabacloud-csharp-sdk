// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class AssignLeniPrivateIpAddressResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public AssignLeniPrivateIpAddressResponseBodyContent Content { get; set; }
        public class AssignLeniPrivateIpAddressResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>Lingjun Elastic Network Interface ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>leni-1234****</para>
            /// </summary>
            [NameInMap("ElasticNetworkInterfaceId")]
            [Validation(Required=false)]
            public string ElasticNetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>Lingjun Elastic Network Interface secondary private IP unique identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sip-lzwx****</para>
            /// </summary>
            [NameInMap("IpName")]
            [Validation(Required=false)]
            public string IpName { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A88DFED5-24B7-5A3E-87DE-380BF06F3C90</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
