/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class CreateTaskDetail : TeaModel {
        [NameInMap("Admins")]
        [Validation(Required=false)]
        public CreateTaskDetailAdmins Admins { get; set; }
        public class CreateTaskDetailAdmins : TeaModel {
            [NameInMap("Users")]
            [Validation(Required=false)]
            public List<SimpleUser> Users { get; set; }

        }

        [NameInMap("AllowAppendData")]
        [Validation(Required=false)]
        public bool? AllowAppendData { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AssignConfig")]
        [Validation(Required=false)]
        public TaskAssginConfig AssignConfig { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DatasetProxyRelations")]
        [Validation(Required=false)]
        public List<DatasetProxyConfig> DatasetProxyRelations { get; set; }

        [NameInMap("Exif")]
        [Validation(Required=false)]
        public Dictionary<string, object> Exif { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        [NameInMap("TaskTemplateConfig")]
        [Validation(Required=false)]
        public TaskTemplateConfig TaskTemplateConfig { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskWorkflow")]
        [Validation(Required=false)]
        public List<CreateTaskDetailTaskWorkflow> TaskWorkflow { get; set; }
        public class CreateTaskDetailTaskWorkflow : TeaModel {
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("UUID")]
        [Validation(Required=false)]
        public string UUID { get; set; }

        [NameInMap("VoteConfigs")]
        [Validation(Required=false)]
        public Dictionary<string, CreateTaskDetailVoteInfo> VoteConfigs { get; set; }

    }

}
