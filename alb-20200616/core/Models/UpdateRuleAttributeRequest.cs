// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateRuleAttributeRequest : TeaModel {
        /// <summary>
        /// 转发规则标识
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// 幂等标识
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        ///  是否只预检此次请求
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// 转发规则条件
        /// </summary>
        [NameInMap("RuleConditions")]
        [Validation(Required=false)]
        public List<UpdateRuleAttributeRequestRuleConditions> RuleConditions { get; set; }
        public class UpdateRuleAttributeRequestRuleConditions : TeaModel {
            /// <summary>
            /// Cookie条件配置
            /// </summary>
            [NameInMap("CookieConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleConditionsCookieConfig CookieConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsCookieConfig : TeaModel {
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<UpdateRuleAttributeRequestRuleConditionsCookieConfigValues> Values { get; set; }
                public class UpdateRuleAttributeRequestRuleConditionsCookieConfigValues : TeaModel {
                    public string Key { get; set; }
                    public string Value { get; set; }
                }
            };

            /// <summary>
            /// HTTP标头条件配置
            /// </summary>
            [NameInMap("HeaderConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleConditionsHeaderConfig HeaderConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsHeaderConfig : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }
            };

            /// <summary>
            /// 主机名条件配置
            /// </summary>
            [NameInMap("HostConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleConditionsHostConfig HostConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsHostConfig : TeaModel {
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }
            };

            /// <summary>
            /// HTTP请求方法条件配置
            /// </summary>
            [NameInMap("MethodConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleConditionsMethodConfig MethodConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsMethodConfig : TeaModel {
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }
            };

            /// <summary>
            /// 路径条件配置
            /// </summary>
            [NameInMap("PathConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleConditionsPathConfig PathConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsPathConfig : TeaModel {
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }
            };

            /// <summary>
            /// 查询字符串条件配置
            /// </summary>
            [NameInMap("QueryStringConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleConditionsQueryStringConfig QueryStringConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsQueryStringConfig : TeaModel {
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<UpdateRuleAttributeRequestRuleConditionsQueryStringConfigValues> Values { get; set; }
                public class UpdateRuleAttributeRequestRuleConditionsQueryStringConfigValues : TeaModel {
                    public string Key { get; set; }
                    public string Value { get; set; }
                }
            };

            /// <summary>
            /// 条件类型
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// 转发规则动作
        /// </summary>
        [NameInMap("RuleActions")]
        [Validation(Required=false)]
        public List<UpdateRuleAttributeRequestRuleActions> RuleActions { get; set; }
        public class UpdateRuleAttributeRequestRuleActions : TeaModel {
            /// <summary>
            /// 返回固定内容动作配置
            /// </summary>
            [NameInMap("FixedResponseConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsFixedResponseConfig : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }
                [NameInMap("HttpCode")]
                [Validation(Required=false)]
                public string HttpCode { get; set; }
            };

            /// <summary>
            /// 转发组动作配置
            /// </summary>
            [NameInMap("ForwardGroupConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsForwardGroupConfig : TeaModel {
                [NameInMap("ServerGroupTuples")]
                [Validation(Required=false)]
                public List<UpdateRuleAttributeRequestRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                public class UpdateRuleAttributeRequestRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                    public string ServerGroupId { get; set; }
                }
            };

            /// <summary>
            /// 插入头部动作配置
            /// </summary>
            [NameInMap("InsertHeaderConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsInsertHeaderConfig : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }
                [NameInMap("ValueType")]
                [Validation(Required=false)]
                public string ValueType { get; set; }
            };

            /// <summary>
            /// 优先级
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            /// <summary>
            /// 重定向动作配置
            /// </summary>
            [NameInMap("RedirectConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsRedirectConfig RedirectConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsRedirectConfig : TeaModel {
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }
                [NameInMap("HttpCode")]
                [Validation(Required=false)]
                public string HttpCode { get; set; }
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }
                [NameInMap("Query")]
                [Validation(Required=false)]
                public string Query { get; set; }
            };

            /// <summary>
            /// 内部重定向动作配置
            /// </summary>
            [NameInMap("RewriteConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsRewriteConfig RewriteConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsRewriteConfig : TeaModel {
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }
                [NameInMap("Query")]
                [Validation(Required=false)]
                public string Query { get; set; }
            };

            /// <summary>
            /// 转发规则动作类型
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// 转发规则名称
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// 转发规则优先级
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

    }

}
