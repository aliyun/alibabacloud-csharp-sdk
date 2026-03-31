// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ActiveConfigRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("OperateRuleResult")]
        [Validation(Required=false)]
        public ActiveConfigRulesResponseBodyOperateRuleResult OperateRuleResult { get; set; }
        public class ActiveConfigRulesResponseBodyOperateRuleResult : TeaModel {
            /// <summary>
            /// <para>The returned results.</para>
            /// </summary>
            [NameInMap("OperateRuleItemList")]
            [Validation(Required=false)]
            public List<ActiveConfigRulesResponseBodyOperateRuleResultOperateRuleItemList> OperateRuleItemList { get; set; }
            public class ActiveConfigRulesResponseBodyOperateRuleResultOperateRuleItemList : TeaModel {
                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cr-2da35180a8d1008e****</para>
                /// </summary>
                [NameInMap("ConfigRuleId")]
                [Validation(Required=false)]
                public string ConfigRuleId { get; set; }

                /// <summary>
                /// <para>The error code.</para>
                /// <list type="bullet">
                /// <item><description>If the rule is enabled, no error code is returned.</description></item>
                /// <item><description>If the rule fails to be enabled, an error code is returned. For more information about error codes, see <a href="https://next.api.aliyun.com/document/Config/2020-09-07/errorCode">Error codes</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ConfigRuleStatusNotInActive</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>Indicates whether the rule is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
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

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61C1A88F-D163-40DF-84A6-F200229F37B2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
