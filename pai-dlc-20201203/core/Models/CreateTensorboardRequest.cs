// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class CreateTensorboardRequest : TeaModel {
        /// <summary>
        /// DataSource Id
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public List<DataSourceItem> DataSources { get; set; }

        /// <summary>
        /// Tensorboard名称
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 任务Id
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// 最长运行时长
        /// </summary>
        [NameInMap("MaxRunningTimeMinutes")]
        [Validation(Required=false)]
        public long? MaxRunningTimeMinutes { get; set; }

        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// Summary 目录
        /// </summary>
        [NameInMap("SummaryPath")]
        [Validation(Required=false)]
        public string SummaryPath { get; set; }

        [NameInMap("SummaryRelativePath")]
        [Validation(Required=false)]
        public string SummaryRelativePath { get; set; }

        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
