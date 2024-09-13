// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PreloadRegionSDGShrinkRequest : TeaModel {
        /// <summary>
        /// The IDs of the destination nodes.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationRegionIds")]
        [Validation(Required=false)]
        public string DestinationRegionIdsShrink { get; set; }

        /// <summary>
        /// The namespaces.
        /// </summary>
        [NameInMap("Namespaces")]
        [Validation(Required=false)]
        public string NamespacesShrink { get; set; }

        /// <summary>
        /// The number of redundant replicas to support rapid deployment.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RedundantNum")]
        [Validation(Required=false)]
        public int? RedundantNum { get; set; }

        /// <summary>
        /// The ID of the SDG for which data is preloaded.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SDGId")]
        [Validation(Required=false)]
        public string SDGId { get; set; }

    }

}
