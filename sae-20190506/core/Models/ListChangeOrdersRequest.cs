// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListChangeOrdersRequest : TeaModel {
        /// <summary>
        /// 1
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("CoStatus")]
        [Validation(Required=false)]
        public string CoStatus { get; set; }

        /// <summary>
        /// 2
        /// </summary>
        [NameInMap("CoType")]
        [Validation(Required=false)]
        public string CoType { get; set; }

        /// <summary>
        /// 20
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// CoCreateApp
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
