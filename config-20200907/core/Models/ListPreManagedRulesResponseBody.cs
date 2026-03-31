// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListPreManagedRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The evaluation rules.</para>
        /// </summary>
        [NameInMap("ManagedRules")]
        [Validation(Required=false)]
        public List<ListPreManagedRulesResponseBodyManagedRules> ManagedRules { get; set; }
        public class ListPreManagedRulesResponseBodyManagedRules : TeaModel {
            /// <summary>
            /// <para>The details of the required input parameters of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("CompulsoryInputParameterDetails")]
            [Validation(Required=false)]
            public Dictionary<string, object> CompulsoryInputParameterDetails { get; set; }

            /// <summary>
            /// <para>The name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ram-user-ak-used-expired-check</para>
            /// </summary>
            [NameInMap("ConfigRuleName")]
            [Validation(Required=false)]
            public string ConfigRuleName { get; set; }

            /// <summary>
            /// <para>The description of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Example description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The URL of the topic that describes how the evaluation rule remediates the incompliant configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.aliyundoc.com">https://example.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("HelpUrls")]
            [Validation(Required=false)]
            public string HelpUrls { get; set; }

            /// <summary>
            /// <para>The identifier of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs-instance-deletion-protection-enabled</para>
            /// </summary>
            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// <para>The details of the optional input parameters of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("OptionalInputParameterDetails")]
            [Validation(Required=false)]
            public Dictionary<string, object> OptionalInputParameterDetails { get; set; }

            /// <summary>
            /// <para>The type of resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::ECS::Instance</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A2A9F1BE-0712-1B26-9899-D82F7DA8476C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
