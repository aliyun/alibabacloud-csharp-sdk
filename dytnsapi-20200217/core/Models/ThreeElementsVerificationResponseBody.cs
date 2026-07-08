// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class ThreeElementsVerificationResponseBody : TeaModel {
        /// <summary>
        /// <para>The request status code.</para>
        /// <list type="bullet">
        /// <item><description><b>OK</b>: The request was successful.</description></item>
        /// <item><description>For other error codes, see the error code table in this chapter.</description></item>
        /// <item><description><b>RequestFrequencyLimit</b>: Due to carrier restrictions, repeated high-frequency queries on the same number within a short period are prohibited. If this error code is returned, try again later.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ThreeElementsVerificationResponseBodyData Data { get; set; }
        public class ThreeElementsVerificationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The basic carrier. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>China Mobile</b>.</para>
            /// </description></item>
            /// <item><description><para><b>China Unicom</b>.</para>
            /// </description></item>
            /// <item><description><para><b>China Telecom</b>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>中国移动</para>
            /// </summary>
            [NameInMap("BasicCarrier")]
            [Validation(Required=false)]
            public string BasicCarrier { get; set; }

            /// <summary>
            /// <para>Indicates whether the verification results are consistent. Returned values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Consistent</description></item>
            /// <item><description><b>0</b>: Inconsistent</description></item>
            /// <item><description><b>2</b>: Not found<remarks>
            /// <para>The data update timeliness varies by carrier and city, and is typically between T+1 and T+3.
            /// The verification results for mobile phone numbers of different carriers in different states are as follows:</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// <table>
            /// <thead>
            /// <tr>
            /// <th>Carrier/Mobile Phone Number Status</th>
            /// <th>Suspended</th>
            /// <th>Empty Number</th>
            /// <th>Deregistered</th>
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
        /// <para>CC3BB6D2-2FDF-4321-9DCE-B38165CE4C47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
