// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunCommentGenerationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("length")]
        [Validation(Required=false)]
        public string Length { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("numComments")]
        [Validation(Required=false)]
        public string NumComments { get; set; }

        [NameInMap("sourceMaterial")]
        [Validation(Required=false)]
        public string SourceMaterial { get; set; }

        [NameInMap("style")]
        [Validation(Required=false)]
        public string Style { get; set; }

    }

}
