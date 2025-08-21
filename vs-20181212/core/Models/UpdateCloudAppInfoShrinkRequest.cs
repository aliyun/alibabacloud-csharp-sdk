// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UpdateCloudAppInfoShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cap-b06b26edfhytbn b94a75ae1a79efc90eb</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Patch")]
        [Validation(Required=false)]
        public string PatchShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>patch-03fa76e8e13a49b6a966b063d9d309b4</para>
        /// </summary>
        [NameInMap("StablePatchId")]
        [Validation(Required=false)]
        public string StablePatchId { get; set; }

    }

}
