// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class BatchcreateDtxAppRequest : TeaModel {
        [NameInMap("ActivityMode")]
        [Validation(Required=false)]
        public long? ActivityMode { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("DbRuleName")]
        [Validation(Required=false)]
        public string DbRuleName { get; set; }

        [NameInMap("DbRuleTemplete")]
        [Validation(Required=false)]
        public string DbRuleTemplete { get; set; }

        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("TableRuleName")]
        [Validation(Required=false)]
        public string TableRuleName { get; set; }

        [NameInMap("TableRuleTemplete")]
        [Validation(Required=false)]
        public string TableRuleTemplete { get; set; }

        [NameInMap("ActionArray")]
        [Validation(Required=false)]
        public List<BatchcreateDtxAppRequestActionArray> ActionArray { get; set; }
        public class BatchcreateDtxAppRequestActionArray : TeaModel {
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

        [NameInMap("RecoveryArray")]
        [Validation(Required=false)]
        public List<BatchcreateDtxAppRequestRecoveryArray> RecoveryArray { get; set; }
        public class BatchcreateDtxAppRequestRecoveryArray : TeaModel {
            [NameInMap("IsAsyn")]
            [Validation(Required=false)]
            public bool? IsAsyn { get; set; }

            [NameInMap("IsLoadTest")]
            [Validation(Required=false)]
            public bool? IsLoadTest { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("IsMix")]
            [Validation(Required=false)]
            public bool? IsMix { get; set; }

            [NameInMap("RecoveryThreadNum")]
            [Validation(Required=false)]
            public long? RecoveryThreadNum { get; set; }

            [NameInMap("RecoveryLimit")]
            [Validation(Required=false)]
            public long? RecoveryLimit { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

        }

        [NameInMap("RecoveryDsArray")]
        [Validation(Required=false)]
        public List<BatchcreateDtxAppRequestRecoveryDsArray> RecoveryDsArray { get; set; }
        public class BatchcreateDtxAppRequestRecoveryDsArray : TeaModel {
            [NameInMap("TaskNameFormat")]
            [Validation(Required=false)]
            public string TaskNameFormat { get; set; }

            [NameInMap("IsLdc")]
            [Validation(Required=false)]
            public bool? IsLdc { get; set; }

            [NameInMap("DsIndexEnd")]
            [Validation(Required=false)]
            public long? DsIndexEnd { get; set; }

            [NameInMap("ActionTableNameFormat")]
            [Validation(Required=false)]
            public string ActionTableNameFormat { get; set; }

            [NameInMap("TaskIndexStart")]
            [Validation(Required=false)]
            public long? TaskIndexStart { get; set; }

            [NameInMap("IsLocalDs")]
            [Validation(Required=false)]
            public bool? IsLocalDs { get; set; }

            [NameInMap("TaskIndexEnd")]
            [Validation(Required=false)]
            public long? TaskIndexEnd { get; set; }

            [NameInMap("ActionTableIndexEnd")]
            [Validation(Required=false)]
            public long? ActionTableIndexEnd { get; set; }

            [NameInMap("DbConnectMin")]
            [Validation(Required=false)]
            public long? DbConnectMin { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("DbType")]
            [Validation(Required=false)]
            public long? DbType { get; set; }

            [NameInMap("DsIndexStart")]
            [Validation(Required=false)]
            public long? DsIndexStart { get; set; }

            [NameInMap("DbConnMax")]
            [Validation(Required=false)]
            public long? DbConnMax { get; set; }

            [NameInMap("DsNameFormat")]
            [Validation(Required=false)]
            public string DsNameFormat { get; set; }

            [NameInMap("ActionTableIndexStart")]
            [Validation(Required=false)]
            public long? ActionTableIndexStart { get; set; }

            [NameInMap("ActivityTableIndexEnd")]
            [Validation(Required=false)]
            public long? ActivityTableIndexEnd { get; set; }

            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

            [NameInMap("ActivityTableNameFormat")]
            [Validation(Required=false)]
            public string ActivityTableNameFormat { get; set; }

            [NameInMap("ActivityTableIndexStart")]
            [Validation(Required=false)]
            public long? ActivityTableIndexStart { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

    }

}
