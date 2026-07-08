// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class PhoneNumberStatusForVoiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>OK</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>OperatorLimit</b>: The carrier restricts queries for this phone number.</para>
        /// </description></item>
        /// <item><description><para><b>RequestFrequencyLimit</b>: Carrier restrictions limit how frequently you can query the same number. If you receive this error, try again later.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PhoneNumberStatusForVoiceResponseBodyData Data { get; set; }
        public class PhoneNumberStatusForVoiceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current carrier for the number. If the number has been ported, this field returns the new carrier. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>CMCC</b>: China Mobile</para>
            /// </description></item>
            /// <item><description><para><b>CUCC</b>: China Unicom</para>
            /// </description></item>
            /// <item><description><para><b>CTCC</b>: China Telecom</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Queries for China Broadnet numbers are not supported.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>CTCC</para>
            /// </summary>
            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }

            /// <summary>
            /// <para>The status of the phone number. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>NORMAL</b>: The number is active.</para>
            /// </description></item>
            /// <item><description><para><b>SHUTDOWN</b>: The service for the number is suspended.</para>
            /// </description></item>
            /// <item><description><para><b>POWER_OFF</b>: The phone is powered off.</para>
            /// </description></item>
            /// <item><description><para><b>NOT_EXIST</b>: The number does not exist.</para>
            /// </description></item>
            /// <item><description><para><b>SUSPECTED_POWER_OFF</b>: The phone is likely powered off.</para>
            /// </description></item>
            /// <item><description><para><b>DEFECT</b>: The number is invalid.</para>
            /// </description></item>
            /// <item><description><para><b>UNKNOWN</b>: The status is unknown.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Due to carrier system adjustments, the <c>SUSPECTED_POWER_OFF</c> and <c>POWER_OFF</c> statuses are not returned for China Telecom numbers. <a href="https://help.aliyun.com/document_detail/2489709.html">For more information, see the official announcement.</a></para>
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
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. This is a common parameter. Each request has a unique ID that you can use to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC3BB6D2-2FDF-4321-9DCE-B38165CE4C47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
