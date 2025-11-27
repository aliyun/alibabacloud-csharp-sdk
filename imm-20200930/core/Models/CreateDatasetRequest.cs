// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateDatasetRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of bindings per dataset. The range is 1~10, with a default value of 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("DatasetMaxBindCount")]
        [Validation(Required=false)]
        public long? DatasetMaxBindCount { get; set; }

        /// <summary>
        /// <para>The maximum number of metadata entities in each dataset. The default value is 10000000000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000000000</para>
        /// </summary>
        [NameInMap("DatasetMaxEntityCount")]
        [Validation(Required=false)]
        public long? DatasetMaxEntityCount { get; set; }

        /// <summary>
        /// <para>The maximum number of files in each dataset. The range is 1~100000000, with a default value of 100000000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000000</para>
        /// </summary>
        [NameInMap("DatasetMaxFileCount")]
        [Validation(Required=false)]
        public long? DatasetMaxFileCount { get; set; }

        /// <summary>
        /// <para>The maximum number of metadata relationships in each dataset. The default value is 100000000000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000000000</para>
        /// </summary>
        [NameInMap("DatasetMaxRelationCount")]
        [Validation(Required=false)]
        public long? DatasetMaxRelationCount { get; set; }

        /// <summary>
        /// <para>The maximum total size of files in each dataset. Once the limit is exceeded, no more indexes can be added. The default value is 90000000000000000, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90000000000000000</para>
        /// </summary>
        [NameInMap("DatasetMaxTotalFileSize")]
        [Validation(Required=false)]
        public long? DatasetMaxTotalFileSize { get; set; }

        /// <summary>
        /// <para>The name of the dataset, which must be unique under the same Project. Naming rules are as follows:</para>
        /// <list type="bullet">
        /// <item><description>Length should be 1~128 characters.</description></item>
        /// <item><description>Can only contain English letters, numbers, hyphens (-), and underscores (_).</description></item>
        /// <item><description>Must start with an English letter or underscore (_).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataset001</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>Description of the dataset. The length should be 1~256 English or Chinese characters, with a default value of empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the project. For more information on how to obtain it, see <a href="https://help.aliyun.com/document_detail/478153.html">Create Project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>Workflow template ID. For more information, see <a href="https://help.aliyun.com/document_detail/466304.html">Workflow Templates and Operators</a>. The default value is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Official:ImageManagement</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>Invalid parameter.</para>
        /// </summary>
        [NameInMap("WorkflowParameters")]
        [Validation(Required=false)]
        public List<WorkflowParameter> WorkflowParameters { get; set; }

    }

}
