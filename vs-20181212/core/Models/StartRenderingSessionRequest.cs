// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class StartRenderingSessionRequest : TeaModel {
        /// <summary>
        /// <para>The cloud application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cap-b06b26edfhytbn b94a75ae1a79efc90eb</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The unique ID of the end user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04c30850-1d91-4da1-b811-66d0ee94af7d</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The parameter information of the end user.</para>
        /// </summary>
        [NameInMap("ClientParams")]
        [Validation(Required=false)]
        public StartRenderingSessionRequestClientParams ClientParams { get; set; }
        public class StartRenderingSessionRequestClientParams : TeaModel {
            /// <summary>
            /// <para>The IP address of the end user. By default, this IP address is used for proximity-based instance scheduling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>106.11.43.1</para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

        }

        /// <summary>
        /// <para>The cloud application patch package ID.</para>
        /// <ol>
        /// <item><description>By default, the stable version of the application specified by AppId is started. If no stable patch version is set, the original version is started.</description></item>
        /// <item><description>If you specify origin, the original version is started.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>patch-03fa76e8e13a49b63456b063dgh309b4</para>
        /// </summary>
        [NameInMap("PatchId")]
        [Validation(Required=false)]
        public string PatchId { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
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
