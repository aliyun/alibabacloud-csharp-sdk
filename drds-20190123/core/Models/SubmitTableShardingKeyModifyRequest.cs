// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class SubmitTableShardingKeyModifyRequest : TeaModel {
        [NameInMap("DbComputeLength")]
        [Validation(Required=false)]
        public string DbComputeLength { get; set; }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("DbRightShiftOffset")]
        [Validation(Required=false)]
        public int? DbRightShiftOffset { get; set; }

        [NameInMap("DbShardingColumnList")]
        [Validation(Required=false)]
        public string DbShardingColumnList { get; set; }

        [NameInMap("DbShardingFunction")]
        [Validation(Required=false)]
        public string DbShardingFunction { get; set; }

        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("IsShard")]
        [Validation(Required=false)]
        public bool? IsShard { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SrcTableName")]
        [Validation(Required=false)]
        public string SrcTableName { get; set; }

        [NameInMap("TargetTableName")]
        [Validation(Required=false)]
        public string TargetTableName { get; set; }

        [NameInMap("TbComputeLength")]
        [Validation(Required=false)]
        public string TbComputeLength { get; set; }

        [NameInMap("TbPartitions")]
        [Validation(Required=false)]
        public string TbPartitions { get; set; }

        [NameInMap("TbRightShiftOffset")]
        [Validation(Required=false)]
        public string TbRightShiftOffset { get; set; }

        [NameInMap("TbShardingColumnList")]
        [Validation(Required=false)]
        public string TbShardingColumnList { get; set; }

        [NameInMap("TbShardingFunction")]
        [Validation(Required=false)]
        public string TbShardingFunction { get; set; }

    }

}
