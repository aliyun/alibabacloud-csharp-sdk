// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class PatchPolarClawConfigShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>A JSON merge-patch object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;tools&quot;: {
        ///         &quot;web&quot;: {
        ///             &quot;search&quot;: {
        ///                 &quot;enabled&quot;: false
        ///             }
        ///         }
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("ConfigPatch")]
        [Validation(Required=false)]
        public string ConfigPatchShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to restart the gateway after applying the patch. The default is <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Restart")]
        [Validation(Required=false)]
        public bool? Restart { get; set; }

    }

}
