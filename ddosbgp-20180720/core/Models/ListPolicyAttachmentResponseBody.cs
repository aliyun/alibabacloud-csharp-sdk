// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class ListPolicyAttachmentResponseBody : TeaModel {
        /// <summary>
        /// <para>The records of attachments to the mitigation policy.</para>
        /// </summary>
        [NameInMap("AttachmentList")]
        [Validation(Required=false)]
        public List<ListPolicyAttachmentResponseBodyAttachmentList> AttachmentList { get; set; }
        public class ListPolicyAttachmentResponseBodyAttachmentList : TeaModel {
            /// <summary>
            /// <para>The IP address of the protected object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>147.139.183.***</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The UID of the member to which the IP address of the protected object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>177699790631****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <para>The ID of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1b43f44e-65e1-411a-b0c0-d6c1********</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test**</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The description of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("PolicyRemark")]
            [Validation(Required=false)]
            public string PolicyRemark { get; set; }

            /// <summary>
            /// <para>The type of the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>l3</b>: IP-specific mitigation policies.</description></item>
            /// <item><description><b>l4</b>: port-specific mitigation policies.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>l3</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// <para>The port number of the protected object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8*</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The protocol type of the protected object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tcp</b></description></item>
            /// <item><description><b>udp</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>udp</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The region to which the IP address of the protected object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4B379C2-9319-4C6B-B579-FE36831B09F4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of attachments to the mitigation policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
