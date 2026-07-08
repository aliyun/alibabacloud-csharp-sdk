// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class PhoneNumberStatusForPublicResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>OK</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>OperatorLimit</b>: The query for the phone number is prohibited by the carrier.</para>
        /// </description></item>
        /// <item><description><para><b>RequestFrequencyLimit</b>: Carrier restrictions prohibit frequent queries for the same number in a short period. If this error code is returned, try again later.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For a list of other error codes, see <a href="https://next.api.aliyun.com/document/Dytnsapi/2020-02-17/errorCode">API Error Center</a>.</para>
        /// </remarks>
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
        public PhoneNumberStatusForPublicResponseBodyData Data { get; set; }
        public class PhoneNumberStatusForPublicResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The basic carrier of the number. If the number has been ported, this parameter returns the current carrier.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>CMCC</b>: China Mobile</para>
            /// </description></item>
            /// <item><description><para><b>CUCC</b>: China Unicom</para>
            /// </description></item>
            /// <item><description><para><b>CTCC</b>: China Telecom</para>
            /// </description></item>
            /// <item><description><para><b>CBN</b>: China Broadnet</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CMCC</para>
            /// </summary>
            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }

            /// <summary>
            /// <para>The status of the queried phone number. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>NORMAL</b>: The number is in service.</para>
            /// </description></item>
            /// <item><description><para><b>SHUTDOWN</b>: The service for the number is suspended.</para>
            /// </description></item>
            /// <item><description><para><b>POWER_OFF</b>: The phone is powered off.</para>
            /// </description></item>
            /// <item><description><para><b>NOT_EXIST</b>: The number is non-existent.</para>
            /// </description></item>
            /// <item><description><para><b>SUSPECTED_POWER_OFF</b>: The phone is suspected to be powered off.</para>
            /// </description></item>
            /// <item><description><para><b>BUSY</b>: The line is busy.</para>
            /// </description></item>
            /// <item><description><para><b>UNKNOWN</b>: The status is unknown.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Due to carrier system adjustments, the <c>BUSY</c>, <c>SUSPECTED_POWER_OFF</c>, and <c>POWER_OFF</c> statuses are not returned for China Telecom numbers. For more information, see the <a href="https://help.aliyun.com/document_detail/2489709.html">official announcement</a>.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC3BB6D2-<b><b>-</b></b>-9DCE-B38165CE4C47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
