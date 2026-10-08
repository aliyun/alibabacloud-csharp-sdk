// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryTransferOutInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Mailbox to which the transfer password was sent.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>Expiration time of the obtained transfer password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-04-13 19:57:56</para>
        /// </summary>
        [NameInMap("ExpirationDate")]
        [Validation(Required=false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// <para>Time when the transfer-out request was received from the domain name registry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-04-13 19:57:56</para>
        /// </summary>
        [NameInMap("PendingRequestDate")]
        [Validation(Required=false)]
        public string PendingRequestDate { get; set; }

        /// <summary>
        /// <para>Unique request access token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BBEC5A50-DFDF-482E-8343-B4EB0105E055</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Encoding of the transfer-out failure reason.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clientRejected</para>
        /// </summary>
        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// <para>Description of the transfer-out failure reason.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Transfer out rejected</para>
        /// </summary>
        [NameInMap("ResultMsg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        /// <summary>
        /// <para>Transfer-out status. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Phone authentication required;  </description></item>
        /// <item><description><b>2</b>: Mailbox authentication required;  </description></item>
        /// <item><description><b>3</b>: Transfer password already obtained;  </description></item>
        /// <item><description><b>4</b>: Transfer-out in progress (transfer request received from the domain name registry);  </description></item>
        /// <item><description><b>5</b>: Transfer-out succeeded;  </description></item>
        /// <item><description><b>8</b>: Transfer-out failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Time when the transfer password was obtained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-04-13 19:57:56</para>
        /// </summary>
        [NameInMap("TransferAuthorizationCodeSendDate")]
        [Validation(Required=false)]
        public string TransferAuthorizationCodeSendDate { get; set; }

    }

}
