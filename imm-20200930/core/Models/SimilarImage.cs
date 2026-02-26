// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SimilarImage : TeaModel {
        /// <summary>
        /// <para>The aesthetic score.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.709</para>
        /// </summary>
        [NameInMap("ImageScore")]
        [Validation(Required=false)]
        public double? ImageScore { get; set; }

        /// <summary>
        /// <para>The URI of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-object</para>
        /// </summary>
        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

    }

}
