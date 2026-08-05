// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class GetConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7CC54C38-D721-4C55-A410-2A94B5A6BE0F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetConfigResponseBodyResult Result { get; set; }
        public class GetConfigResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The configuration content.</para>
            /// </summary>
            [NameInMap("configData")]
            [Validation(Required=false)]
            public Dictionary<string, object> ConfigData { get; set; }

            /// <summary>
            /// <para>The configuration type.</para>
            /// <list type="bullet">
            /// <item><description><para>prompt</para>
            /// </description></item>
            /// <item><description><para>lark</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>lark</para>
            /// </summary>
            [NameInMap("configType")]
            [Validation(Required=false)]
            public string ConfigType { get; set; }

            /// <summary>
            /// <para>The time when the configuration was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-18T07:04:42.877040</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            /// <summary>
            /// <para>The time when the configuration was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-18T07:04:42.877040</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public long? UpdatedAt { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1201721</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

    }

}
