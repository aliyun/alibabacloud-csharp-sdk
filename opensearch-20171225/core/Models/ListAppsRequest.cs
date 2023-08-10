// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListAppsRequest : TeaModel {
        /// <summary>
        /// true
        /// </summary>
        [NameInMap("group")]
        [Validation(Required=false)]
        public bool? Group { get; set; }

        /// <summary>
        /// 0
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// 0
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
