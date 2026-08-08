// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class PrecheckResourceCountShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ACS::ECS::Instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TagResourceMatchers")]
        [Validation(Required=false)]
        public string TagResourceMatchersShrink { get; set; }

    }

}
