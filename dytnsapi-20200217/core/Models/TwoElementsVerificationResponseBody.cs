// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class TwoElementsVerificationResponseBody : TeaModel {
        /// <summary>
        /// <para>The request status code.</para>
        /// <list type="bullet">
        /// <item><description><para><b>OK</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see the error code table in this chapter.</para>
        /// </description></item>
        /// <item><description><para><b>RequestFrequencyLimit</b>: Due to operator restrictions, repeated high-frequency queries against the same number or name in a short period are prohibited. If this error code is returned, try again later.</para>
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
        /// <para>The structure.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TwoElementsVerificationResponseBodyData Data { get; set; }
        public class TwoElementsVerificationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The basic operator. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>China Mobile</b>.</para>
            /// </description></item>
            /// <item><description><para><b>China Unicom</b>.</para>
            /// </description></item>
            /// <item><description><para><b>China Telecom</b>.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: China Broadcasting Network numbers are not currently supported.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>中国移动</para>
            /// </summary>
            [NameInMap("BasicCarrier")]
            [Validation(Required=false)]
            public string BasicCarrier { get; set; }

            /// <summary>
            /// <para>Indicates whether the verification result is consistent. Returns:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Consistent.</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: Inconsistent.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Not found.</para>
            /// </description></item>
            /// </list>
            /// <para>The data update timeliness for different operators and cities is typically T+1 to T+3.
            /// The verification results for different operator phone numbers in different states are as follows: </para>
            /// <table>
            /// <thead>
            /// <tr>
            /// <th>Operator/Phone Number Status</th>
            /// <th>Suspended</th>
            /// <th>Empty Number</th>
            /// <th>Cancelled</th>
            /// </tr>
            /// </thead>
            /// <tbody><tr>
            /// <td>China Mobile</td>
            /// <td>Normal verification</td>
            /// <td>Not found</td>
            /// <td>Not found</td>
            /// </tr>
            /// <tr>
            /// <td>China Unicom</td>
            /// <td>Normal verification</td>
            /// <td>Inconsistent</td>
            /// <td>Inconsistent</td>
            /// </tr>
            /// <tr>
            /// <td>China Telecom</td>
            /// <td>Normal verification</td>
            /// <td>Not found</td>
            /// <td>Not found</td>
            /// </tr>
            /// </tbody></table>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsConsistent")]
            [Validation(Required=false)]
            public int? IsConsistent { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC3BB6D2-2FDF-4321-9DCE-B38165CE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
