// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetDatasetDocumentRequest : TeaModel {
        /// <summary>
        /// <para>Unique identifier of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public long? DatasetId { get; set; }

        /// <summary>
        /// <para>Name of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>数据集名称</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>User-defined unique ID of the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("DocId")]
        [Validation(Required=false)]
        public string DocId { get; set; }

        /// <summary>
        /// <para>Internal unique identifier of the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("DocUuid")]
        [Validation(Required=false)]
        public string DocUuid { get; set; }

        /// <summary>
        /// <para>List of fields to include in the response.</para>
        /// </summary>
        [NameInMap("IncludeFields")]
        [Validation(Required=false)]
        public List<string> IncludeFields { get; set; }

        /// <summary>
        /// <para>Unique identifier of your Alibaba Cloud Model Studio workspace. <a href="https://help.aliyun.com/document_detail/2782167.html">Get the workspace ID</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
