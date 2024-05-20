// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListNamespaceChangeOrdersRequest : TeaModel {
        /// <summary>
        /// 2
        /// </summary>
        [NameInMap("CoStatus")]
        [Validation(Required=false)]
        public string CoStatus { get; set; }

        /// <summary>
        /// CoBatchStartApplication
        /// </summary>
        [NameInMap("CoType")]
        [Validation(Required=false)]
        public string CoType { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// cn-shanghai:test
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// 20
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
