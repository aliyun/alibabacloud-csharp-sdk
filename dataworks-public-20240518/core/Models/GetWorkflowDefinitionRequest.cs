// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetWorkflowDefinitionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the workflow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>860438872620113XXXX</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>查询结果是否包含工作流内部节点的脚本内容（对于内容较多的节点，可能存在较长的网络传输延时）。</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeScriptContent")]
        [Validation(Required=false)]
        public bool? IncludeScriptContent { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to query the ID.</para>
        /// <para>You must configure this parameter to specify the DataWorks workspace to which the API operation is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
