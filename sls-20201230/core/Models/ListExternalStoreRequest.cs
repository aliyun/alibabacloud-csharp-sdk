// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListExternalStoreRequest : TeaModel {
        /// <summary>
        /// The name of the external store. You can query external stores that contain a specified string.
        /// </summary>
        [NameInMap("externalStoreName")]
        [Validation(Required=false)]
        public string ExternalStoreName { get; set; }

        /// <summary>
        /// The line from which the query starts. Default value: 0.
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: 500.
        /// </summary>
        [NameInMap("sizs")]
        [Validation(Required=false)]
        public int? Sizs { get; set; }

    }

}
