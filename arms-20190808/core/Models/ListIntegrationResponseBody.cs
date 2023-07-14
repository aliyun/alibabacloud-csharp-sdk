// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListIntegrationResponseBody : TeaModel {
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListIntegrationResponseBodyPageInfo PageInfo { get; set; }
        public class ListIntegrationResponseBodyPageInfo : TeaModel {
            [NameInMap("Integrations")]
            [Validation(Required=false)]
            public List<ListIntegrationResponseBodyPageInfoIntegrations> Integrations { get; set; }
            public class ListIntegrationResponseBodyPageInfoIntegrations : TeaModel {
                [NameInMap("ApiEndpoint")]
                [Validation(Required=false)]
                public string ApiEndpoint { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("IntegrationDetail")]
                [Validation(Required=false)]
                public ListIntegrationResponseBodyPageInfoIntegrationsIntegrationDetail IntegrationDetail { get; set; }
                public class ListIntegrationResponseBodyPageInfoIntegrationsIntegrationDetail : TeaModel {
                    [NameInMap("AutoRecover")]
                    [Validation(Required=false)]
                    public bool? AutoRecover { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("DuplicateKey")]
                    [Validation(Required=false)]
                    public string DuplicateKey { get; set; }

                    [NameInMap("ExtendedFieldRedefineRules")]
                    [Validation(Required=false)]
                    public List<Dictionary<string, object>> ExtendedFieldRedefineRules { get; set; }

                    [NameInMap("FieldRedefineRules")]
                    [Validation(Required=false)]
                    public List<Dictionary<string, object>> FieldRedefineRules { get; set; }

                    [NameInMap("InitiativeRecoverField")]
                    [Validation(Required=false)]
                    public string InitiativeRecoverField { get; set; }

                    [NameInMap("InitiativeRecoverValue")]
                    [Validation(Required=false)]
                    public string InitiativeRecoverValue { get; set; }

                    [NameInMap("RecoverTime")]
                    [Validation(Required=false)]
                    public long? RecoverTime { get; set; }

                    [NameInMap("Stat")]
                    [Validation(Required=false)]
                    public List<long?> Stat { get; set; }

                }

                [NameInMap("IntegrationId")]
                [Validation(Required=false)]
                public long? IntegrationId { get; set; }

                [NameInMap("IntegrationName")]
                [Validation(Required=false)]
                public string IntegrationName { get; set; }

                [NameInMap("IntegrationProductType")]
                [Validation(Required=false)]
                public string IntegrationProductType { get; set; }

                [NameInMap("Liveness")]
                [Validation(Required=false)]
                public string Liveness { get; set; }

                [NameInMap("ShortToken")]
                [Validation(Required=false)]
                public string ShortToken { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public bool? State { get; set; }

            }

            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
