// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class BatchcreateDTXAppsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchcreateDTXAppsResponseBodyData Data { get; set; }
        public class BatchcreateDTXAppsResponseBodyData : TeaModel {
            [NameInMap("ActionArray")]
            [Validation(Required=false)]
            public List<BatchcreateDTXAppsResponseBodyDataActionArray> ActionArray { get; set; }
            public class BatchcreateDTXAppsResponseBodyDataActionArray : TeaModel {
                public string ActionName { get; set; }
                public bool? Used { get; set; }
                public string InstanceId { get; set; }
                public string RollbackMethodName { get; set; }
                public string ElasticKey { get; set; }
                public bool? IsZoneRoute { get; set; }
                public string CommitMethodName { get; set; }
                public string TestUrl { get; set; }
                public string AppName { get; set; }
                public long? RollbackMethodParamsType { get; set; }
                public long? CommitMethodParamsType { get; set; }
                public string WsTr { get; set; }
                public string UniqueId { get; set; }
                public string ElasticRouteRule { get; set; }
                public string ClassName { get; set; }
                public long? Id { get; set; }
            }
            [NameInMap("RecoveryArray")]
            [Validation(Required=false)]
            public List<BatchcreateDTXAppsResponseBodyDataRecoveryArray> RecoveryArray { get; set; }
            public class BatchcreateDTXAppsResponseBodyDataRecoveryArray : TeaModel {
                public string AppName { get; set; }
                public bool? IsAsyn { get; set; }
                public bool? IsDds { get; set; }
                public bool? IsLoadTest { get; set; }
                public List<BatchcreateDTXAppsResponseBodyDataRecoveryArrayDsArray> DsArray { get; set; }
                public class BatchcreateDTXAppsResponseBodyDataRecoveryArrayDsArray : TeaModel {
                    public string TaskNameFormat { get; set; }
                    public long? DsIndexEnd { get; set; }
                    public bool? IsLdc { get; set; }
                    public string ActionTableNameFormat { get; set; }
                    public long? TaskIndexStart { get; set; }
                    public bool? IsLocalDs { get; set; }
                    public long? ActionTableIndexEnd { get; set; }
                    public long? TaskIndexEnd { get; set; }
                    public long? DbConnectMin { get; set; }
                    public long? DbType { get; set; }
                    public long? DbConnMax { get; set; }
                    public long? DsIndexStart { get; set; }
                    public string DsNameFormat { get; set; }
                    public long? ActivityTableIndexEnd { get; set; }
                    public long? ActionTableIndexStart { get; set; }
                    public string Zone { get; set; }
                    public string ActivityTableNameFormat { get; set; }
                    public long? Id { get; set; }
                    public long? ActivityTableIndexStart { get; set; }
                }
                public bool? IsMix { get; set; }
                public bool? Used { get; set; }
                public long? RecoveryThreadNum { get; set; }
                public long? RecoveryLimit { get; set; }
                public long? Id { get; set; }
                public string ClientVersion { get; set; }
            }
            [NameInMap("DbRuleTemplate")]
            [Validation(Required=false)]
            public string DbRuleTemplate { get; set; }
            [NameInMap("ActionCount")]
            [Validation(Required=false)]
            public long? ActionCount { get; set; }
            [NameInMap("Used")]
            [Validation(Required=false)]
            public bool? Used { get; set; }
            [NameInMap("SpliteMode")]
            [Validation(Required=false)]
            public long? SpliteMode { get; set; }
            [NameInMap("TableRuleTemplate")]
            [Validation(Required=false)]
            public string TableRuleTemplate { get; set; }
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }
            [NameInMap("ActivityMode")]
            [Validation(Required=false)]
            public long? ActivityMode { get; set; }
            [NameInMap("DbRuleName")]
            [Validation(Required=false)]
            public string DbRuleName { get; set; }
            [NameInMap("ActivityCount")]
            [Validation(Required=false)]
            public long? ActivityCount { get; set; }
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("TableRuleName")]
            [Validation(Required=false)]
            public string TableRuleName { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
        };

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
