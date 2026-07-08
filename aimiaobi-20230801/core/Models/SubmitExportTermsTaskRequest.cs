// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitExportTermsTaskRequest : TeaModel {
        /// <summary>
        /// <para>Name of the dictionary. Optional. If you do not specify a value, the default name is used.</para>
        /// </summary>
        [NameInMap("TermsName")]
        [Validation(Required=false)]
        public string TermsName { get; set; }

        /// <summary>
        /// <para>Unique identifier of the Alibaba Cloud Model Studio workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">workspace ID</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
