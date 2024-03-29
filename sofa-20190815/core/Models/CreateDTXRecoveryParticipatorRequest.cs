// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateDTXRecoveryParticipatorRequest : TeaModel {
        [NameInMap("ActionMode")]
        [Validation(Required=false)]
        public long? ActionMode { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("Actions")]
        [Validation(Required=false)]
        public List<CreateDTXRecoveryParticipatorRequestActions> Actions { get; set; }
        public class CreateDTXRecoveryParticipatorRequestActions : TeaModel {
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

            [NameInMap("WsTr")]
            [Validation(Required=false)]
            public string WsTr { get; set; }

            [NameInMap("UniqueId")]
            [Validation(Required=false)]
            public string UniqueId { get; set; }

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
