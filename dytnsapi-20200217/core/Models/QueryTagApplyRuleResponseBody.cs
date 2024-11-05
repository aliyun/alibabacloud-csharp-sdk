// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class QueryTagApplyRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. <b>OK</b> indicates that the request is successful.</para>
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
        public QueryTagApplyRuleResponseBodyData Data { get; set; }
        public class QueryTagApplyRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The requirements for application materials.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Requirements for application materials</para>
            /// </summary>
            [NameInMap("ApplyMaterialDesc")]
            [Validation(Required=false)]
            public string ApplyMaterialDesc { get; set; }

            /// <summary>
            /// <para>Indicates whether the application is automatically approved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("AutoAudit")]
            [Validation(Required=false)]
            public long? AutoAudit { get; set; }

            /// <summary>
            /// <para>The URL for the billing documentation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyundoc.com</para>
            /// </summary>
            [NameInMap("ChargingStandardLink")]
            [Validation(Required=false)]
            public string ChargingStandardLink { get; set; }

            /// <summary>
            /// <para>indicates whether encrypted queries are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("EncryptedQuery")]
            [Validation(Required=false)]
            public long? EncryptedQuery { get; set; }

            /// <summary>
            /// <para>Indicates whether application materials are required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>46</para>
            /// </summary>
            [NameInMap("NeedApplyMaterial")]
            [Validation(Required=false)]
            public long? NeedApplyMaterial { get; set; }

            /// <summary>
            /// <para>The URL for the service agreement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.aliyundoc.com</para>
            /// </summary>
            [NameInMap("SlaLink")]
            [Validation(Required=false)]
            public string SlaLink { get; set; }

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
        /// <para>CC3BB6D2-<b><b>-</b></b>-9DCE-B38165CE4C47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
