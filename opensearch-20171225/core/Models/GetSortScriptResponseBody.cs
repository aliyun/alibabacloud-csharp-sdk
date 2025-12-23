// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetSortScriptResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABCDEFGH</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the script.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetSortScriptResponseBodyResult Result { get; set; }
        public class GetSortScriptResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The time when the script was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-04-02 20:21:14</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the script was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-04-02 21:21:14</para>
            /// </summary>
            [NameInMap("modifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The sort phase to which the script applies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>second_rank</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The name of the script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rank_cava_20230606_v7</para>
            /// </summary>
            [NameInMap("scriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// <para>The status of the script. For more information, see the description of the status response parameter in the ListSortScripts topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>released</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cava_script</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
