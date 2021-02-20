// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avds20171129.Models
{
    public class DescribeAssetsRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Search")]
        [Validation(Required=false)]
        public string Search { get; set; }

        [NameInMap("AssetGroupId")]
        [Validation(Required=false)]
        public string AssetGroupId { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("GmtCreateFrom")]
        [Validation(Required=false)]
        public long? GmtCreateFrom { get; set; }

        [NameInMap("GmtCreateTo")]
        [Validation(Required=false)]
        public long? GmtCreateTo { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Types")]
        [Validation(Required=false)]
        public List<string> Types { get; set; }

        [NameInMap("Assets")]
        [Validation(Required=false)]
        public List<string> Assets { get; set; }

    }

}
