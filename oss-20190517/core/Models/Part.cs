// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class Part : TeaModel {
        /// <summary>
        /// description
        /// </summary>
        [NameInMap("ETag")]
        [Validation(Required=false)]
        public string ETag { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("LastModified")]
        [Validation(Required=false)]
        public string LastModified { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("PartNumber")]
        [Validation(Required=false)]
        public long? PartNumber { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

    }

}
