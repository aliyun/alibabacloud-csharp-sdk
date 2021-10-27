// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class CreateDrdsDBPreviewRequest : TeaModel {
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("DbInstType")]
        [Validation(Required=false)]
        public string DbInstType { get; set; }

        [NameInMap("DbInstanceIsCreating")]
        [Validation(Required=false)]
        public bool? DbInstanceIsCreating { get; set; }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("InstDbName")]
        [Validation(Required=false)]
        public List<CreateDrdsDBPreviewRequestInstDbName> InstDbName { get; set; }
        public class CreateDrdsDBPreviewRequestInstDbName : TeaModel {
            [NameInMap("DbInstanceId")]
            [Validation(Required=false)]
            public string DbInstanceId { get; set; }

            [NameInMap("ShardDbName")]
            [Validation(Required=false)]
            public List<string> ShardDbName { get; set; }

        }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("RdsInstance")]
        [Validation(Required=false)]
        public List<string> RdsInstance { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
