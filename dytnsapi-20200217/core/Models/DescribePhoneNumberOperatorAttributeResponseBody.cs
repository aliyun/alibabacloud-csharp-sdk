// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneNumberOperatorAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial. This parameter is returned only if the request is denied because the RAM user or RAM role does not have the required permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code of the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OK</b>: The request is successful.</description></item>
        /// <item><description><b>InvalidParameter</b>: The phone number is invalid or the format of the parameter is invalid.</description></item>
        /// <item><description><b>PhoneNumberNotfound</b>: The carrier information of the phone number is not found.</description></item>
        /// <item><description><b>isp.UNKNOWN</b>: An unknown error occurred.</description></item>
        /// <item><description><b>RequestFrequencyLimit</b>: Due to carrier restrictions, you cannot frequently query the same number in a short period of time. If this error code is returned, try again later.</description></item>
        /// </list>
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
        public DescribePhoneNumberOperatorAttributeResponseBodyData Data { get; set; }
        public class DescribePhoneNumberOperatorAttributeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The basic carrier. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>China Mobile</b>.</description></item>
            /// <item><description><b>China Unicom</b>.</description></item>
            /// <item><description><b>China Telecom</b>.</description></item>
            /// <item><description><b>China Broadnet</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>中国移动</para>
            /// </summary>
            [NameInMap("BasicCarrier")]
            [Validation(Required=false)]
            public string BasicCarrier { get; set; }

            /// <summary>
            /// <para>The actual carrier (including the mobile virtual network operator). If number portability is enabled, the value indicates the carrier after number portability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>中国移动</para>
            /// </summary>
            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }

            /// <summary>
            /// <para>The city to which the phone number belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>杭州</para>
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <para>Indicates whether the number has been ported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: yes</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no</para>
            /// </description></item>
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
            /// <para>The province to which the phone number belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>浙江</para>
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

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
        /// <para>68A40250-50CD-034C-B728-0BD135850177</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
