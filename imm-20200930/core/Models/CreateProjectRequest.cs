// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateProjectRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of bindings for each dataset. Valid values: 1 to 10. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("DatasetMaxBindCount")]
        [Validation(Required=false)]
        public long? DatasetMaxBindCount { get; set; }

        /// <summary>
        /// <para>The maximum number of metadata entities in each dataset. Default value: 10000000000.</para>
        /// <remarks>
        /// <para>This parameter is reserved for future use and does not impose actual limits.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10000000000</para>
        /// </summary>
        [NameInMap("DatasetMaxEntityCount")]
        [Validation(Required=false)]
        public long? DatasetMaxEntityCount { get; set; }

        /// <summary>
        /// <para>The maximum number of files in each dataset. Valid values: 1 to 100000000. Default value: 10000000000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000000</para>
        /// </summary>
        [NameInMap("DatasetMaxFileCount")]
        [Validation(Required=false)]
        public long? DatasetMaxFileCount { get; set; }

        /// <summary>
        /// <para>The maximum number of metadata relations in each dataset. Default value: 100000000000.</para>
        /// <remarks>
        /// <para>This parameter is reserved for future use and does not impose actual limits.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100000000000</para>
        /// </summary>
        [NameInMap("DatasetMaxRelationCount")]
        [Validation(Required=false)]
        public long? DatasetMaxRelationCount { get; set; }

        /// <summary>
        /// <para>The maximum total size of files in each dataset. If the limit is exceeded, no more indexes can be added. Unit: bytes. Default value: 90000000000000000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90000000000000000</para>
        /// </summary>
        [NameInMap("DatasetMaxTotalFileSize")]
        [Validation(Required=false)]
        public long? DatasetMaxTotalFileSize { get; set; }

        /// <summary>
        /// <para>The description of the project. The description must be 1 to 256 characters in length. Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The maximum number of datasets in the project. Valid values: 1 to 1000000000. Default value: 1000000000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000000</para>
        /// </summary>
        [NameInMap("ProjectMaxDatasetCount")]
        [Validation(Required=false)]
        public long? ProjectMaxDatasetCount { get; set; }

        /// <summary>
        /// <para>The name of the project. The naming rules are as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>The name must be 1 to 128 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The name can contain only letters, digits, hyphens (-), and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>The name must start with a letter or an underscore (_).</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The service role that is authorized to allow IMM to access other cloud resources such as Object Storage Service (OSS). Default value: <c>AliyunIMMDefaultRole</c>.</para>
        /// <para>To use a custom service role, you can create a standard service role in the Resource Access Management (RAM) console and grant permissions to the role. For more information, see <a href="https://help.aliyun.com/document_detail/477258.html">Grant permissions to a RAM role</a>.</para>
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
        public List<CreateProjectRequestTag> Tag { get; set; }
        public class CreateProjectRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the workflow template. Default value: empty. For more information, see <a href="https://help.aliyun.com/document_detail/466304.html">Workflow templates and operators</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Official:ImageManagement</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
