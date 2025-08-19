// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class BankMetaVerifyIntlResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code: 200 for success, others for failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return message</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EB35****87EBA1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result information</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public BankMetaVerifyIntlResponseBodyResultObject ResultObject { get; set; }
        public class BankMetaVerifyIntlResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Verification result code.</para>
            /// <list type="bullet">
            /// <item><description>1: Consistent (charged)</description></item>
            /// <item><description>2: Inconsistent (charged)</description></item>
            /// <item><description>3: No record found (not charged)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>Verification details:</para>
            /// <list type="bullet">
            /// <item><description><b>101</b>: Verification passed.</description></item>
            /// <item><description><b>201</b>: Authentication information does not match, cardholder information is incorrect.</description></item>
            /// <item><description><b>202</b>: Authentication information does not match, bank card has not been activated for authenticated payments.</description></item>
            /// <item><description><b>203</b>: Authentication information does not match, bank card has expired.</description></item>
            /// <item><description><b>204</b>: Authentication information does not match, bank card is a restricted card.</description></item>
            /// <item><description><b>205</b>: Authentication information does not match, this card has been confiscated.</description></item>
            /// <item><description><b>206</b>: Authentication information does not match, bank card is invalid.</description></item>
            /// <item><description><b>207</b>: Authentication information does not match, this card has no corresponding issuing bank.</description></item>
            /// <item><description><b>208</b>: Authentication information does not match, this card is uninitialized or dormant.</description></item>
            /// <item><description><b>209</b>: Authentication information does not match, this card is a cheating card or swallowed card.</description></item>
            /// <item><description><b>210</b>: Authentication information does not match, this card has been reported lost.</description></item>
            /// <item><description><b>211</b>: Authentication information does not match, password error limit exceeded.</description></item>
            /// <item><description><b>212</b>: Authentication information does not match, issuing bank does not support this transaction.</description></item>
            /// <item><description><b>213</b>: Authentication information does not match, card status is abnormal or card is invalid.</description></item>
            /// <item><description><b>214</b>: Authentication information does not match, no phone number reserved.</description></item>
            /// <item><description><b>215</b>: Authentication information does not match, entered password, expiration date, or CVN2 is incorrect.</description></item>
            /// <item><description><b>216</b>: Authentication information does not match, other card anomalies.</description></item>
            /// <item><description><b>301</b>: Unable to verify, bank card does not support this service.</description></item>
            /// <item><description><b>302</b>: Unable to verify, verification failed or bank refused verification, please contact the issuing bank.</description></item>
            /// <item><description><b>303</b>: Unable to verify, bank card does not currently support phone number verification.</description></item>
            /// <item><description><b>304</b>: Unable to verify, bank card number is incorrect.</description></item>
            /// <item><description><b>305</b>: Unable to verify, other reasons.</description></item>
            /// <item><description><b>306</b>: Unable to verify, verification attempt limit exceeded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

        }

    }

}
