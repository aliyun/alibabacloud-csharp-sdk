// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteConfigRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The results of the delete operations.</para>
        /// </summary>
        [NameInMap("OperateRuleResult")]
        [Validation(Required=false)]
        public DeleteConfigRulesResponseBodyOperateRuleResult OperateRuleResult { get; set; }
        public class DeleteConfigRulesResponseBodyOperateRuleResult : TeaModel {
            /// <summary>
            /// <para>The result of the delete operation.</para>
            /// </summary>
            [NameInMap("OperateRuleItemList")]
            [Validation(Required=false)]
            public List<DeleteConfigRulesResponseBodyOperateRuleResultOperateRuleItemList> OperateRuleItemList { get; set; }
            public class DeleteConfigRulesResponseBodyOperateRuleResultOperateRuleItemList : TeaModel {
                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cr-9908626622af0035****</para>
                /// </summary>
                [NameInMap("ConfigRuleId")]
                [Validation(Required=false)]
                public string ConfigRuleId { get; set; }

                /// <summary>
                /// <para>The error code.</para>
                /// <list type="bullet">
                /// <item><description>If the rule is disabled, no error code is returned.</description></item>
                /// <item><description>If the rule fails to be disabled, an error code is returned. For more information about error codes, see <a href="https://api.alibabacloud.com/document/Config/2020-09-07/errorCode">Error codes</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ConfigRuleCanNotDelete</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>Indicates whether the request was successful. Valid values:</para>
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

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6721BBD3-F2A6-5349-9051-EE0111036D3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
