// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class PhoneNumberStatusForSmsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>OK</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>OperatorLimit</b>: The carrier restricts queries for this phone number.</para>
        /// </description></item>
        /// <item><description><para><b>RequestFrequencyLimit</b>: Indicates that requests for a single number are too frequent. Due to carrier restrictions, repeated queries for the same number within a short period are prohibited. If you receive this error code, try again later.</para>
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
        /// <para>A container for the returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PhoneNumberStatusForSmsResponseBodyData Data { get; set; }
        public class PhoneNumberStatusForSmsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The carrier of the phone number. If the number has been ported, this parameter returns the current carrier. Valid values:</para>
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
            /// <item><description><para><b>NORMAL</b>: Active.</para>
            /// </description></item>
            /// <item><description><para><b>SHUTDOWN</b>: Shutdown.</para>
            /// </description></item>
            /// <item><description><para><b>POWER_OFF</b>: Powered off.</para>
            /// </description></item>
            /// <item><description><para><b>NOT_EXIST</b>: Non-existent number.</para>
            /// </description></item>
            /// <item><description><para><b>DEFECT</b>: Invalid number.</para>
            /// </description></item>
            /// <item><description><para><b>UNKNOWN</b>: Unknown.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Due to carrier system adjustments, the statuses for busy, suspected to be powered off, and powered off are not returned for China Telecom numbers. For more information, see the <a href="https://help.aliyun.com/document_detail/2489709.html">official announcement</a>.</para>
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
        /// <para>The unique ID of the request. Use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68A40250-50CD-034C-B728-0BD135850177</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
