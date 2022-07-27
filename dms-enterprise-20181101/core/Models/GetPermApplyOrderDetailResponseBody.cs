// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetPermApplyOrderDetailResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("PermApplyOrderDetail")]
        [Validation(Required=false)]
        public GetPermApplyOrderDetailResponseBodyPermApplyOrderDetail PermApplyOrderDetail { get; set; }
        public class GetPermApplyOrderDetailResponseBodyPermApplyOrderDetail : TeaModel {
            [NameInMap("ApplyType")]
            [Validation(Required=false)]
            public string ApplyType { get; set; }
            [NameInMap("PermType")]
            [Validation(Required=false)]
            public long? PermType { get; set; }
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResources> Resources { get; set; }
            public class GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResources : TeaModel {
                public GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesColumnInfo ColumnInfo { get; set; }
                public class GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesColumnInfo : TeaModel {
                    [NameInMap("ColumnName")]
                    [Validation(Required=false)]
                    public string ColumnName { get; set; }

                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }
                public GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesDatabaseInfo DatabaseInfo { get; set; }
                public class GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesDatabaseInfo : TeaModel {
                    [NameInMap("DbId")]
                    [Validation(Required=false)]
                    public long? DbId { get; set; }

                    [NameInMap("DbType")]
                    [Validation(Required=false)]
                    public string DbType { get; set; }

                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                    [NameInMap("Logic")]
                    [Validation(Required=false)]
                    public bool? Logic { get; set; }

                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<long?> OwnerIds { get; set; }

                    [NameInMap("OwnerNickNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNickNames { get; set; }

                    [NameInMap("SearchName")]
                    [Validation(Required=false)]
                    public string SearchName { get; set; }

                }
                public GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesInstanceInfo InstanceInfo { get; set; }
                public class GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesInstanceInfo : TeaModel {
                    [NameInMap("DbType")]
                    [Validation(Required=false)]
                    public string DbType { get; set; }

                    [NameInMap("DbaId")]
                    [Validation(Required=false)]
                    public long? DbaId { get; set; }

                    [NameInMap("DbaNickName")]
                    [Validation(Required=false)]
                    public string DbaNickName { get; set; }

                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<long?> OwnerIds { get; set; }

                    [NameInMap("OwnerNickName")]
                    [Validation(Required=false)]
                    public List<string> OwnerNickName { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public long? Port { get; set; }

                    [NameInMap("SearchName")]
                    [Validation(Required=false)]
                    public string SearchName { get; set; }

                }
                public GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesTableInfo TableInfo { get; set; }
                public class GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesTableInfo : TeaModel {
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }
            }
            [NameInMap("Seconds")]
            [Validation(Required=false)]
            public long? Seconds { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
