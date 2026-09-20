// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class AiTryOnRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/cloth.png">https://example.com/cloth.png</a></para>
        /// </summary>
        [NameInMap("ClothImageUrl")]
        [Validation(Required=false)]
        public string ClothImageUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>tops</para>
        /// </summary>
        [NameInMap("ClothType")]
        [Validation(Required=false)]
        public string ClothType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/model.png">https://example.com/model.png</a></para>
        /// </summary>
        [NameInMap("ModelImageUrl")]
        [Validation(Required=false)]
        public string ModelImageUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1K</para>
        /// </summary>
        [NameInMap("Resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

    }

}
