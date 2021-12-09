// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ListObjectsV2Request : TeaModel {
        [NameInMap("continuation-token")]
        [Validation(Required=false)]
        public string ContinuationToken { get; set; }

        /// <summary>
        /// The character used to group objects by name
        /// </summary>
        [NameInMap("delimiter")]
        [Validation(Required=false)]
        public string Delimiter { get; set; }

        /// <summary>
        /// The encoding type of the object name in the response
        /// </summary>
        [NameInMap("encoding-type")]
        [Validation(Required=false)]
        public string EncodingType { get; set; }

        [NameInMap("fetch-owner")]
        [Validation(Required=false)]
        public bool? FetchOwner { get; set; }

        /// <summary>
        /// The maximum number of objects to return
        /// </summary>
        [NameInMap("max-keys")]
        [Validation(Required=false)]
        public long? MaxKeys { get; set; }

        /// <summary>
        /// The prefix that the returned object names must contain
        /// </summary>
        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        [NameInMap("start-after")]
        [Validation(Required=false)]
        public string StartAfter { get; set; }

    }

}
