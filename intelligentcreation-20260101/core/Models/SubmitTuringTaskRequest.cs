// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20260101.Models
{
    public class SubmitTuringTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>82veb0a6wc41asdv80</para>
        /// </summary>
        [NameInMap("idempotentKey")]
        [Validation(Required=false)]
        public string IdempotentKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://www.example.com/1.png">https://www.example.com/1.png</a></para>
        /// </summary>
        [NameInMap("imgUrl")]
        [Validation(Required=false)]
        public string ImgUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>720P</para>
        /// </summary>
        [NameInMap("resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>live-wallpaper</para>
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
