// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetUrlUploadInfosRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>df2ac80b481346daa1db6a7c40edc7f8</para>
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public string JobIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://media.w3.org/2010/05/sintel/trailer.mp4">https://media.w3.org/2010/05/sintel/trailer.mp4</a></para>
        /// </summary>
        [NameInMap("UploadURLs")]
        [Validation(Required=false)]
        public string UploadURLs { get; set; }

    }

}
