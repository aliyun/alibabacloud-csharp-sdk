// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Project : TeaModel {
        /// <summary>
        /// <para>The timestamp when the project was created. The timestamp is in the RFC3339Nano format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-29T14:50:13.011643661+08:00</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The current number of datasets in the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("DatasetCount")]
        [Validation(Required=false)]
        public long? DatasetCount { get; set; }

        /// <summary>
        /// <para>The maximum number of bindings that a dataset can have. Valid values: 1 to 10. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("DatasetMaxBindCount")]
        [Validation(Required=false)]
        public long? DatasetMaxBindCount { get; set; }

        /// <summary>
        /// <para>The maximum number of metadata entities in a dataset. Default value: 10000000000.</para>
        /// <remarks>
        /// <para> This parameter is reserved and does not actually apply a limit.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10000000000</para>
        /// </summary>
        [NameInMap("DatasetMaxEntityCount")]
        [Validation(Required=false)]
        public long? DatasetMaxEntityCount { get; set; }

        /// <summary>
        /// <para>The maximum number of files in a dataset. Valid values: 1 to 100000000. Default value: 100000000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000000</para>
        /// </summary>
        [NameInMap("DatasetMaxFileCount")]
        [Validation(Required=false)]
        public long? DatasetMaxFileCount { get; set; }

        /// <summary>
        /// <para>The maximum number of metadata relationships in a dataset. Default value: 100000000000.</para>
        /// <remarks>
        /// <para> This parameter is reserved and does not actually apply a limit.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100000000000</para>
        /// </summary>
        [NameInMap("DatasetMaxRelationCount")]
        [Validation(Required=false)]
        public long? DatasetMaxRelationCount { get; set; }

        /// <summary>
        /// <para>The maximum total file size for a dataset. If the total file size exceeds this limit, indexes can no longer be added. Default value: 90000000000000000. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90000000000000000</para>
        /// </summary>
        [NameInMap("DatasetMaxTotalFileSize")]
        [Validation(Required=false)]
        public long? DatasetMaxTotalFileSize { get; set; }

        /// <summary>
        /// <para>The project description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The maximum number of tasks that the project can process per second. This corresponds to the maximum number of operators that can run in parallel in the project. Default value: 100.</para>
        /// <list type="bullet">
        /// <item><description>If the number of synchronous tasks that run in parallel exceeds this limit, the task execution time will be extended until a timeout occurs.</description></item>
        /// <item><description>If the number of asynchronous tasks that run in parallel exceeds this limit, the tasks will be queued. This causes delayed task completion. If a task remains in the queue for longer than the specified time limit (usually dozens of seconds), the task will fail.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("EngineConcurrency")]
        [Validation(Required=false)]
        public long? EngineConcurrency { get; set; }

        /// <summary>
        /// <para>The current number of files in the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("FileCount")]
        [Validation(Required=false)]
        public long? FileCount { get; set; }

        /// <summary>
        /// <para>The maximum number of datasets that a project can contain. Valid values: 1 to 1000000000. Default value: 1000000000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000000</para>
        /// </summary>
        [NameInMap("ProjectMaxDatasetCount")]
        [Validation(Required=false)]
        public long? ProjectMaxDatasetCount { get; set; }

        /// <summary>
        /// <para>The name of the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The maximum number of requests that can be processed by the project per second. This corresponds to the maximum number of API operations that can be called in the project per second. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ProjectQueriesPerSecond")]
        [Validation(Required=false)]
        public long? ProjectQueriesPerSecond { get; set; }

        /// <summary>
        /// <para>The service role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunIMMDefaultRole</para>
        /// </summary>
        [NameInMap("ServiceRole")]
        [Validation(Required=false)]
        public string ServiceRole { get; set; }

        /// <summary>
        /// <para>The tag list.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ProjectTags> Tags { get; set; }
        public class ProjectTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>The ID of the workflow template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DefaultId</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The current total size of files in the project. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000</para>
        /// </summary>
        [NameInMap("TotalFileSize")]
        [Validation(Required=false)]
        public long? TotalFileSize { get; set; }

        /// <summary>
        /// <para>The timestamp when the project was last modified. The timestamp is in the RFC3339Nano format.</para>
        /// <remarks>
        /// <para> If a project is not modified after it is created, the timestamp when the project was created is the same as the timestamp when the project was last modified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-29T14:50:13.011643661+08:00</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
