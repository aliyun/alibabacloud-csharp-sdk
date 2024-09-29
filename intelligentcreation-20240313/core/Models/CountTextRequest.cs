// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CountTextRequest : TeaModel {
        /// <summary>
        /// <para>API</para>
        /// 
        /// <b>Example:</b>
        /// <para>PLATFORM</para>
        /// </summary>
        [NameInMap("generationSource")]
        [Validation(Required=false)]
        public string GenerationSource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Garment</para>
        /// </summary>
        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("publishStatus")]
        [Validation(Required=false)]
        public string PublishStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RED_BOOK</para>
        /// </summary>
        [NameInMap("style")]
        [Validation(Required=false)]
        public string Style { get; set; }

    }

}
