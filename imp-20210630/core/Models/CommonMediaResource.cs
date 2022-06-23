// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class CommonMediaResource : TeaModel {
        /// <summary>
        /// media format
        /// </summary>
        [NameInMap("Format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        /// <summary>
        /// media id
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// media sha1
        /// </summary>
        [NameInMap("Sha1")]
        [Validation(Required=false)]
        public string Sha1 { get; set; }

        /// <summary>
        /// media size
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// resource url
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
