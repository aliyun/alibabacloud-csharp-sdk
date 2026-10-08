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
        /// <remarks>
        /// <para>This field is of type Long in SDK versions earlier than 8.0.0 and String in SDK version 8.0.0 and later. This change does not affect normal SDK usage; the parameter is still returned according to the type defined in the SDK. Upgrading the SDK across version 8.0.0 may cause compilation failures due to the type change. In this case, manually update the data type.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>860438872620****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Specifies whether the query result includes the script content of internal nodes in the workflow definition. For nodes with large content, this may cause high network transmission latency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeScriptContent")]
        [Validation(Required=false)]
        public bool? IncludeScriptContent { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the workspace management page to query the ID.</para>
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
