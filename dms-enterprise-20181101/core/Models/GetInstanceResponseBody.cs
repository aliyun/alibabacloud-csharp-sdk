// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetInstanceResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Instance")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyInstance Instance { get; set; }
        public class GetInstanceResponseBodyInstance : TeaModel {
            [NameInMap("DataLinkName")]
            [Validation(Required=false)]
            public string DataLinkName { get; set; }

            [NameInMap("DatabasePassword")]
            [Validation(Required=false)]
            public string DatabasePassword { get; set; }

            [NameInMap("DatabaseUser")]
            [Validation(Required=false)]
            public string DatabaseUser { get; set; }

            [NameInMap("DbaId")]
            [Validation(Required=false)]
            public string DbaId { get; set; }

            [NameInMap("DbaNickName")]
            [Validation(Required=false)]
            public string DbaNickName { get; set; }

            [NameInMap("DdlOnline")]
            [Validation(Required=false)]
            public int? DdlOnline { get; set; }

            [NameInMap("EcsInstanceId")]
            [Validation(Required=false)]
            public string EcsInstanceId { get; set; }

            [NameInMap("EcsRegion")]
            [Validation(Required=false)]
            public string EcsRegion { get; set; }

            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            [NameInMap("ExportTimeout")]
            [Validation(Required=false)]
            public int? ExportTimeout { get; set; }

            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("InstanceAlias")]
            [Validation(Required=false)]
            public string InstanceAlias { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceSource")]
            [Validation(Required=false)]
            public string InstanceSource { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("OwnerIdList")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyInstanceOwnerIdList OwnerIdList { get; set; }
            public class GetInstanceResponseBodyInstanceOwnerIdList : TeaModel {
                [NameInMap("OwnerIds")]
                [Validation(Required=false)]
                public List<string> OwnerIds { get; set; }

            }

            [NameInMap("OwnerNameList")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyInstanceOwnerNameList OwnerNameList { get; set; }
            public class GetInstanceResponseBodyInstanceOwnerNameList : TeaModel {
                [NameInMap("OwnerNames")]
                [Validation(Required=false)]
                public List<string> OwnerNames { get; set; }

            }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("QueryTimeout")]
            [Validation(Required=false)]
            public int? QueryTimeout { get; set; }

            [NameInMap("SafeRuleId")]
            [Validation(Required=false)]
            public string SafeRuleId { get; set; }

            [NameInMap("SellSitd")]
            [Validation(Required=false)]
            public string SellSitd { get; set; }

            [NameInMap("Sid")]
            [Validation(Required=false)]
            public string Sid { get; set; }

            [NameInMap("StandardGroup")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyInstanceStandardGroup StandardGroup { get; set; }
            public class GetInstanceResponseBodyInstanceStandardGroup : TeaModel {
                [NameInMap("GroupMode")]
                [Validation(Required=false)]
                public string GroupMode { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("UseDsql")]
            [Validation(Required=false)]
            public int? UseDsql { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
