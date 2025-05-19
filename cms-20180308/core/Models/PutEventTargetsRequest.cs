// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class PutEventTargetsRequest : TeaModel {
        [NameInMap("ContactParameters")]
        [Validation(Required=false)]
        public List<PutEventTargetsRequestContactParameters> ContactParameters { get; set; }
        public class PutEventTargetsRequestContactParameters : TeaModel {
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
        public List<PutEventTargetsRequestFcParameters> FcParameters { get; set; }
        public class PutEventTargetsRequestFcParameters : TeaModel {
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
        public List<PutEventTargetsRequestMnsParameters> MnsParameters { get; set; }
        public class PutEventTargetsRequestMnsParameters : TeaModel {
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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("SlsParameters")]
        [Validation(Required=false)]
        public List<PutEventTargetsRequestSlsParameters> SlsParameters { get; set; }
        public class PutEventTargetsRequestSlsParameters : TeaModel {
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
        public List<PutEventTargetsRequestWebhookParameters> WebhookParameters { get; set; }
        public class PutEventTargetsRequestWebhookParameters : TeaModel {
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
