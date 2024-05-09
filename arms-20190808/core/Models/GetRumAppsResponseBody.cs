// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRumAppsResponseBody : TeaModel {
        [NameInMap("AppList")]
        [Validation(Required=false)]
        public List<GetRumAppsResponseBodyAppList> AppList { get; set; }
        public class GetRumAppsResponseBodyAppList : TeaModel {
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public object CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("IsSubscription")]
            [Validation(Required=false)]
            public bool? IsSubscription { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            [NameInMap("PackageName")]
            [Validation(Required=false)]
            public string PackageName { get; set; }

            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ServiceDomainConfigs")]
            [Validation(Required=false)]
            public List<GetRumAppsResponseBodyAppListServiceDomainConfigs> ServiceDomainConfigs { get; set; }
            public class GetRumAppsResponseBodyAppListServiceDomainConfigs : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("PropagatorTypes")]
                [Validation(Required=false)]
                public List<string> PropagatorTypes { get; set; }

                [NameInMap("Tracing")]
                [Validation(Required=false)]
                public string Tracing { get; set; }

            }

            [NameInMap("SlsLogstore")]
            [Validation(Required=false)]
            public string SlsLogstore { get; set; }

            [NameInMap("SlsProject")]
            [Validation(Required=false)]
            public string SlsProject { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetRumAppsResponseBodyAppListTags> Tags { get; set; }
            public class GetRumAppsResponseBodyAppListTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
