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
        /// <para> This is a precautionary setting that does not impose practical limitations.</para>
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
        /// <para>The maximum number of metadata relationships in each dataset. Default value: 100000000000.</para>
        /// <remarks>
        /// <para> This is a precautionary setting that does not impose practical limitations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100000000000</para>
        /// </summary>
        [NameInMap("DatasetMaxRelationCount")]
        [Validation(Required=false)]
        public long? DatasetMaxRelationCount { get; set; }

        /// <summary>
        /// <para>The maximum size of files in each dataset. If the maximum size is exceeded, no indexes can be added. Unit: bytes. Default value: 90000000000000000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90000000000000000</para>
        /// </summary>
        [NameInMap("DatasetMaxTotalFileSize")]
        [Validation(Required=false)]
        public long? DatasetMaxTotalFileSize { get; set; }

        /// <summary>
        /// <para>The description of the project. The description must be 1 to 256 characters in length. You can leave this parameter empty.</para>
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
        /// <para>The name of the project. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 1 to 128 characters in length</description></item>
        /// <item><description>and can contain only letters, digits, hyphens (-), and underscores (_).</description></item>
        /// <item><description>The name must start with a letter or an underscores (_).</description></item>
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
        /// <para>The name of the Resource Access Management (RAM) role. You must attach the RAM role to IMM to allow IMM to access other cloud resources, such as Object Storage Service (OSS). Default value: <c>AliyunIMMDefaultRole</c>.</para>
        /// <para>You can also create a custom role in the RAM console and grant the required permissions to the role based on your business requirements. For more information, see <a href="https://help.aliyun.com/document_detail/477257.html">Grant permissions to a RAM user</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunIMMDefaultRole</para>
        /// </summary>
        [NameInMap("ServiceRole")]
        [Validation(Required=false)]
        public string ServiceRole { get; set; }

        /// <summary>
        /// <para>The tags.</para>
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
        /// <para>The ID of the workflow template. You can leave this parameter empty. For more information, see <a href="https://help.aliyun.com/document_detail/466304.html">Workflow templates and operators</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Official:AllFunction</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
