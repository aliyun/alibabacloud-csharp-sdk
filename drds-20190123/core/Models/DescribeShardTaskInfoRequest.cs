// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeShardTaskInfoRequest : TeaModel {
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SourceTableName")]
        [Validation(Required=false)]
        public string SourceTableName { get; set; }

        [NameInMap("TargetTableName")]
        [Validation(Required=false)]
        public string TargetTableName { get; set; }

    }

}
