// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class InvalidPhoneNumberFilterResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OK</b>: The request is successful.</description></item>
        /// <item><description><b>MobileNumberIllegal</b>: The phone number is invalid.</description></item>
        /// <item><description><b>EncyrptTypeIllegal</b>: The encryption type is invalid.</description></item>
        /// <item><description><b>MobileNumberTypeNotMatch</b>: The phone number does not match the encryption type.</description></item>
        /// <item><description><b>CarrierIllegal</b>: The carrier type is invalid.</description></item>
        /// <item><description><b>AuthCodeNotExist</b>: The authorization code does not exist.</description></item>
        /// <item><description><b>PortabilityNumberNotSupported</b>: Mobile number portability is not supported.</description></item>
        /// <item><description><b>Unknown</b>: An unknown exception occurred.</description></item>
        /// <item><description><b>AuthCodeAndApiNotMatch</b>: A system exception occurred.</description></item>
        /// <item><description><b>AuthCodeAndApiNotMatch</b>: The authorization code does not match the API operation.</description></item>
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
        /// <para>Details about the returned entries.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<InvalidPhoneNumberFilterResponseBodyData> Data { get; set; }
        public class InvalidPhoneNumberFilterResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The returned filter results.</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b>: the valid phone number. The mappings are returned.</description></item>
            /// <item><description><b>NO</b>: the invalid phone number. No mappings are returned.</description></item>
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
            /// <para>The time when the phone number expires.</para>
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
