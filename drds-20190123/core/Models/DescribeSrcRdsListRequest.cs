// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeSrcRdsListRequest : TeaModel {
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("PartitionMapping")]
        [Validation(Required=false)]
        public List<DescribeSrcRdsListRequestPartitionMapping> PartitionMapping { get; set; }
        public class DescribeSrcRdsListRequestPartitionMapping : TeaModel {
            [NameInMap("DbShardValue")]
            [Validation(Required=false)]
            public string DbShardValue { get; set; }

            [NameInMap("HotDbName")]
            [Validation(Required=false)]
            public string HotDbName { get; set; }

            [NameInMap("HotTableName")]
            [Validation(Required=false)]
            public string HotTableName { get; set; }

            [NameInMap("LogicTable")]
            [Validation(Required=false)]
            public string LogicTable { get; set; }

            [NameInMap("TbShardValue")]
            [Validation(Required=false)]
            public string TbShardValue { get; set; }

        }

    }

}
