// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAssetSelectionSelectedTargetRequest : TeaModel {
        /// <summary>
        /// The unique ID of the asset.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SelectionKey")]
        [Validation(Required=false)]
        public string SelectionKey { get; set; }

        /// <summary>
        /// The details of queries.
        /// </summary>
        [NameInMap("TargetList")]
        [Validation(Required=false)]
        public List<string> TargetList { get; set; }

    }

}
