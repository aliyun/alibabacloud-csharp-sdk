// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class UpdateProjectShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of bindings per dataset. Valid values: 1 to 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("DatasetMaxBindCount")]
        [Validation(Required=false)]
        public long? DatasetMaxBindCount { get; set; }

        /// <summary>
        /// <para>The maximum number of metadata entities per dataset.</para>
        /// <remarks>
        /// <para>Reserved parameter. No actual limit is imposed during use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10000000000</para>
        /// </summary>
        [NameInMap("DatasetMaxEntityCount")]
        [Validation(Required=false)]
        public long? DatasetMaxEntityCount { get; set; }

        /// <summary>
        /// <para>The maximum number of files per dataset. Valid values: 1 to 100000000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000000</para>
        /// </summary>
        [NameInMap("DatasetMaxFileCount")]
        [Validation(Required=false)]
        public long? DatasetMaxFileCount { get; set; }

        /// <summary>
        /// <para>The maximum number of metadata relations per dataset.</para>
        /// <remarks>
        /// <para>Reserved parameter. No actual limit is imposed during use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100000000000</para>
        /// </summary>
        [NameInMap("DatasetMaxRelationCount")]
        [Validation(Required=false)]
        public long? DatasetMaxRelationCount { get; set; }

        /// <summary>
        /// <para>The maximum total size of files in each dataset. If the limit is exceeded, no more indexes can be added. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90000000000000000</para>
        /// </summary>
        [NameInMap("DatasetMaxTotalFileSize")]
        [Validation(Required=false)]
        public long? DatasetMaxTotalFileSize { get; set; }

        /// <summary>
        /// <para>The description of the project. The description must be 1 to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The maximum number of datasets in the project. Valid values: 1 to 1000000000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000000</para>
        /// </summary>
        [NameInMap("ProjectMaxDatasetCount")]
        [Validation(Required=false)]
        public long? ProjectMaxDatasetCount { get; set; }

        /// <summary>
        /// <para>The name of the project. For more information about how to obtain the project name, see <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The service role that is authorized for Intelligent Media Management (IMM) to access other cloud resources such as Object Storage Service (OSS).</para>
        /// <para>To use a custom service role, you can create a regular service role in the Resource Access Management (RAM) console and grant permissions to the role. For more information, see <a href="https://help.aliyun.com/document_detail/116800.html">Create a regular service role</a> and <a href="https://help.aliyun.com/document_detail/116147.html">Grant permissions to a RAM role</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunIMMDefaultRole</para>
        /// </summary>
        [NameInMap("ServiceRole")]
        [Validation(Required=false)]
        public string ServiceRole { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

        /// <summary>
        /// <para>The ID of the workflow template. For more information, see <a href="https://help.aliyun.com/document_detail/466304.html">Workflow templates and operators</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Official:ImageManagement</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
