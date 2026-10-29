// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UpdateCloudAppInfoShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud application, which corresponds to a unique application package.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cap-b06b26edfhytbn b94a75ae1a79efc90eb</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The description of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Used for testing</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The information about the patch package to be uploaded. 1. This parameter is not supported when PkgType is set to android. 2. Only one patch package can be in the uploading state (non-final state) for the same AppId at a time.</para>
        /// </summary>
        [NameInMap("Patch")]
        [Validation(Required=false)]
        public string PatchShrink { get; set; }

        /// <summary>
        /// <para>The tags of the cloud application. You can specify multiple tags to reset the cloud application tags. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>hot</description></item>
        /// <item><description>game</description></item>
        /// <item><description>app
        /// To delete all tags, set the value to [&quot;NULL&quot;].</description></item>
        /// </list>
        /// </summary>
        [NameInMap("PkgLabels")]
        [Validation(Required=false)]
        public string PkgLabelsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the stable patch. This is the default patch ID used in customer business scenarios, such as session startup, when no patch ID is specified. This parameter is not supported when PkgType is set to android. Special value: origin: cancels the patch version and uses the initial version by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>patch-03fa76e8e13a49b6a966b063d9d309b4</para>
        /// </summary>
        [NameInMap("StablePatchId")]
        [Validation(Required=false)]
        public string StablePatchId { get; set; }

    }

}
