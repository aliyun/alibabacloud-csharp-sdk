// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class AssignPrivateIpAddressResponseBody : TeaModel {
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
        public AssignPrivateIpAddressResponseBodyContent Content { get; set; }
        public class AssignPrivateIpAddressResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The unique IP identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sip-8exxqa2r</para>
            /// </summary>
            [NameInMap("IpName")]
            [Validation(Required=false)]
            public string IpName { get; set; }

            /// <summary>
            /// <para>Lingjun network interface controller ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lni-bp18exxqa2rvfn45e5pz</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

        }

        /// <summary>
        /// <para>The error message. (If the instance is in the Exception state, the exception cause is prompted.)</para>
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
        /// <para>AC8C713A-A9F4-5984-A5E1-76496DF35153</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
