// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class UnAssignPrivateIpAddressResponseBody : TeaModel {
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
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public UnAssignPrivateIpAddressResponseBodyContent Content { get; set; }
        public class UnAssignPrivateIpAddressResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>IP unique identifier</para>
            /// 
            /// <b>Example:</b>
            /// <para>sip-xxxxx</para>
            /// </summary>
            [NameInMap("IpName")]
            [Validation(Required=false)]
            public string IpName { get; set; }

            /// <summary>
            /// <para>Lingjun network interface controller ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>lni-bp164jwjpdq4lnsy83s5</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

        }

        /// <summary>
        /// <para>The error message. (If the instance is in the Exception state, the exception cause is prompted.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>You don\&quot;t have the permission to do this operation.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID of the current request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A88DFED5-24B7-5A3E-87DE-380BF06F3C90</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
