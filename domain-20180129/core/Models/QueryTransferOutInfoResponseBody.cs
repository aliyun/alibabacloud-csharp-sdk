// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryTransferOutInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2018-04-13 19:57:56</para>
        /// </summary>
        [NameInMap("ExpirationDate")]
        [Validation(Required=false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2018-04-13 19:57:56</para>
        /// </summary>
        [NameInMap("PendingRequestDate")]
        [Validation(Required=false)]
        public string PendingRequestDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BBEC5A50-DFDF-482E-8343-B4EB0105E055</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>clientRejected</para>
        /// </summary>
        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Transfer out rejected</para>
        /// </summary>
        [NameInMap("ResultMsg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2018-04-13 19:57:56</para>
        /// </summary>
        [NameInMap("TransferAuthorizationCodeSendDate")]
        [Validation(Required=false)]
        public string TransferAuthorizationCodeSendDate { get; set; }

    }

}
