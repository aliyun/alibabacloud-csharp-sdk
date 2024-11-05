// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneNumberAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OK</b>: The request is successful.</description></item>
        /// <item><description><b>InvalidParameter</b>: The specified phone number is invalid or the parameter format is invalid.</description></item>
        /// <item><description><b>PhoneNumberNotfound</b>: No attribute information can be found for the specified phone number.</description></item>
        /// <item><description><b>isp.UNKNOWN</b>: An unknown exception occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>The attribute information about the phone number.</para>
        /// </summary>
        [NameInMap("PhoneNumberAttribute")]
        [Validation(Required=false)]
        public DescribePhoneNumberAttributeResponseBodyPhoneNumberAttribute PhoneNumberAttribute { get; set; }
        public class DescribePhoneNumberAttributeResponseBodyPhoneNumberAttribute : TeaModel {
            /// <summary>
            /// <para>The basic carrier. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>China Mobile</b></description></item>
            /// <item><description><b>China Unicom</b></description></item>
            /// <item><description><b>China Telecom</b></description></item>
            /// </list>
            /// </summary>
            [NameInMap("BasicCarrier")]
            [Validation(Required=false)]
            public string BasicCarrier { get; set; }

            /// <summary>
            /// <para>The actual carrier, including the virtual network operator (VNO). If the phone number involves mobile number portability, the value of this parameter is the carrier after mobile number portability.</para>
            /// </summary>
            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }

            /// <summary>
            /// <para>The city where the phone number is registered.</para>
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <para>Indicates whether the phone number involves mobile number portability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsNumberPortability")]
            [Validation(Required=false)]
            public bool? IsNumberPortability { get; set; }

            /// <summary>
            /// <para>The number segment to which the phone number belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139</para>
            /// </summary>
            [NameInMap("NumberSegment")]
            [Validation(Required=false)]
            public long? NumberSegment { get; set; }

            /// <summary>
            /// <para>The province where the phone number is registered.</para>
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

        }

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
