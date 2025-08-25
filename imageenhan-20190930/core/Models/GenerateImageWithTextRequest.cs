// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class GenerateImageWithTextRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Number")]
        [Validation(Required=false)]
        public int? Number { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1024*1024</para>
        /// </summary>
        [NameInMap("Resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
