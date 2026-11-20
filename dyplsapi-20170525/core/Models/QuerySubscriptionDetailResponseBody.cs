// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QuerySubscriptionDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The request status code.</para>
        /// <list type="bullet">
        /// <item><description>OK indicates that the request was successful.</description></item>
        /// <item><description>For other error codes, see <a href="https://help.aliyun.com/document_detail/109196.html">Error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>066E6E47-04CB-4774-A976-4F73CB76D4A3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The data structure returned when the API call is successful.</para>
        /// </summary>
        [NameInMap("SecretBindDetailDTO")]
        [Validation(Required=false)]
        public QuerySubscriptionDetailResponseBodySecretBindDetailDTO SecretBindDetailDTO { get; set; }
        public class QuerySubscriptionDetailResponseBodySecretBindDetailDTO : TeaModel {
            /// <summary>
            /// <para>The ASR model ID. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>General-Telephone-Mandarin Chinese model ID: 7ee372834d2f4cc7ac0d0ab2d0ae1aac</para>
            /// </description></item>
            /// <item><description><para>General-Telephone-Cantonese Chinese model ID: 9b4afe3d224e4fa3bf963697113e2f77</para>
            /// </description></item>
            /// <item><description><para>General-Telephone-Regional Accent model ID: 3655a6cb94764145a1f9a38a3c3b3b4b</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>7ee372834d2f4cc7ac0d0ab2d0ae1aac</para>
            /// </summary>
            [NameInMap("ASRModelId")]
            [Validation(Required=false)]
            public string ASRModelId { get; set; }

            /// <summary>
            /// <para>The Automatic Speech Recognition (ASR) status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b>: Disabled.</description></item>
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ASRStatus")]
            [Validation(Required=false)]
            public bool? ASRStatus { get; set; }

            /// <summary>
            /// <para>The one-way call restriction status. This parameter is not returned if no one-way call restriction is configured. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CONTROL_AX_DISABLE</b>: Phone number A cannot call phone number X.</description></item>
            /// <item><description><b>CONTROL_BX_DISABLE</b>: Phone number B cannot call phone number X.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CONTROL_BX_DISABLE</para>
            /// </summary>
            [NameInMap("CallRestrict")]
            [Validation(Required=false)]
            public string CallRestrict { get; set; }

            /// <summary>
            /// <para>The expiration time of the binding relationship, in the format of YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-09-05 12:00:00</para>
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }

            /// <summary>
            /// <para>The extension number in the AXG extension binding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>130</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            /// <summary>
            /// <para>The time when the binding relationship was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-03-05 12:00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The ID of the number group G (GID) in the binding relationship.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200001234****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <para>Indicates whether all calls generated by this binding relationship are recorded. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b>: Calls are not recorded.</description></item>
            /// <item><description><b>true</b>: Calls are recorded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedRecord")]
            [Validation(Required=false)]
            public bool? NeedRecord { get; set; }

            /// <summary>
            /// <para>The phone number A in the binding relationship.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139****0000</para>
            /// </summary>
            [NameInMap("PhoneNoA")]
            [Validation(Required=false)]
            public string PhoneNoA { get; set; }

            /// <summary>
            /// <para>The phone number B in the binding relationship.</para>
            /// 
            /// <b>Example:</b>
            /// <para>138****0000</para>
            /// </summary>
            [NameInMap("PhoneNoB")]
            [Validation(Required=false)]
            public string PhoneNoB { get; set; }

            /// <summary>
            /// <para>The private number in the binding relationship, which is the X number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139****1111</para>
            /// </summary>
            [NameInMap("PhoneNoX")]
            [Validation(Required=false)]
            public string PhoneNoX { get; set; }

            /// <summary>
            /// <para>The status of the binding relationship. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Expired.</description></item>
            /// <item><description><b>1</b>: Active.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// <para>The binding relationship ID.</para>
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
