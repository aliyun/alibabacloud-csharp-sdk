// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class ThreeElementsVerificationResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description><b>OK</b>: The request is successful.</description></item>
        /// <item><description>For more information, see Error codes in this documentation.</description></item>
        /// <item><description><b>RequestFrequencyLimit</b>: Repeated queries for the same phone number at a high frequency within a short period of time are prohibited due to restrictions that are set by carriers. If this error code is returned, please try again later.</description></item>
        /// </list>
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
        public ThreeElementsVerificationResponseBodyData Data { get; set; }
        public class ThreeElementsVerificationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The basic carrier. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>China Mobile</b></description></item>
            /// <item><description><b>China Unicom</b></description></item>
            /// <item><description><b>China Telecom</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>China Mobile</para>
            /// </summary>
            [NameInMap("BasicCarrier")]
            [Validation(Required=false)]
            public string BasicCarrier { get; set; }

            /// <summary>
            /// <para>Indicates whether the specified name, phone number, and ID card number belong to the same user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: The specified name, phone number, and ID card number belong to the same user.</description></item>
            /// <item><description><b>0</b>: The specified name, phone number, and ID card number do not belong to the same user.</description></item>
            /// <item><description><b>2</b>: The specified name, phone number, and ID card number cannot be found.</description></item>
            /// </list>
            /// <para><b>Note</b> The phone number registration data of a user is usually updated one or three days after registration. The registration data can be queried only after the update. The following table shows the verification results under different phone number states.</para>
            /// <table>
            /// <thead>
            /// <tr>
            /// <th>Carrier/Phone number state</th>
            /// <th>Out-of-service</th>
            /// <th>Nonexistent</th>
            /// <th>Canceled</th>
            /// </tr>
            /// </thead>
            /// <tbody><tr>
            /// <td>China Mobile</td>
            /// <td>Verifications can be carried out normally.</td>
            /// <td>The specified name, phone number, and ID card number cannot be found.</td>
            /// <td>The specified name, phone number, and ID card number cannot be found.</td>
            /// </tr>
            /// <tr>
            /// <td>China Unicom</td>
            /// <td>Verifications can be carried out normally.</td>
            /// <td>The specified name, phone number, and ID card number do not belong to the same user.</td>
            /// <td>The specified name, phone number, and ID card number do not belong to the same user.</td>
            /// </tr>
            /// <tr>
            /// <td>China Telecom</td>
            /// <td>Verifications can be carried out normally.</td>
            /// <td>The specified name, phone number, and ID card number cannot be found.</td>
            /// <td>The specified name, phone number, and ID card number cannot be found.</td>
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
        /// <para>The returned message.</para>
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
