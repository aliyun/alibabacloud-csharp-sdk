// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class GetObjectHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// The encoding type at the client side. 
        /// If you want an object to be returned in the GZIP format, you must include the Accept-Encoding:gzip header in your request. OSS determines whether to return the object compressed in the GZip format based on the Content-Type header and whether the size of the object is larger than or equal to 1 KB.
        ///                                   
        /// > If an object is compressed in the GZip format, the response OSS returns does not include the ETag value of the object. 
        /// >   - OSS supports the following Content-Type values to compress the object in the GZip format: text/cache-manifest, text/xml, text/plain, text/css, application/javascript, application/x-javascript, application/rss+xml, application/json, and text/json. 
        /// 
        /// Default value: null
        /// </summary>
        [NameInMap("Accept-Encoding")]
        [Validation(Required=false)]
        public string AcceptEncoding { get; set; }

        /// <summary>
        /// If the ETag specified in the request matches the ETag value of the object, OSS transmits the object and returns 200 OK. If the ETag specified in the request does not match the ETag value of the object, OSS returns 412 Precondition Failed. 
        /// The ETag value of an object is used to check whether the content of the object has changed. You can check data integrity by using the ETag value. 
        /// Default value: null
        /// </summary>
        [NameInMap("If-Match")]
        [Validation(Required=false)]
        public string IfMatch { get; set; }

        /// <summary>
        /// If the time specified in this header is earlier than the object modified time or is invalid, OSS returns the object and 200 OK. If the time specified in this header is later than or the same as the object modified time, OSS returns 304 Not Modified. 
        /// The time must be in GMT. Example: `Fri, 13 Nov 2015 14:47:53 GMT`.
        /// Default value: null
        /// </summary>
        [NameInMap("If-Modified-Since")]
        [Validation(Required=false)]
        public string IfModifiedSince { get; set; }

        /// <summary>
        /// If the ETag specified in the request does not match the ETag value of the object, OSS transmits the object and returns 200 OK. If the ETag specified in the request matches the ETag value of the object, OSS returns 304 Not Modified. 
        /// You can specify both the **If-Match** and **If-None-Match** headers in a request. 
        /// Default value: null
        /// </summary>
        [NameInMap("If-None-Match")]
        [Validation(Required=false)]
        public string IfNoneMatch { get; set; }

        /// <summary>
        /// If the time specified in this header is the same as or later than the object modified time, OSS returns the object and 200 OK. If the time specified in this header is earlier than the object modified time, OSS returns 412 Precondition Failed.
        ///                                
        /// The time must be in GMT. Example: `Fri, 13 Nov 2015 14:47:53 GMT`.
        /// You can specify both the **If-Modified-Since** and **If-Unmodified-Since** headers in a request. 
        /// Default value: null
        /// </summary>
        [NameInMap("If-Unmodified-Since")]
        [Validation(Required=false)]
        public string IfUnmodifiedSince { get; set; }

        /// <summary>
        /// The range of data of the object to be returned. 
        ///   - If the value of Range is valid, OSS returns the response that includes the total size of the object and the range of data returned. For example, Content-Range: bytes 0~9/44 indicates that the total size of the object is 44 bytes, and the range of data returned is the first 10 bytes. 
        ///   - However, if the value of Range is invalid, the entire object is returned, and the response returned by OSS excludes Content-Range. 
        /// 
        /// Default value: null
        /// </summary>
        [NameInMap("Range")]
        [Validation(Required=false)]
        public string Range { get; set; }

    }

}
