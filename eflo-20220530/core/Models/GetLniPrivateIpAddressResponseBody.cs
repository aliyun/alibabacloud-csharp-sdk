// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class GetLniPrivateIpAddressResponseBody : TeaModel {
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
        public GetLniPrivateIpAddressResponseBodyContent Content { get; set; }
        public class GetLniPrivateIpAddressResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The instance description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the data address was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-26 20:16:36</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>MAC address of the secondary private network</para>
            /// 
            /// <b>Example:</b>
            /// <para>00-ff-84-15-ba-67</para>
            /// </summary>
            [NameInMap("IpAddressMac")]
            [Validation(Required=false)]
            public string IpAddressMac { get; set; }

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
            /// <para>The error message. (If the instance is in the Exception state, the exception cause is prompted.)</para>
            /// 
            /// <b>Example:</b>
            /// <para>You don\&quot;t have the permission of this operation, action=eflo:ListVpdRouteEntries, arn=acs:eflo:cn-wulanchabu:1263399219805497:vpd_rte/*, resourceGroup=null</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Lingjun network interface controller ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>lni-2ze4uww7n6hsfzrwq77y</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>The secondary private IP address of the Lingjun network interface controller.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.42.5.92</para>
            /// </summary>
            [NameInMap("PrivateIpAddress")]
            [Validation(Required=false)]
            public string PrivateIpAddress { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wulanchabu</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The state of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The error message. (If the instance is in the Exception state, the exception cause is prompted.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>You don\&quot;t have the permission of this operation, action=eflo:GetLniPrivateIpAddress, arn=acs:eflo:cn-wulanchabu:1382782317087063:networkinterface/00</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DBAD15D6-3F47-5B36-8A92-57C2919D13D0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
