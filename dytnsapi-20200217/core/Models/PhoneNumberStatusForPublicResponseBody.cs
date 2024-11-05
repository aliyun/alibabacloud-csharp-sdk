// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class PhoneNumberStatusForPublicResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OK</b>: The request is successful.</description></item>
        /// <item><description><b>OperatorLimit</b>: The carrier prohibits the query of the phone number.</description></item>
        /// <item><description><b>RequestFrequencyLimit</b>: Repeated queries for the same phone number at a high frequency within a short period of time are prohibited due to restrictions that are set by carriers. If this error code is returned, please try again later.</description></item>
        /// </list>
        /// <remarks>
        /// <para> For a list of error codes, see <a href="https://next.api.aliyun.com/document/Dytnsapi/2020-02-17/errorCode">Service error codes</a>.</para>
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
        public PhoneNumberStatusForPublicResponseBodyData Data { get; set; }
        public class PhoneNumberStatusForPublicResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The basic carrier who assigns the phone number. If the queried phone number involves mobile number portability, the carrier after mobile number portability is returned.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CMCC</b>: China Mobile</description></item>
            /// <item><description><b>CUCC</b>: China Unicom</description></item>
            /// <item><description><b>CTCC</b>: China Telecom</description></item>
            /// </list>
            /// <remarks>
            /// <para> You are not allowed to query the phone numbers assigned by China Broadnet.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>CMCC</para>
            /// </summary>
            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }

            /// <summary>
            /// <para>The returned status for the queried phone number. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NORMAL</b>: The queried phone number can be reached.</description></item>
            /// <item><description><b>SHUTDOWN</b>: The queried phone number is suspended.</description></item>
            /// <item><description><b>POWER_OFF</b>: The phone is powered off.</description></item>
            /// <item><description><b>NOT_EXIST</b>: The queried phone number is a nonexistent number.</description></item>
            /// <item><description><b>SUSPECTED_POWER_OFF</b>: The phone is suspected to be powered off.</description></item>
            /// <item><description><b>BUSY</b>: The queried phone number is busy.</description></item>
            /// <item><description><b>UNKNOWN</b>: The queried phone number is unknown.</description></item>
            /// </list>
            /// <remarks>
            /// <para> Due to system adjustment of the carrier, the BUSY and POWER_OFF states cannot be returned for the numbers assigned by China Telecom. <a href="https://help.aliyun.com/document_detail/2489709.html">For more information, see the official announcements</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
        /// <para>The unique request ID. It is a common parameter and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC3BB6D2-<b><b>-</b></b>-9DCE-B38165CE4C47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
