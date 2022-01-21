// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutEventRuleTargetsRequest : TeaModel {
        [NameInMap("ContactParameters")]
        [Validation(Required=false)]
        public List<PutEventRuleTargetsRequestContactParameters> ContactParameters { get; set; }
        public class PutEventRuleTargetsRequestContactParameters : TeaModel {
            [NameInMap("ContactGroupName")]
            [Validation(Required=false)]
            public string ContactGroupName { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

        }

        [NameInMap("FcParameters")]
        [Validation(Required=false)]
        public List<PutEventRuleTargetsRequestFcParameters> FcParameters { get; set; }
        public class PutEventRuleTargetsRequestFcParameters : TeaModel {
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

        [NameInMap("MnsParameters")]
        [Validation(Required=false)]
        public List<PutEventRuleTargetsRequestMnsParameters> MnsParameters { get; set; }
        public class PutEventRuleTargetsRequestMnsParameters : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Queue")]
            [Validation(Required=false)]
            public string Queue { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        [NameInMap("OpenApiParameters")]
        [Validation(Required=false)]
        public List<PutEventRuleTargetsRequestOpenApiParameters> OpenApiParameters { get; set; }
        public class PutEventRuleTargetsRequestOpenApiParameters : TeaModel {
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("SlsParameters")]
        [Validation(Required=false)]
        public List<PutEventRuleTargetsRequestSlsParameters> SlsParameters { get; set; }
        public class PutEventRuleTargetsRequestSlsParameters : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        [NameInMap("WebhookParameters")]
        [Validation(Required=false)]
        public List<PutEventRuleTargetsRequestWebhookParameters> WebhookParameters { get; set; }
        public class PutEventRuleTargetsRequestWebhookParameters : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
