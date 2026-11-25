// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UpgradeRenderingServerImageShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-9timxhrrgopkec8ju</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Precheck")]
        [Validation(Required=false)]
        public bool? Precheck { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;render-30d593fb042946c58568316956624c6b&quot;]</para>
        /// </summary>
        [NameInMap("RenderingInstanceIds")]
        [Validation(Required=false)]
        public string RenderingInstanceIdsShrink { get; set; }

    }

}
