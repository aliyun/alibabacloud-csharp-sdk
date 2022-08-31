// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribePGHbaConfigResponseBody : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("DefaultHbaItems")]
        [Validation(Required=false)]
        public DescribePGHbaConfigResponseBodyDefaultHbaItems DefaultHbaItems { get; set; }
        public class DescribePGHbaConfigResponseBodyDefaultHbaItems : TeaModel {
            [NameInMap("HbaItem")]
            [Validation(Required=false)]
            public List<DescribePGHbaConfigResponseBodyDefaultHbaItemsHbaItem> HbaItem { get; set; }
            public class DescribePGHbaConfigResponseBodyDefaultHbaItemsHbaItem : TeaModel {
                public string Address { get; set; }
                public string Database { get; set; }
                public string Mask { get; set; }
                public string Method { get; set; }
                public string Option { get; set; }
                public int? PriorityId { get; set; }
                public string Type { get; set; }
                public string User { get; set; }
            }
        };

        [NameInMap("HbaModifyTime")]
        [Validation(Required=false)]
        public string HbaModifyTime { get; set; }

        [NameInMap("LastModifyStatus")]
        [Validation(Required=false)]
        public string LastModifyStatus { get; set; }

        [NameInMap("ModifyStatusReason")]
        [Validation(Required=false)]
        public string ModifyStatusReason { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RunningHbaItems")]
        [Validation(Required=false)]
        public DescribePGHbaConfigResponseBodyRunningHbaItems RunningHbaItems { get; set; }
        public class DescribePGHbaConfigResponseBodyRunningHbaItems : TeaModel {
            [NameInMap("HbaItem")]
            [Validation(Required=false)]
            public List<DescribePGHbaConfigResponseBodyRunningHbaItemsHbaItem> HbaItem { get; set; }
            public class DescribePGHbaConfigResponseBodyRunningHbaItemsHbaItem : TeaModel {
                public string Address { get; set; }
                public string Database { get; set; }
                public string Mask { get; set; }
                public string Method { get; set; }
                public string Option { get; set; }
                public int? PriorityId { get; set; }
                public string Type { get; set; }
                public string User { get; set; }
            }
        };

    }

}
