// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class PushDocumentsRequest : TeaModel {
        /// <summary>
        /// The request body.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<object> Body { get; set; }

        /// <summary>
        /// The primary key field.
        /// </summary>
        [NameInMap("pkField")]
        [Validation(Required=false)]
        public string PkField { get; set; }

    }

}
