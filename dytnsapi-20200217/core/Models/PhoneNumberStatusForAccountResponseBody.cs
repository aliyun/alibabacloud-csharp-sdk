// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class PhoneNumberStatusForAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>OK</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>OperatorLimit</b>: The query is prohibited by the carrier.</para>
        /// </description></item>
        /// <item><description><para><b>RequestFrequencyLimit</b>: Carriers restrict frequent queries for the same number within a short period. If you receive this error code, try again later.</para>
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
        /// <para>The response object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PhoneNumberStatusForAccountResponseBodyData Data { get; set; }
        public class PhoneNumberStatusForAccountResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number\&quot;s current carrier. If the number has been ported to a new carrier through mobile number portability, the new carrier is returned. Valid values:</para>
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
            /// <para>CMCC</para>
            /// </summary>
            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }

            /// <summary>
            /// <para>The status of the phone number. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>NORMAL</b>: The number is active.</para>
            /// </description></item>
            /// <item><description><para><b>SHUTDOWN</b>: The number is suspended or temporarily out of service.</para>
            /// </description></item>
            /// <item><description><para><b>POWER_OFF</b>: The phone is powered off.</para>
            /// </description></item>
            /// <item><description><para><b>NOT_EXIST</b>: The number is non-existent.</para>
            /// </description></item>
            /// <item><description><para><b>DEFECT</b>: The number is invalid.</para>
            /// </description></item>
            /// <item><description><para><b>UNKNOWN</b>: The status is unknown.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Due to adjustments in the carrier\&quot;s system, China Telecom numbers do not return the <c>busy</c> and <c>powered off</c> statuses. For more information, <a href="https://help.aliyun.com/document_detail/2489709.html">see the official announcement</a>.</para>
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
        /// <para>The ID of the request. This ID is unique to each request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC3BB6D2-2FDF-4321-9DCE-B38165CE4C47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
