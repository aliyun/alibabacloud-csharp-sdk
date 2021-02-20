/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avds20171129.Models
{
    public class AddAssetsRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("StartAfterVerified")]
        [Validation(Required=false)]
        public bool? StartAfterVerified { get; set; }

        [NameInMap("AssetGroupId")]
        [Validation(Required=false)]
        public string AssetGroupId { get; set; }

        [NameInMap("Assets")]
        [Validation(Required=false)]
        public List<string> Assets { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

    }

}
