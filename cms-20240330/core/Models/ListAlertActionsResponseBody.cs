// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAlertActionsResponseBody : TeaModel {
        [NameInMap("alertActions")]
        [Validation(Required=false)]
        public List<ListAlertActionsResponseBodyAlertActions> AlertActions { get; set; }
        public class ListAlertActionsResponseBodyAlertActions : TeaModel {
            [NameInMap("alertActionId")]
            [Validation(Required=false)]
            public string AlertActionId { get; set; }

            [NameInMap("alertActionName")]
            [Validation(Required=false)]
            public string AlertActionName { get; set; }

            [NameInMap("essParam")]
            [Validation(Required=false)]
            public ListAlertActionsResponseBodyAlertActionsEssParam EssParam { get; set; }
            public class ListAlertActionsResponseBodyAlertActionsEssParam : TeaModel {
                [NameInMap("essGroupId")]
                [Validation(Required=false)]
                public string EssGroupId { get; set; }

                [NameInMap("essRuleId")]
                [Validation(Required=false)]
                public string EssRuleId { get; set; }

                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            [NameInMap("fcParam")]
            [Validation(Required=false)]
            public ListAlertActionsResponseBodyAlertActionsFcParam FcParam { get; set; }
            public class ListAlertActionsResponseBodyAlertActionsFcParam : TeaModel {
                [NameInMap("function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("service")]
                [Validation(Required=false)]
                public string Service { get; set; }

            }

            [NameInMap("mnsParam")]
            [Validation(Required=false)]
            public ListAlertActionsResponseBodyAlertActionsMnsParam MnsParam { get; set; }
            public class ListAlertActionsResponseBodyAlertActionsMnsParam : TeaModel {
                [NameInMap("mnsType")]
                [Validation(Required=false)]
                public string MnsType { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            [NameInMap("pagerDutyParam")]
            [Validation(Required=false)]
            public ListAlertActionsResponseBodyAlertActionsPagerDutyParam PagerDutyParam { get; set; }
            public class ListAlertActionsResponseBodyAlertActionsPagerDutyParam : TeaModel {
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("slsParam")]
            [Validation(Required=false)]
            public ListAlertActionsResponseBodyAlertActionsSlsParam SlsParam { get; set; }
            public class ListAlertActionsResponseBodyAlertActionsSlsParam : TeaModel {
                [NameInMap("logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("webhookParam")]
            [Validation(Required=false)]
            public ListAlertActionsResponseBodyAlertActionsWebhookParam WebhookParam { get; set; }
            public class ListAlertActionsResponseBodyAlertActionsWebhookParam : TeaModel {
                [NameInMap("contentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                [NameInMap("headers")]
                [Validation(Required=false)]
                public Dictionary<string, string> Headers { get; set; }

                [NameInMap("method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
