// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QuerySubscriptionDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>Other status codes indicate that the request failed. For more information, see <a href="https://help.aliyun.com/document_detail/109196.html">Error codes</a>.</description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>066E6E47-04CB-4774-A976-4F73CB76D4A3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information returned after the QuerySubscriptionDetail operation was called.</para>
        /// </summary>
        [NameInMap("SecretBindDetailDTO")]
        [Validation(Required=false)]
        public QuerySubscriptionDetailResponseBodySecretBindDetailDTO SecretBindDetailDTO { get; set; }
        public class QuerySubscriptionDetailResponseBodySecretBindDetailDTO : TeaModel {
            /// <summary>
            /// <para>The ID of the ASR model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("ASRModelId")]
            [Validation(Required=false)]
            public string ASRModelId { get; set; }

            /// <summary>
            /// <para>Indicates whether automatic speech recognition (ASR) is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b>: ASR is disabled.</description></item>
            /// <item><description><b>true</b>: ASR is enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ASRStatus")]
            [Validation(Required=false)]
            public bool? ASRStatus { get; set; }

            /// <summary>
            /// <para>The status of one-way call restrictions. No value is returned for this parameter if one-way call restrictions are not set. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CONTROL_AX_DISABLE</b>: Phone number A cannot be used to call phone number X.</description></item>
            /// <item><description><b>CONTROL_BX_DISABLE</b>: Phone number B cannot be used to call phone number X.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CONTROL_BX_DISABLE</para>
            /// </summary>
            [NameInMap("CallRestrict")]
            [Validation(Required=false)]
            public string CallRestrict { get; set; }

            /// <summary>
            /// <para>The expiration time of the binding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-09-05 12:00:00</para>
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }

            /// <summary>
            /// <para>The extension in the AXG extension binding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>130</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            /// <summary>
            /// <para>The creation time of the binding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-03-05 12:00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The ID of number group G in the binding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000000130001</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <para>Indicates whether all calls made by the bound phone numbers are recorded. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b></description></item>
            /// <item><description><b>true</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedRecord")]
            [Validation(Required=false)]
            public bool? NeedRecord { get; set; }

            /// <summary>
            /// <para>Phone number A in the binding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13900001111</para>
            /// </summary>
            [NameInMap("PhoneNoA")]
            [Validation(Required=false)]
            public string PhoneNoA { get; set; }

            /// <summary>
            /// <para>Phone number B in the binding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13900002222</para>
            /// </summary>
            [NameInMap("PhoneNoB")]
            [Validation(Required=false)]
            public string PhoneNoB { get; set; }

            /// <summary>
            /// <para>The private number in the binding, that is, phone number X.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13900001234</para>
            /// </summary>
            [NameInMap("PhoneNoX")]
            [Validation(Required=false)]
            public string PhoneNoX { get; set; }

            /// <summary>
            /// <para>The binding status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The binding expired.</description></item>
            /// <item><description><b>1</b>: The binding is in effect.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// <para>The binding ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000076879****</para>
            /// </summary>
            [NameInMap("SubsId")]
            [Validation(Required=false)]
            public string SubsId { get; set; }

        }

    }

}
