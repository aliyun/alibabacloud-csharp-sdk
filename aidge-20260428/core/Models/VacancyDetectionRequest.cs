// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class VacancyDetectionRequest : TeaModel {
        /// <summary>
        /// <para>The HTTPS URL of the single image to be detected. Arrays or other image encodings are not supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/shelf.jpg">https://example.com/shelf.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The optional system prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are a helpful assistant.</para>
        /// </summary>
        [NameInMap("SystemPrompt")]
        [Validation(Required=false)]
        public string SystemPrompt { get; set; }

        /// <summary>
        /// <para>The optional user prompt. If left empty, the full empty space detection prompt is used. Plain text and JSON that contains only text in messages/content are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Detect empty spaces and underfilled areas on the shelf</para>
        /// </summary>
        [NameInMap("UserPrompt")]
        [Validation(Required=false)]
        public string UserPrompt { get; set; }

    }

}
