// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class BankMetaVerifyIntlResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates success, and other values indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
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
        /// <para>The returned result information.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public BankMetaVerifyIntlResponseBodyResultObject ResultObject { get; set; }
        public class BankMetaVerifyIntlResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The verification result code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: The verification is consistent. You are billed for this call.</description></item>
            /// <item><description>2: The verification is inconsistent. You are billed for this call.</description></item>
            /// <item><description>3: No record is found. You are not billed for this call.</description></item>
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
            /// <item><description><b>101</b>: The verification is successful.</description></item>
            /// <item><description><b>201</b>: The authentication information is inconsistent. The cardholder information is incorrect.</description></item>
            /// <item><description><b>202</b>: The authentication information is inconsistent. The bank card is not enabled for authenticated payment.</description></item>
            /// <item><description><b>203</b>: The authentication information is inconsistent. The bank card has expired.</description></item>
            /// <item><description><b>204</b>: The authentication information is inconsistent. The bank card is restricted.</description></item>
            /// <item><description><b>205</b>: The authentication information is inconsistent. The bank card has been confiscated.</description></item>
            /// <item><description><b>206</b>: The authentication information is inconsistent. The bank card is invalid.</description></item>
            /// <item><description><b>207</b>: The authentication information is inconsistent. The bank card has no corresponding issuing bank.</description></item>
            /// <item><description><b>208</b>: The authentication information is inconsistent. The bank card is not initialized or is a dormant card.</description></item>
            /// <item><description><b>209</b>: The authentication information is inconsistent. The bank card is a fraudulent or captured card.</description></item>
            /// <item><description><b>210</b>: The authentication information is inconsistent. The bank card has been reported as lost.</description></item>
            /// <item><description><b>211</b>: The authentication information is inconsistent. The number of incorrect password attempts has exceeded the limit.</description></item>
            /// <item><description><b>212</b>: The authentication information is inconsistent. The issuing bank does not support this transaction.</description></item>
            /// <item><description><b>213</b>: The authentication information is inconsistent. The card status is abnormal or the card is invalid.</description></item>
            /// <item><description><b>214</b>: The authentication information is inconsistent. No mobile phone number is reserved.</description></item>
            /// <item><description><b>215</b>: The authentication information is inconsistent. The entered password, expiration date, or CVN2 is incorrect.</description></item>
            /// <item><description><b>216</b>: The authentication information is inconsistent. Other card exceptions occurred.</description></item>
            /// <item><description><b>301</b>: The verification cannot be performed. The bank card does not support this service.</description></item>
            /// <item><description><b>302</b>: The verification cannot be performed. The verification failed or the bank rejected the verification. Contact the issuing bank.</description></item>
            /// <item><description><b>303</b>: The verification cannot be performed. The bank card does not support mobile phone number verification.</description></item>
            /// <item><description><b>304</b>: The verification cannot be performed. The bank card number is incorrect.</description></item>
            /// <item><description><b>305</b>: The verification cannot be performed. Other reasons.</description></item>
            /// <item><description><b>306</b>: The verification cannot be performed. The number of verification attempts has exceeded the limit.</description></item>
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
