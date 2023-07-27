// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class HeadObjectHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// If the ETag value that is specified in the request matches the ETag value of the object, OSS returns 200 OK and the metadata of the object. Otherwise, OSS returns 412 precondition failed. 
        /// Default value: null.
        /// </summary>
        [NameInMap("If-Match")]
        [Validation(Required=false)]
        public string IfMatch { get; set; }

        /// <summary>
        /// If the time that is specified in the request is earlier than the time when the object is modified, OSS returns 200 OK and the metadata of the object. Otherwise, OSS returns 304 not modified. 
        /// Default value: null.
        /// </summary>
        [NameInMap("If-Modified-Since")]
        [Validation(Required=false)]
        public string IfModifiedSince { get; set; }

        /// <summary>
        /// If the ETag value that is specified in the request does not match the ETag value of the object, OSS returns 200 OK and the metadata of the object. Otherwise, OSS returns 304 Not Modified. 
        /// Default value: null.
        /// </summary>
        [NameInMap("If-None-Match")]
        [Validation(Required=false)]
        public string IfNoneMatch { get; set; }

        /// <summary>
        /// If the time that is specified in the request is later than or the same as the time when the object is modified, OSS returns 200 OK and the metadata of the object. Otherwise, OSS returns 412 precondition failed. 
        /// Default value: null.
        /// </summary>
        [NameInMap("If-Unmodified-Since")]
        [Validation(Required=false)]
        public string IfUnmodifiedSince { get; set; }

    }

}
