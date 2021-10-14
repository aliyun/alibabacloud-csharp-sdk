// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeInstanceSourcesResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeInstanceSourcesResponseBodyItems> Items { get; set; }
        public class DescribeInstanceSourcesResponseBodyItems : TeaModel {
            [NameInMap("LastModifyUserId")]
            [Validation(Required=false)]
            public string LastModifyUserId { get; set; }

            [NameInMap("PasswordStatus")]
            [Validation(Required=false)]
            public int? PasswordStatus { get; set; }

            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public long? LastModifyTime { get; set; }

            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            [NameInMap("CanModifyUserName")]
            [Validation(Required=false)]
            public bool? CanModifyUserName { get; set; }

            [NameInMap("LogStoreDay")]
            [Validation(Required=false)]
            public int? LogStoreDay { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("AutoScan")]
            [Validation(Required=false)]
            public int? AutoScan { get; set; }

            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public long? ProductId { get; set; }

            [NameInMap("InstanceSize")]
            [Validation(Required=false)]
            public long? InstanceSize { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public int? AuditStatus { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }

        }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
