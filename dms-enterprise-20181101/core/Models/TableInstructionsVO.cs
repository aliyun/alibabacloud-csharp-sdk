// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class TableInstructionsVO : TeaModel {
        [NameInMap("AssetCreatedGmt")]
        [Validation(Required=false)]
        public string AssetCreatedGmt { get; set; }

        [NameInMap("AssetDescription")]
        [Validation(Required=false)]
        public string AssetDescription { get; set; }

        [NameInMap("AssetModifiedGmt")]
        [Validation(Required=false)]
        public string AssetModifiedGmt { get; set; }

        [NameInMap("DbId")]
        [Validation(Required=false)]
        public int? DbId { get; set; }

        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
