// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class PhoneNumberStatusForRealResponseBody : TeaModel {
        /// <summary>
        /// <para>The request status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>OK</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>OperatorLimit</b>: The query for the phone number is restricted by the carrier.</para>
        /// </description></item>
        /// <item><description><para><b>RequestFrequencyLimit</b>: Carriers prohibit high-frequency queries for the same number within a short period. If this error code is returned, try again later.</para>
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
        /// <para>The data returned for the request.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PhoneNumberStatusForRealResponseBodyData Data { get; set; }
        public class PhoneNumberStatusForRealResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The carrier that provides service for the phone number. If the number has been ported through mobile number portability (MNP), this field returns the new carrier. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>CMCC</b>: China Mobile.</para>
            /// </description></item>
            /// <item><description><para><b>CUCC</b>: China Unicom.</para>
            /// </description></item>
            /// <item><description><para><b>CTCC</b>: China Telecom.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Queries for China Broadnet numbers are not supported.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>CMCC</para>
            /// </summary>
            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }

            /// <summary>
            /// <para>The status of the phone number. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>NORMAL</b>: The number is in service.</para>
            /// </description></item>
            /// <item><description><para><b>SHUTDOWN</b>: The service for the number is suspended.</para>
            /// </description></item>
            /// <item><description><para><b>POWER_OFF</b>: The phone is powered off.</para>
            /// </description></item>
            /// <item><description><para><b>NOT_EXIST</b>: The number is not in service.</para>
            /// </description></item>
            /// <item><description><para><b>BUSY</b>: The line is busy.</para>
            /// </description></item>
            /// <item><description><para><b>SUSPECTED_POWER_OFF</b>: The phone is suspected to be powered off.</para>
            /// </description></item>
            /// <item><description><para><b>DEFECT</b>: The number is invalid.</para>
            /// </description></item>
            /// <item><description><para><b>UNKNOWN</b>: The status is unknown.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Due to carrier system adjustments, China Telecom numbers no longer return the <c>BUSY</c>, <c>SUSPECTED_POWER_OFF</c>, and <c>POWER_OFF</c> statuses. For more information, see the <a href="https://help.aliyun.com/document_detail/2489709.html">official announcement</a>.</para>
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
        /// <para>A unique identifier for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC3BB6D2-2FDF-4321-9DCE-B38165CE4C47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
