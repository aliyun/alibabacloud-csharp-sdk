// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryTransferInByInstanceIdResponseBody : TeaModel {
        /// <summary>
        /// <para>Domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Mailbox to which the domain name transfer-in confirmation email was sent.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The expiration time of the domain name transfer-in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-03-28 00:41:42</para>
        /// </summary>
        [NameInMap("ExpirationDate")]
        [Validation(Required=false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp indicating when the transfer-in expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1514428524669</para>
        /// </summary>
        [NameInMap("ExpirationDateLong")]
        [Validation(Required=false)]
        public long? ExpirationDateLong { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S20181T0WLI85212</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The update time of the transfer-in information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-03-28 00:41:42</para>
        /// </summary>
        [NameInMap("ModificationDate")]
        [Validation(Required=false)]
        public string ModificationDate { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp indicating when the transfer-in information was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1514428524669</para>
        /// </summary>
        [NameInMap("ModificationDateLong")]
        [Validation(Required=false)]
        public long? ModificationDateLong { get; set; }

        /// <summary>
        /// <para>Indicates whether email verification is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedMailCheck")]
        [Validation(Required=false)]
        public bool? NeedMailCheck { get; set; }

        /// <summary>
        /// <para>Progress bar chart type for the transfer procedure. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Both email verification and naming review are required;  </description></item>
        /// <item><description><b>1</b>: Email verification is required, but naming review is not;  </description></item>
        /// <item><description><b>2</b>: Naming review is required, but email verification is not;  </description></item>
        /// <item><description><b>3</b>: Neither email verification nor naming review is required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ProgressBarType")]
        [Validation(Required=false)]
        public int? ProgressBarType { get; set; }

        /// <summary>
        /// <para>Unique request access token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AF7D4DCE-0776-47F2-A9B2-6FB85A87AA60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The error code indicating the reason for transfer failure. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>clientCancelled</b>: You canceled the domain transfer-in.</description></item>
        /// <item><description><b>clientRejected</b>: The original registrar rejected the domain transfer-in (or you performed a rejection operation through the original registrar).</description></item>
        /// <item><description><b>serverCancelled</b>: The domain name registry canceled the transfer.</description></item>
        /// <item><description><b>transferProhibited</b>: The domain is in a transfer-prohibited status.</description></item>
        /// <item><description><b>transferExpired</b>: You did not complete the required transfer confirmation within the validity period.</description></item>
        /// <item><description><b>nameVerificationFailed</b>: The domain naming review did not pass.</description></item>
        /// <item><description><b>transferSubmitted</b>: Another user has already submitted a transfer request for this domain.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>clientCancelled</para>
        /// </summary>
        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// <para>The time when the transfer succeeded or failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-03-28 00:41:42</para>
        /// </summary>
        [NameInMap("ResultDate")]
        [Validation(Required=false)]
        public string ResultDate { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp indicating when the transfer succeeded or failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1514428524669</para>
        /// </summary>
        [NameInMap("ResultDateLong")]
        [Validation(Required=false)]
        public long? ResultDateLong { get; set; }

        /// <summary>
        /// <para>Description of the failure reason when the transfer failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>您取消了此次域名转入</para>
        /// </summary>
        [NameInMap("ResultMsg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        /// <summary>
        /// <para>Transfer status. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>INIT</b>: Transfer-in submitted;  </description></item>
        /// <item><description><b>AUTHORIZATION</b>: Authorization for transfer-in (email verification);  </description></item>
        /// <item><description><b>NAME_VERIFICATION</b>: Naming review;  </description></item>
        /// <item><description><b>PASSWORD_VERIFICATION</b>: Transfer password verification;  </description></item>
        /// <item><description><b>PENDING</b>: Transfer-in in progress;  </description></item>
        /// <item><description><b>SUCCESS</b>: Transfer-in succeeded;  </description></item>
        /// <item><description><b>FAIL</b>: Transfer-in failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("SimpleTransferInStatus")]
        [Validation(Required=false)]
        public string SimpleTransferInStatus { get; set; }

        /// <summary>
        /// <para>Detailed domain name transfer-in status. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>10</b>: Initial status;  </description></item>
        /// <item><description><b>11</b>: Email verification token link has been sent;  </description></item>
        /// <item><description><b>19</b>: Token link has been successfully verified;  </description></item>
        /// <item><description><b>20</b>: Naming review has been submitted;  </description></item>
        /// <item><description><b>21</b>: Naming review failed;  </description></item>
        /// <item><description><b>29</b>: Naming review succeeded;  </description></item>
        /// <item><description><b>31</b>: Transfer password is incorrect;  </description></item>
        /// <item><description><b>39</b>: Transfer-in submission succeeded;  </description></item>
        /// <item><description><b>50</b>: Customer canceled the transfer-in;  </description></item>
        /// <item><description><b>51</b>: Transfer-in failed;  </description></item>
        /// <item><description><b>52</b>: Transfer-in expired;  </description></item>
        /// <item><description><b>59</b>: Transfer-in succeeded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Transfer request submission time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-03-28 00:41:42</para>
        /// </summary>
        [NameInMap("SubmissionDate")]
        [Validation(Required=false)]
        public string SubmissionDate { get; set; }

        /// <summary>
        /// <para>UNIX timestamp of the transfer request submission time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1514428524669</para>
        /// </summary>
        [NameInMap("SubmissionDateLong")]
        [Validation(Required=false)]
        public long? SubmissionDateLong { get; set; }

        /// <summary>
        /// <para>Time when the transfer password was successfully submitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-03-28 00:41:42</para>
        /// </summary>
        [NameInMap("TransferAuthorizationCodeSubmissionDate")]
        [Validation(Required=false)]
        public string TransferAuthorizationCodeSubmissionDate { get; set; }

        /// <summary>
        /// <para>UNIX timestamp of the time when the transfer password was successfully submitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1514428524669</para>
        /// </summary>
        [NameInMap("TransferAuthorizationCodeSubmissionDateLong")]
        [Validation(Required=false)]
        public long? TransferAuthorizationCodeSubmissionDateLong { get; set; }

        /// <summary>
        /// <para>User ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>Indicates whether the registrant\&quot;s mailbox was scraped from WHOIS. When the domain transfer-in is in the authorization (email verification) phase and this field is <b>false</b>, it means the registrant\&quot;s mailbox was not obtained via WHOIS scraping, and manual processing is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WhoisMailStatus")]
        [Validation(Required=false)]
        public bool? WhoisMailStatus { get; set; }

    }

}
