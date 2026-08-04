// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetResourceGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Optional. Defaults to <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAIWorkspaceDataEnabled")]
        [Validation(Required=false)]
        public bool? IsAIWorkspaceDataEnabled { get; set; }

        /// <summary>
        /// <para>A list of up to 20 tags to add to the instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

    }

}
