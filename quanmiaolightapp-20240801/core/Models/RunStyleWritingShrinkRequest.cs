// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunStyleWritingShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("learningSamples")]
        [Validation(Required=false)]
        public string LearningSamplesShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("referenceMaterials")]
        [Validation(Required=false)]
        public string ReferenceMaterialsShrink { get; set; }

        [NameInMap("styleFeature")]
        [Validation(Required=false)]
        public string StyleFeature { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("writingTheme")]
        [Validation(Required=false)]
        public string WritingTheme { get; set; }

    }

}
