// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class Bucket : TeaModel {
        /// <summary>
        /// The time when the bucket is created.
        /// </summary>
        [NameInMap("CreationDate")]
        [Validation(Required=false)]
        public string CreationDate { get; set; }

        /// <summary>
        /// The public endpoint used to access the bucket over the Internet.
        /// </summary>
        [NameInMap("ExtranetEndpoint")]
        [Validation(Required=false)]
        public string ExtranetEndpoint { get; set; }

        /// <summary>
        /// The internal endpoint used to access the bucket from ECS instances in the same region.
        /// </summary>
        [NameInMap("IntranetEndpoint")]
        [Validation(Required=false)]
        public string IntranetEndpoint { get; set; }

        /// <summary>
        /// The data center in which the bucket is located.
        /// </summary>
        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// The name of the bucket.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The physical location of the bucket.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("StorageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

    }

}
