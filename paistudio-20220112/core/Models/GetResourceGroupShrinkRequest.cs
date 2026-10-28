// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetResourceGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable AI workspace data. This parameter is optional. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAIWorkspaceDataEnabled")]
        [Validation(Required=false)]
        public bool? IsAIWorkspaceDataEnabled { get; set; }

        /// <summary>
        /// <para>The list of tags to be added. A maximum of 20 tags can be added.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

    }

}
