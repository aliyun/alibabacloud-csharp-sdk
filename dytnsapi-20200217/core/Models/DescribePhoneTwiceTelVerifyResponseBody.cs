// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneTwiceTelVerifyResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OK</b>: The request is successful.</description></item>
        /// <item><description><b>PortabilityNumberNotSupported</b>: The phone number that is involved in mobile number portability is not supported.</description></item>
        /// <item><description><b>RequestNumberNotSupported</b>: You are not allowed to query phone numbers assigned by China Broadnet (that is, phone numbers start with 192) and phone numbers assigned by virtual network operators (VNOs).</description></item>
        /// <item><description><b>RequestFrequencyLimit</b>: Repeated queries for the same phone number at a high frequency within a short period of time are prohibited due to restrictions that are set by carriers. If this error code is returned, please try again later.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You are charged for phone number verifications if the value of Code is OK and the value of VerifyResult is not 0. For more information, see <a href="https://help.aliyun.com/document_detail/154751.html">Pricing</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribePhoneTwiceTelVerifyResponseBodyData Data { get; set; }
        public class DescribePhoneTwiceTelVerifyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The carrier. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CMCC</b>: China Mobile</description></item>
            /// <item><description><b>CUCC</b>: China Unicom</description></item>
            /// <item><description><b>CTCC</b>: China Telecom</description></item>
            /// </list>
            /// <remarks>
            /// <para> The returned result indicates the carrier who assigns the phone number. If the phone number involves mobile number portability, the carrier after mobile number portability is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>CMCC</para>
            /// </summary>
            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }

            /// <summary>
            /// <para>The result of the request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: It is unable to judge whether the phone number is a reassigned number.</description></item>
            /// <item><description><b>1</b>: The phone number is a reassigned number.</description></item>
            /// <item><description><b>2</b>: The phone number is not a reassigned number.</description></item>
            /// <item><description><b>3</b>: The phone number has been canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public string VerifyResult { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique request ID. It is a common parameter and can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68A40250-50CD-034C-B728-0BD135850177</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
