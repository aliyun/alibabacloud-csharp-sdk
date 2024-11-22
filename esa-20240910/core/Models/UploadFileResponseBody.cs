// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UploadFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3C6CCEC4-6B88-4D4A-93E4-D47B3D92CF8F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the file upload task. You can use this ID for task submission or query subsequently.</para>
        /// 
        /// <b>Example:</b>
        /// <para>159253299357****</para>
        /// </summary>
        [NameInMap("UploadId")]
        [Validation(Required=false)]
        public long? UploadId { get; set; }

    }

}
