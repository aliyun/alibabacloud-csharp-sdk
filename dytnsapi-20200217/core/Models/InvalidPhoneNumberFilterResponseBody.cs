// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class InvalidPhoneNumberFilterResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>OK</b>: The request is successful.</para>
        /// </description></item>
        /// <item><description><para><b>MobileNumberIllegal</b>: The mobile number is invalid.</para>
        /// </description></item>
        /// <item><description><para><b>EncyrptTypeIllegal</b>: The encryption type is invalid.</para>
        /// </description></item>
        /// <item><description><para><b>MobileNumberTypeNotMatch</b>: The mobile number does not match the encryption type.</para>
        /// </description></item>
        /// <item><description><para><b>CarrierIllegal</b>: The carrier type is invalid.</para>
        /// </description></item>
        /// <item><description><para><b>AuthCodeNotExist</b>: The authorization code does not exist.</para>
        /// </description></item>
        /// <item><description><para><b>PortabilityNumberNotSupported</b>: Mobile number portability is not supported.</para>
        /// </description></item>
        /// <item><description><para><b>Unknown</b>: An unknown exception occurred.</para>
        /// </description></item>
        /// <item><description><para><b>AuthCodeAndApiNotMatch</b>: A system exception occurred.</para>
        /// </description></item>
        /// <item><description><para><b>AuthCodeAndApiNotMatch</b>: The AuthCode does not match the API operation.</para>
        /// </description></item>
        /// <item><description><para><b>RequestFrequencyLimit</b>: Due to carrier restrictions, repeated high-frequency queries against the same phone number within a short period of time are prohibited. If this error code is returned, try again later.</para>
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
        /// <para>The array of returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<InvalidPhoneNumberFilterResponseBodyData> Data { get; set; }
        public class InvalidPhoneNumberFilterResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The filtering result.</para>
            /// <list type="bullet">
            /// <item><description><para><b>YES</b>: A valid phone number. The mapping relationship is returned.</para>
            /// </description></item>
            /// <item><description><para><b>NO</b>: An invalid phone number. The mapping relationship is not returned.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>YES</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The encrypted phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1400513****</para>
            /// </summary>
            [NameInMap("EncryptedNumber")]
            [Validation(Required=false)]
            public string EncryptedNumber { get; set; }

            /// <summary>
            /// <para>The expiration time of the phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-27 16:05:23</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The original phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1390000****</para>
            /// </summary>
            [NameInMap("OriginalNumber")]
            [Validation(Required=false)]
            public string OriginalNumber { get; set; }

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
