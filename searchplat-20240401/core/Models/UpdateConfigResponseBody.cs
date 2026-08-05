// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class UpdateConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAD430CC-D016-10BF-B837-8DA1EED87E94</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result object.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateConfigResponseBodyResult Result { get; set; }
        public class UpdateConfigResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The configuration content.</para>
            /// </summary>
            [NameInMap("configData")]
            [Validation(Required=false)]
            public Dictionary<string, object> ConfigData { get; set; }

            /// <summary>
            /// <para>The configuration category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prompt</para>
            /// </summary>
            [NameInMap("configType")]
            [Validation(Required=false)]
            public string ConfigType { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-18T07:04:42.877040</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-18T07:04:42.877040</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-001</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

    }

}
