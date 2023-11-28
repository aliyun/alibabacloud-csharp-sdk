// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListInstanceIndicesRequest : TeaModel {
        /// <summary>
        /// false
        /// </summary>
        [NameInMap("all")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// 15
        /// </summary>
        [NameInMap("isManaged")]
        [Validation(Required=false)]
        public bool? IsManaged { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("isOpenstore")]
        [Validation(Required=false)]
        public bool? IsOpenstore { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The header of the response.
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// The total size of the index in Cloud Hosting. Unit: bytes.
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
