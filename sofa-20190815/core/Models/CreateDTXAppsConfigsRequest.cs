// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateDTXAppsConfigsRequest : TeaModel {
        [NameInMap("ActivityMode")]
        [Validation(Required=false)]
        public long? ActivityMode { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("InitiatorJsonStr")]
        [Validation(Required=false)]
        public string InitiatorJsonStr { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ShardingRuleJsonStr")]
        [Validation(Required=false)]
        public string ShardingRuleJsonStr { get; set; }

        [NameInMap("Participators")]
        [Validation(Required=false)]
        public List<CreateDTXAppsConfigsRequestParticipators> Participators { get; set; }
        public class CreateDTXAppsConfigsRequestParticipators : TeaModel {
            [NameInMap("Used")]
            [Validation(Required=false)]
            public bool? Used { get; set; }

            [NameInMap("ActionName")]
            [Validation(Required=false)]
            public string ActionName { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("ElasticKey")]
            [Validation(Required=false)]
            public string ElasticKey { get; set; }

            [NameInMap("RollbackMethodName")]
            [Validation(Required=false)]
            public string RollbackMethodName { get; set; }

            [NameInMap("IsZoneRoute")]
            [Validation(Required=false)]
            public bool? IsZoneRoute { get; set; }

            [NameInMap("CommitMethodName")]
            [Validation(Required=false)]
            public string CommitMethodName { get; set; }

            [NameInMap("TestUrl")]
            [Validation(Required=false)]
            public string TestUrl { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("RollbackMethodParamsType")]
            [Validation(Required=false)]
            public long? RollbackMethodParamsType { get; set; }

            [NameInMap("CommitMethodParamsType")]
            [Validation(Required=false)]
            public long? CommitMethodParamsType { get; set; }

            [NameInMap("UniqueId")]
            [Validation(Required=false)]
            public string UniqueId { get; set; }

            [NameInMap("WsTr")]
            [Validation(Required=false)]
            public string WsTr { get; set; }

            [NameInMap("ElasticRouteRule")]
            [Validation(Required=false)]
            public string ElasticRouteRule { get; set; }

            [NameInMap("ClassName")]
            [Validation(Required=false)]
            public string ClassName { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

    }

}
