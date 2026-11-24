// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenEduAiSuite20261102.Models
{
    public class CreateEduHomeworkCorrectSubmitRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to correct the image distortion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dewarp")]
        [Validation(Required=false)]
        public bool? Dewarp { get; set; }

        /// <summary>
        /// <para>The Base64-encoded image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/9j/4AAQSkZJRgABAQAASABIAAD/4QCMRXhpZgAATU0AK...</para>
        /// </summary>
        [NameInMap("imageBase64")]
        [Validation(Required=false)]
        public string ImageBase64 { get; set; }

        /// <summary>
        /// <para>The URL of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx/xxx.jpg">https://xxx/xxx.jpg</a></para>
        /// </summary>
        [NameInMap("imageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019F593F-D6EE-5F44-819A-6CDA127D1637</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
