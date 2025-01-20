// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class IllustrationTaskCreateCmd : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0-不换背景，1-换背景</para>
        /// </summary>
        [NameInMap("backgroundType")]
        [Validation(Required=false)]
        public int? BackgroundType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("dstHeight")]
        [Validation(Required=false)]
        public int? DstHeight { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("dstWidth")]
        [Validation(Required=false)]
        public int? DstWidth { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>28274623764834</para>
        /// </summary>
        [NameInMap("idempotentId")]
        [Validation(Required=false)]
        public string IdempotentId { get; set; }

        [NameInMap("imageUrls")]
        [Validation(Required=false)]
        public List<string> ImageUrls { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("nums")]
        [Validation(Required=false)]
        public int? Nums { get; set; }

        [NameInMap("ossPaths")]
        [Validation(Required=false)]
        public List<string> OssPaths { get; set; }

        [NameInMap("stickerText")]
        [Validation(Required=false)]
        public string StickerText { get; set; }

    }

}
