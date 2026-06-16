// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class BankMetaVerifyIntlResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of 200 indicates success. Other values indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>4EB35****87EBA1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result information.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public BankMetaVerifyIntlResponseBodyResultObject ResultObject { get; set; }
        public class BankMetaVerifyIntlResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The verification result code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Verification consistent (billable).</description></item>
            /// <item><description>2: Verification inconsistent (billable).</description></item>
            /// <item><description>3: No record found (not billable).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>The verification details. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>101</b>: Verification passed.</description></item>
            /// <item><description><b>201</b>: Authentication information inconsistent. The cardholder information is incorrect.</description></item>
            /// <item><description><b>202</b>: Authentication information inconsistent. The bank card has not enabled authenticated payment.</description></item>
            /// <item><description><b>203</b>: Authentication information inconsistent. The bank card has expired.</description></item>
            /// <item><description><b>204</b>: Authentication information inconsistent. The bank card is restricted.</description></item>
            /// <item><description><b>205</b>: Authentication information inconsistent. The card has been confiscated.</description></item>
            /// <item><description><b>206</b>: Authentication information inconsistent. The bank card is invalid.</description></item>
            /// <item><description><b>207</b>: Authentication information inconsistent. No issuing bank found for this card.</description></item>
            /// <item><description><b>208</b>: Authentication information inconsistent. The card is not initialized or is a dormant card.</description></item>
            /// <item><description><b>209</b>: Authentication information inconsistent. The card is a fraudulent or retained card.</description></item>
            /// <item><description><b>210</b>: Authentication information inconsistent. The card has been reported lost.</description></item>
            /// <item><description><b>211</b>: Authentication information inconsistent. The number of incorrect password attempts has exceeded the limit.</description></item>
            /// <item><description><b>212</b>: Authentication information inconsistent. The issuing bank does not support this transaction.</description></item>
            /// <item><description><b>213</b>: Authentication information inconsistent. The card status is abnormal or the card is invalid.</description></item>
            /// <item><description><b>214</b>: Authentication information inconsistent. No phone number is registered with the card.</description></item>
            /// <item><description><b>215</b>: Authentication information inconsistent. The password, expiration date, or CVN2 is incorrect.</description></item>
            /// <item><description><b>216</b>: Authentication information inconsistent. Other card exceptions.</description></item>
            /// <item><description><b>301</b>: Verification unavailable. The bank card does not support this service.</description></item>
            /// <item><description><b>302</b>: Verification unavailable. Verification failed or the bank rejected the verification. Contact the issuing bank.</description></item>
            /// <item><description><b>303</b>: Verification unavailable. The bank card does not currently support phone number verification.</description></item>
            /// <item><description><b>304</b>: Verification unavailable. The bank card number is incorrect.</description></item>
            /// <item><description><b>305</b>: Verification unavailable. Other reasons.</description></item>
            /// <item><description><b>306</b>: Verification unavailable. The number of verification attempts has exceeded the limit.</description></item>
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
