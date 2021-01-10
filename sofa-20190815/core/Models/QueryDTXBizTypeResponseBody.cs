// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryDTXBizTypeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("Participators")]
        [Validation(Required=false)]
        public List<QueryDTXBizTypeResponseBodyParticipators> Participators { get; set; }
        public class QueryDTXBizTypeResponseBodyParticipators : TeaModel {
            [NameInMap("ActionName")]
            [Validation(Required=false)]
            public string ActionName { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("ClassName")]
            [Validation(Required=false)]
            public string ClassName { get; set; }

            [NameInMap("CommitMethodName")]
            [Validation(Required=false)]
            public string CommitMethodName { get; set; }

            [NameInMap("CommitMethodParamsType")]
            [Validation(Required=false)]
            public long? CommitMethodParamsType { get; set; }

            [NameInMap("ElasticKey")]
            [Validation(Required=false)]
            public string ElasticKey { get; set; }

            [NameInMap("ElasticRouteRule")]
            [Validation(Required=false)]
            public string ElasticRouteRule { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("IsZoneRoute")]
            [Validation(Required=false)]
            public bool? IsZoneRoute { get; set; }

            [NameInMap("RollbackMethodName")]
            [Validation(Required=false)]
            public string RollbackMethodName { get; set; }

            [NameInMap("RollbackMethodParamsType")]
            [Validation(Required=false)]
            public long? RollbackMethodParamsType { get; set; }

            [NameInMap("TestUrl")]
            [Validation(Required=false)]
            public string TestUrl { get; set; }

            [NameInMap("UniqueId")]
            [Validation(Required=false)]
            public string UniqueId { get; set; }

            [NameInMap("Used")]
            [Validation(Required=false)]
            public bool? Used { get; set; }

            [NameInMap("WsTr")]
            [Validation(Required=false)]
            public string WsTr { get; set; }

        }

        [NameInMap("AsynInfo")]
        [Validation(Required=false)]
        public QueryDTXBizTypeResponseBodyAsynInfo AsynInfo { get; set; }
        public class QueryDTXBizTypeResponseBodyAsynInfo : TeaModel {
            [NameInMap("ActionMode")]
            [Validation(Required=false)]
            public long? ActionMode { get; set; }
            [NameInMap("ActivityMode")]
            [Validation(Required=false)]
            public long? ActivityMode { get; set; }
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("Role")]
            [Validation(Required=false)]
            public long? Role { get; set; }
            [NameInMap("SplitRule")]
            [Validation(Required=false)]
            public QueryDTXBizTypeResponseBodyAsynInfoSplitRule SplitRule { get; set; }
            public class QueryDTXBizTypeResponseBodyAsynInfoSplitRule : TeaModel {
                [NameInMap("DbSplitRule")]
                [Validation(Required=false)]
                public long? DbSplitRule { get; set; }

                [NameInMap("DbSplitTemplate")]
                [Validation(Required=false)]
                public string DbSplitTemplate { get; set; }

                [NameInMap("TableSplitRule")]
                [Validation(Required=false)]
                public long? TableSplitRule { get; set; }

                [NameInMap("TableSplitTemplate")]
                [Validation(Required=false)]
                public string TableSplitTemplate { get; set; }

            }
        };

        [NameInMap("Initiator")]
        [Validation(Required=false)]
        public QueryDTXBizTypeResponseBodyInitiator Initiator { get; set; }
        public class QueryDTXBizTypeResponseBodyInitiator : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("IsAsyn")]
            [Validation(Required=false)]
            public bool? IsAsyn { get; set; }
            [NameInMap("IsLoadTest")]
            [Validation(Required=false)]
            public bool? IsLoadTest { get; set; }
            [NameInMap("IsMix")]
            [Validation(Required=false)]
            public bool? IsMix { get; set; }
            [NameInMap("RecoveryLimit")]
            [Validation(Required=false)]
            public long? RecoveryLimit { get; set; }
            [NameInMap("RecoveryThreadNum")]
            [Validation(Required=false)]
            public long? RecoveryThreadNum { get; set; }
            [NameInMap("RecoveryDatasources")]
            [Validation(Required=false)]
            public List<QueryDTXBizTypeResponseBodyInitiatorRecoveryDatasources> RecoveryDatasources { get; set; }
            public class QueryDTXBizTypeResponseBodyInitiatorRecoveryDatasources : TeaModel {
                public long? ActionTableIndexEnd { get; set; }
                public long? ActionTableIndexStart { get; set; }
                public string ActionTableNameFormat { get; set; }
                public long? ActivityTableIndexEnd { get; set; }
                public long? ActivityTableIndexStart { get; set; }
                public string ActivityTableNameFormat { get; set; }
                public long? DbConnectMin { get; set; }
                public long? DbConnMax { get; set; }
                public long? DbType { get; set; }
                public long? DsIndexEnd { get; set; }
                public long? DsIndexStart { get; set; }
                public string DsNameFormat { get; set; }
                public long? Id { get; set; }
                public string InstanceId { get; set; }
                public bool? IsLdc { get; set; }
                public bool? IsLocalDs { get; set; }
                public string Zone { get; set; }
            }
        };

    }

}
