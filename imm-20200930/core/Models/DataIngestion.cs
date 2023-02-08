// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DataIngestion : TeaModel {
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public List<DataIngestionActions> Actions { get; set; }
        public class DataIngestionActions : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<string> Parameters { get; set; }

        }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("Error")]
        [Validation(Required=false)]
        public string Error { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Input")]
        [Validation(Required=false)]
        public Input Input { get; set; }

        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("Notification")]
        [Validation(Required=false)]
        public DataIngestionNotification Notification { get; set; }
        public class DataIngestionNotification : TeaModel {
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

        }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("Statistic")]
        [Validation(Required=false)]
        public DataIngestionStatistic Statistic { get; set; }
        public class DataIngestionStatistic : TeaModel {
            [NameInMap("SubmitFailure")]
            [Validation(Required=false)]
            public long? SubmitFailure { get; set; }

            [NameInMap("SubmitSuccess")]
            [Validation(Required=false)]
            public long? SubmitSuccess { get; set; }

        }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
