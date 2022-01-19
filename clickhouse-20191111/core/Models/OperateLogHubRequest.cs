// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class OperateLogHubRequest : TeaModel {
        [NameInMap("AccessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        [NameInMap("AccessSecret")]
        [Validation(Required=false)]
        public string AccessSecret { get; set; }

        [NameInMap("Create")]
        [Validation(Required=false)]
        public bool? Create { get; set; }

        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("DeliverName")]
        [Validation(Required=false)]
        public string DeliverName { get; set; }

        [NameInMap("DeliverTime")]
        [Validation(Required=false)]
        public string DeliverTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DomainUrl")]
        [Validation(Required=false)]
        public string DomainUrl { get; set; }

        [NameInMap("FilterDirtyData")]
        [Validation(Required=false)]
        public bool? FilterDirtyData { get; set; }

        [NameInMap("LogHubStores")]
        [Validation(Required=false)]
        public List<OperateLogHubRequestLogHubStores> LogHubStores { get; set; }
        public class OperateLogHubRequestLogHubStores : TeaModel {
            [NameInMap("FieldKey")]
            [Validation(Required=false)]
            public string FieldKey { get; set; }

            [NameInMap("LogKey")]
            [Validation(Required=false)]
            public string LogKey { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("LogStoreName")]
        [Validation(Required=false)]
        public string LogStoreName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("UseLorne")]
        [Validation(Required=false)]
        public bool? UseLorne { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
