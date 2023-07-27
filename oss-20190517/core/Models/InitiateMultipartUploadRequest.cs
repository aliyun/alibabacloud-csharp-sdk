// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class InitiateMultipartUploadRequest : TeaModel {
        /// <summary>
        /// The method used to encode the object name in the response. Only URL encoding is supported. The object name can contain characters encoded in UTF-8. However, the XML 1.0 standard cannot be used to parse specific control characters, such as characters whose ASCII values range from 0 to 10. You can configure the encoding-type parameter to encode object names that include characters that cannot be parsed by XML 1.0 in the response.
        /// <br>Default value: null
        /// </summary>
        [NameInMap("encoding-type")]
        [Validation(Required=false)]
        public string EncodingType { get; set; }

    }

}
