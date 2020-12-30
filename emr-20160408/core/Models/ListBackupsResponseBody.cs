// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListBackupsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public ListBackupsResponseBodyItems Items { get; set; }
        public class ListBackupsResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<ListBackupsResponseBodyItemsItem> Item { get; set; }
            public class ListBackupsResponseBodyItemsItem : TeaModel {
                public string Status { get; set; }
                public string TarFileName { get; set; }
                public string StorePath { get; set; }
                public long? CreateTime { get; set; }
                public string Md5 { get; set; }
                public string BackupPlanId { get; set; }
                public ListBackupsResponseBodyItemsItemMetadataInfo MetadataInfo { get; set; }
                public class ListBackupsResponseBodyItemsItemMetadataInfo : TeaModel {
                    [NameInMap("MetadataType")]
                    [Validation(Required=false)]
                    public string MetadataType { get; set; }

                    [NameInMap("Properties")]
                    [Validation(Required=false)]
                    public string Properties { get; set; }

                }
                public string Id { get; set; }
                public string ClusterId { get; set; }
            }
        };

    }

}
