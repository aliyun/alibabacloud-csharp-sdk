// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class QueryTagApplyRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The request status code. <b>OK</b> indicates success.</para>
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
            /// <para>The application material requirements. This parameter is returned when NeedApplyMaterial=1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>申请材料的要求是XXX</para>
            /// </summary>
            [NameInMap("ApplyMaterialDesc")]
            [Validation(Required=false)]
            public string ApplyMaterialDesc { get; set; }

            /// <summary>
            /// <para>Indicates whether to automatically approve. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: do not automatically approve.</para>
            /// </description></item>
            /// <item><description><para>1: automatically approve.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoAudit")]
            [Validation(Required=false)]
            public long? AutoAudit { get; set; }

            /// <summary>
            /// <para>The billing standard description link.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyundoc.com</para>
            /// </summary>
            [NameInMap("ChargingStandardLink")]
            [Validation(Required=false)]
            public string ChargingStandardLink { get; set; }

            /// <summary>
            /// <para>Indicates whether encrypted query is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: not supported.</para>
            /// </description></item>
            /// <item><description><para>1: supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("EncryptedQuery")]
            [Validation(Required=false)]
            public long? EncryptedQuery { get; set; }

            /// <summary>
            /// <para>Indicates whether application materials need to be provided. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: not required.</para>
            /// </description></item>
            /// <item><description><para>1: required.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NeedApplyMaterial")]
            [Validation(Required=false)]
            public long? NeedApplyMaterial { get; set; }

            /// <summary>
            /// <para>The service agreement link.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.aliyundoc.com</para>
            /// </summary>
            [NameInMap("SlaLink")]
            [Validation(Required=false)]
            public string SlaLink { get; set; }

        }

        /// <summary>
        /// <para>The description of the returned status code.</para>
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
        /// <item><description><para>true: successful.</para>
        /// </description></item>
        /// <item><description><para>false: failed.</para>
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
