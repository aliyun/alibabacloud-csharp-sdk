// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GenerateUploadConfigRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2587494.html">AgentKey</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The file name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.docx</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The parent folder.</para>
        /// <list type="bullet">
        /// <item><description><para>materialDocument: The Material Library for AI Writing Assistant.</para>
        /// </description></item>
        /// <item><description><para>datasetUpload: The dataset for AI Search.</para>
        /// </description></item>
        /// <item><description><para>intervenes: Interventions.</para>
        /// </description></item>
        /// <item><description><para>temp: A temporary upload folder. Files in this folder are released periodically.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataset</para>
        /// </summary>
        [NameInMap("ParentDir")]
        [Validation(Required=false)]
        public string ParentDir { get; set; }

    }

}
