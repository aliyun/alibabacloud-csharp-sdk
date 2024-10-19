// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class SdkGenerateByGroupResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://oss-bucket/object">http://oss-bucket/object</a></para>
        /// </summary>
        [NameInMap("DownloadLink")]
        [Validation(Required=false)]
        public string DownloadLink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D0075BDA-8AED-5073-A70A-FE44E86AB20F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
