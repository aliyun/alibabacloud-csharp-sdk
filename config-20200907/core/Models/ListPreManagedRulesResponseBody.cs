// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListPreManagedRulesResponseBody : TeaModel {
        /// <summary>
        /// The evaluation rules.
        /// </summary>
        [NameInMap("ManagedRules")]
        [Validation(Required=false)]
        public List<ListPreManagedRulesResponseBodyManagedRules> ManagedRules { get; set; }
        public class ListPreManagedRulesResponseBodyManagedRules : TeaModel {
            /// <summary>
            /// The details of the required input parameters of the rule.
            /// </summary>
            [NameInMap("CompulsoryInputParameterDetails")]
            [Validation(Required=false)]
            public Dictionary<string, object> CompulsoryInputParameterDetails { get; set; }

            /// <summary>
            /// The name of the rule.
            /// </summary>
            [NameInMap("ConfigRuleName")]
            [Validation(Required=false)]
            public string ConfigRuleName { get; set; }

            /// <summary>
            /// The description of the rule.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The URL of the topic that describes how the evaluation rule remediates the incompliant configurations.
            /// </summary>
            [NameInMap("HelpUrls")]
            [Validation(Required=false)]
            public string HelpUrls { get; set; }

            /// <summary>
            /// The identifier of the rule.
            /// </summary>
            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// The details of the optional input parameters of the rule.
            /// </summary>
            [NameInMap("OptionalInputParameterDetails")]
            [Validation(Required=false)]
            public Dictionary<string, object> OptionalInputParameterDetails { get; set; }

            /// <summary>
            /// The type of resource.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
