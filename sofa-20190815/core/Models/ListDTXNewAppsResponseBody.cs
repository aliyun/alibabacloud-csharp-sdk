// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListDTXNewAppsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDTXNewAppsResponseBodyData> Data { get; set; }
        public class ListDTXNewAppsResponseBodyData : TeaModel {
            [NameInMap("ActionCount")]
            [Validation(Required=false)]
            public long? ActionCount { get; set; }

            [NameInMap("ActivityCount")]
            [Validation(Required=false)]
            public long? ActivityCount { get; set; }

            [NameInMap("ActivityMode")]
            [Validation(Required=false)]
            public long? ActivityMode { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("DbRuleName")]
            [Validation(Required=false)]
            public string DbRuleName { get; set; }

            [NameInMap("DbRuleTemplate")]
            [Validation(Required=false)]
            public string DbRuleTemplate { get; set; }

            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("SpliteMode")]
            [Validation(Required=false)]
            public long? SpliteMode { get; set; }

            [NameInMap("TableRuleName")]
            [Validation(Required=false)]
            public string TableRuleName { get; set; }

            [NameInMap("TableRuleTemplate")]
            [Validation(Required=false)]
            public string TableRuleTemplate { get; set; }

            [NameInMap("Used")]
            [Validation(Required=false)]
            public bool? Used { get; set; }

            [NameInMap("ActionArray")]
            [Validation(Required=false)]
            public List<ListDTXNewAppsResponseBodyDataActionArray> ActionArray { get; set; }
            public class ListDTXNewAppsResponseBodyDataActionArray : TeaModel {
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

            [NameInMap("RecoveryArray")]
            [Validation(Required=false)]
            public List<ListDTXNewAppsResponseBodyDataRecoveryArray> RecoveryArray { get; set; }
            public class ListDTXNewAppsResponseBodyDataRecoveryArray : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("ClientVersion")]
                [Validation(Required=false)]
                public string ClientVersion { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IsAsyn")]
                [Validation(Required=false)]
                public bool? IsAsyn { get; set; }

                [NameInMap("IsDds")]
                [Validation(Required=false)]
                public bool? IsDds { get; set; }

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

                [NameInMap("Used")]
                [Validation(Required=false)]
                public bool? Used { get; set; }

                [NameInMap("DsArray")]
                [Validation(Required=false)]
                public List<ListDTXNewAppsResponseBodyDataRecoveryArrayDsArray> DsArray { get; set; }
                public class ListDTXNewAppsResponseBodyDataRecoveryArrayDsArray : TeaModel {
                    [NameInMap("ActionTableIndexEnd")]
                    [Validation(Required=false)]
                    public long? ActionTableIndexEnd { get; set; }

                    [NameInMap("ActionTableIndexStart")]
                    [Validation(Required=false)]
                    public long? ActionTableIndexStart { get; set; }

                    [NameInMap("ActionTableNameFormat")]
                    [Validation(Required=false)]
                    public string ActionTableNameFormat { get; set; }

                    [NameInMap("ActivityTableIndexEnd")]
                    [Validation(Required=false)]
                    public long? ActivityTableIndexEnd { get; set; }

                    [NameInMap("ActivityTableIndexStart")]
                    [Validation(Required=false)]
                    public long? ActivityTableIndexStart { get; set; }

                    [NameInMap("ActivityTableNameFormat")]
                    [Validation(Required=false)]
                    public string ActivityTableNameFormat { get; set; }

                    [NameInMap("DbConnectMin")]
                    [Validation(Required=false)]
                    public long? DbConnectMin { get; set; }

                    [NameInMap("DbConnMax")]
                    [Validation(Required=false)]
                    public long? DbConnMax { get; set; }

                    [NameInMap("DbType")]
                    [Validation(Required=false)]
                    public long? DbType { get; set; }

                    [NameInMap("DsIndexEnd")]
                    [Validation(Required=false)]
                    public long? DsIndexEnd { get; set; }

                    [NameInMap("DsIndexStart")]
                    [Validation(Required=false)]
                    public long? DsIndexStart { get; set; }

                    [NameInMap("DsNameFormat")]
                    [Validation(Required=false)]
                    public string DsNameFormat { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("IsLdc")]
                    [Validation(Required=false)]
                    public bool? IsLdc { get; set; }

                    [NameInMap("IsLocalDs")]
                    [Validation(Required=false)]
                    public bool? IsLocalDs { get; set; }

                    [NameInMap("TaskIndexEnd")]
                    [Validation(Required=false)]
                    public long? TaskIndexEnd { get; set; }

                    [NameInMap("TaskIndexStart")]
                    [Validation(Required=false)]
                    public long? TaskIndexStart { get; set; }

                    [NameInMap("TaskNameFormat")]
                    [Validation(Required=false)]
                    public string TaskNameFormat { get; set; }

                    [NameInMap("Zone")]
                    [Validation(Required=false)]
                    public string Zone { get; set; }

                }

            }

        }

    }

}
