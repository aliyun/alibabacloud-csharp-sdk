// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class StartRenderingSessionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Cloud application ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cap-b06b26edfhytbn b94a75ae1a79efc90eb</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Unique ID of the client</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04c30850-1d91-4da1-b811-66d0ee94af7d</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>Client parameter information</para>
        /// </summary>
        [NameInMap("ClientParams")]
        [Validation(Required=false)]
        public string ClientParamsShrink { get; set; }

        /// <summary>
        /// <para>Cloud application patch ID.</para>
        /// <ol>
        /// <item><description><para>By default, start the stable version of the AppId (if no stable patch version is set, the original version is used).</para>
        /// </description></item>
        /// <item><description><para>If you enter &quot;origin&quot;, start the original version.</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>patch-03fa76e8e13a49b63456b063dgh309b4</para>
        /// </summary>
        [NameInMap("PatchId")]
        [Validation(Required=false)]
        public string PatchId { get; set; }

        /// <summary>
        /// <para>Project ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project-422bc38dfgh5eb44149f135ef76304f63b</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
