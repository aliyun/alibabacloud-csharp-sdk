// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunBookBrainmapRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to clear the cache. The default is <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CleanCache")]
        [Validation(Required=false)]
        public bool? CleanCache { get; set; }

        /// <summary>
        /// <para>The document ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("DocId")]
        [Validation(Required=false)]
        public string DocId { get; set; }

        /// <summary>
        /// <para>The number of nodes on the second level of the mind map.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("NodeNumber")]
        [Validation(Required=false)]
        public int? NodeNumber { get; set; }

        /// <summary>
        /// <para>A prompt with additional instructions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>按英文输出</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ResponseFormat")]
        [Validation(Required=false)]
        public int? ResponseFormat { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The number of words per node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("WordNumber")]
        [Validation(Required=false)]
        public int? WordNumber { get; set; }

        /// <summary>
        /// <para>The unique identifier for the Model Studio workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">Workspace ID</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-hx72jf15gqyobvd9</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
