// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateLocationDateClusteringTaskRequest : TeaModel {
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        [NameInMap("DateOptions")]
        [Validation(Required=false)]
        public CreateLocationDateClusteringTaskRequestDateOptions DateOptions { get; set; }
        public class CreateLocationDateClusteringTaskRequestDateOptions : TeaModel {
            [NameInMap("GapDays")]
            [Validation(Required=false)]
            public long? GapDays { get; set; }

            [NameInMap("MaxDays")]
            [Validation(Required=false)]
            public long? MaxDays { get; set; }

            [NameInMap("MinDays")]
            [Validation(Required=false)]
            public long? MinDays { get; set; }

        }

        [NameInMap("LocationOptions")]
        [Validation(Required=false)]
        public CreateLocationDateClusteringTaskRequestLocationOptions LocationOptions { get; set; }
        public class CreateLocationDateClusteringTaskRequestLocationOptions : TeaModel {
            [NameInMap("LocationDateClusterLevels")]
            [Validation(Required=false)]
            public List<string> LocationDateClusterLevels { get; set; }

        }

        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
