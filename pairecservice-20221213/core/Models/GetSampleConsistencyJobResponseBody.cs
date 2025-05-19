// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetSampleConsistencyJobResponseBody : TeaModel {
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        [NameInMap("EasModelServiceName")]
        [Validation(Required=false)]
        public string EasModelServiceName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("FeatureSaveResourceId")]
        [Validation(Required=false)]
        public string FeatureSaveResourceId { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("ItemIdField")]
        [Validation(Required=false)]
        public string ItemIdField { get; set; }

        [NameInMap("Logs")]
        [Validation(Required=false)]
        public string Logs { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PartitionField")]
        [Validation(Required=false)]
        public string PartitionField { get; set; }

        [NameInMap("PartitionFieldFormat")]
        [Validation(Required=false)]
        public string PartitionFieldFormat { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RequestIdField")]
        [Validation(Required=false)]
        public string RequestIdField { get; set; }

        [NameInMap("SampleConsistencyJobId")]
        [Validation(Required=false)]
        public string SampleConsistencyJobId { get; set; }

        [NameInMap("SampleRate")]
        [Validation(Required=false)]
        public string SampleRate { get; set; }

        [NameInMap("SampleTableName")]
        [Validation(Required=false)]
        public string SampleTableName { get; set; }

        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        [NameInMap("SceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UserIdField")]
        [Validation(Required=false)]
        public string UserIdField { get; set; }

    }

}
