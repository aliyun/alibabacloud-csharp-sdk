// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ListObjectsRequest : TeaModel {
        /// <summary>
        /// The name of the bucket.
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// The token used in this list operation. If the number of objects exceeds the value of MaxKeys, the NextContinuationToken is included in the response as the token for the next list operation.
        /// </summary>
        [NameInMap("ContinuationToken")]
        [Validation(Required=false)]
        public string ContinuationToken { get; set; }

        /// <summary>
        /// The encoding type of the object names in the response. Only URL encoding is supported.
        /// </summary>
        [NameInMap("EncodingType")]
        [Validation(Required=false)]
        public string EncodingType { get; set; }

        /// <summary>
        /// The position from which the list operation starts. The name of the object after which the list operation starts. If this parameter is specified, objects whose names are alphabetically greater than the value of Marker are returned. The Marker parameter is used to list the returned objects by page, and its value must be less than 1,024 bytes in length.
        /// 
        /// Even if the value specified for Marker does not exist in the list during a conditional query, the list starts from the object whose name is alphabetically greater than the value of Marker.
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// The maximum number of objects to return.
        /// 
        /// Valid values: 0 to 1000. Default value: 100.
        /// </summary>
        [NameInMap("MaxKeys")]
        [Validation(Required=false)]
        public long? MaxKeys { get; set; }

        /// <summary>
        /// The prefix that must be included in the names of objects you want to list. If you specify a prefix to query objects, the returned object names contain the prefix.
        /// 
        /// The value of the parameter must be less than 1,000 bytes in length.
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// The position from which the list operation starts. The name of the object after which the list operation starts. If this parameter is specified, objects whose names are alphabetically greater than the value of StartAfter are returned. The StartAfter parameter is used to list the returned objects by page, and its value must be less than 1,000 bytes in length.
        /// 
        /// Even if the value specified for StartAfter does not exist in the list during a conditional query, the list starts from the object whose name is alphabetically greater than the value of StartAfter.
        /// </summary>
        [NameInMap("StartAfter")]
        [Validation(Required=false)]
        public string StartAfter { get; set; }

    }

}
