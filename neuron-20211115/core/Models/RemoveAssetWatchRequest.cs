// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class RemoveAssetWatchRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("assetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

        [NameInMap("companyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

    }

}
