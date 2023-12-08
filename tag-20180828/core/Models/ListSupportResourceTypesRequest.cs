// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListSupportResourceTypesRequest : TeaModel {
        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Maximum value: 1000. Default value: 50.
        /// </summary>
        [NameInMap("MaxResult")]
        [Validation(Required=false)]
        public int? MaxResult { get; set; }

        /// <summary>
        /// The token that is used to start the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The service code. This parameter specifies a filter condition for the query.
        /// 
        /// For more information about service codes, see [Services that work with Tag](~~171455~~).
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// For more information about the region ID, see [Endpoints](~~170112~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The resource type. This parameter specifies a filter condition for the query.
        /// 
        /// For more information about resource types, see [Services that work with Tag](~~171455~~).
        /// </summary>
        [NameInMap("ResourceTye")]
        [Validation(Required=false)]
        public string ResourceTye { get; set; }

        /// <summary>
        /// Specifies whether to return tag-related capability items. Valid values:
        /// 
        /// *   true: The system returns tag-related capability items.
        /// *   false (default value): The system does not return tag-related capability items.
        /// </summary>
        [NameInMap("ShowItems")]
        [Validation(Required=false)]
        public bool? ShowItems { get; set; }

        /// <summary>
        /// The code of the tag-related capability item. This parameter specifies a filter condition for the query.
        /// </summary>
        [NameInMap("SupportCode")]
        [Validation(Required=false)]
        public string SupportCode { get; set; }

    }

}
