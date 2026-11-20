// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QuerySecretAPhoneNoToCustResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the denied access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Request status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The struct for querying the A number reporting status.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySecretAPhoneNoToCustResponseBodyData Data { get; set; }
        public class QuerySecretAPhoneNoToCustResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the A number group to which the number belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19</para>
            /// </summary>
            [NameInMap("ANoWhiteGroupId")]
            [Validation(Required=false)]
            public string ANoWhiteGroupId { get; set; }

            /// <summary>
            /// <para>The contact phone number of the handler or legal representative for landline reporting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>130*****8888</para>
            /// </summary>
            [NameInMap("CustPhoneNo")]
            [Validation(Required=false)]
            public string CustPhoneNo { get; set; }

            /// <summary>
            /// <para>The number type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Mobile: Mobile phone number.</para>
            /// </description></item>
            /// <item><description><para>Fixed: Landline number.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Mobile</para>
            /// </summary>
            [NameInMap("NoType")]
            [Validation(Required=false)]
            public string NoType { get; set; }

            /// <summary>
            /// <para>A number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>130*****1234</para>
            /// </summary>
            [NameInMap("PhoneNoA")]
            [Validation(Required=false)]
            public string PhoneNoA { get; set; }

            /// <summary>
            /// <para>Remarks (user\&quot;s own business notes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>***报备</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The reason for review failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;系统判断为不同人&quot;]</para>
            /// </summary>
            [NameInMap("ReportResult")]
            [Validation(Required=false)]
            public string ReportResult { get; set; }

            /// <summary>
            /// <para>The reporting result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>REVIEWING: Under review.</para>
            /// </description></item>
            /// <item><description><para>PASS: Review passed.</para>
            /// </description></item>
            /// <item><description><para>FAIL: Review failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>REVIEWING</para>
            /// </summary>
            [NameInMap("ReportStatus")]
            [Validation(Required=false)]
            public string ReportStatus { get; set; }

        }

        /// <summary>
        /// <para>Error message for a failed operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>号码组不存在</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The returned ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1D73E648-0978-18A5-B089-3BB2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Succeeded.</para>
        /// </description></item>
        /// <item><description><para>false: Failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
