// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetRuleCategoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success. Other values indicate failure. Use this field to determine the cause of a failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRuleCategoryResponseBodyData Data { get; set; }
        public class GetRuleCategoryResponseBodyData : TeaModel {
            [NameInMap("RuleCountInfo")]
            [Validation(Required=false)]
            public List<GetRuleCategoryResponseBodyDataRuleCountInfo> RuleCountInfo { get; set; }
            public class GetRuleCategoryResponseBodyDataRuleCountInfo : TeaModel {
                [NameInMap("Select")]
                [Validation(Required=false)]
                public bool? Select { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                [NameInMap("TypeName")]
                [Validation(Required=false)]
                public string TypeName { get; set; }

            }

        }

        /// <summary>
        /// <para>If an error occurs, this field provides error details. If the call is successful, the value is \<c>successful\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F190ADE9-619A-447D-84E3-7E241A5C428E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. A value of \<c>true\\</c> indicates success. A value of \<c>false\\</c> or \<c>null\\</c> indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
