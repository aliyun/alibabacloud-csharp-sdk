// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class CreateTaskDetail : TeaModel {
        /// <summary>
        /// <para>Administrators; defaults to the Creator.</para>
        /// </summary>
        [NameInMap("Admins")]
        [Validation(Required=false)]
        public CreateTaskDetailAdmins Admins { get; set; }
        public class CreateTaskDetailAdmins : TeaModel {
            /// <summary>
            /// <para>List of administrators.</para>
            /// </summary>
            [NameInMap("Users")]
            [Validation(Required=false)]
            public List<SimpleUser> Users { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether appending new data is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Supported</description></item>
        /// <item><description>false: Not supported</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowAppendData")]
        [Validation(Required=false)]
        public bool? AllowAppendData { get; set; }

        /// <summary>
        /// <para>Job assignment mechanism.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AssignConfig")]
        [Validation(Required=false)]
        public TaskAssginConfig AssignConfig { get; set; }

        /// <summary>
        /// <para>List of dataset configurations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DatasetProxyRelations")]
        [Validation(Required=false)]
        public List<DatasetProxyConfig> DatasetProxyRelations { get; set; }

        /// <summary>
        /// <para>Additional configuration. JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{  &quot;TaskCaptionType&quot;: &quot;DOC_LINK&quot;}</para>
        /// </summary>
        [NameInMap("Exif")]
        [Validation(Required=false)]
        public Dictionary<string, object> Exif { get; set; }

        /// <summary>
        /// <para>List of job labels.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <para>Job name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试任务202208101424</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>Template Configuration.</para>
        /// </summary>
        [NameInMap("TaskTemplateConfig")]
        [Validation(Required=false)]
        public TaskTemplateConfig TaskTemplateConfig { get; set; }

        /// <summary>
        /// <para>List of pipelines.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TaskWorkflow")]
        [Validation(Required=false)]
        public List<CreateTaskDetailTaskWorkflow> TaskWorkflow { get; set; }
        public class CreateTaskDetailTaskWorkflow : TeaModel {
            /// <summary>
            /// <para>Node name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MARK: Annotate.</description></item>
            /// <item><description>CHECK: Check.</description></item>
            /// <item><description>SAMPLING: Validate.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MARK</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

        }

        /// <summary>
        /// <para>Template ID. For more information, see <a href="https://help.aliyun.com/document_detail/454654.html">ListTemplates</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>152936***8342353920</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>Unique identifier (UUID), controlled by the business side.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16623***80757311</para>
        /// </summary>
        [NameInMap("UUID")]
        [Validation(Required=false)]
        public string UUID { get; set; }

        /// <summary>
        /// <para>Vote configuration</para>
        /// </summary>
        [NameInMap("VoteConfigs")]
        [Validation(Required=false)]
        public Dictionary<string, CreateTaskDetailVoteInfo> VoteConfigs { get; set; }

    }

}
