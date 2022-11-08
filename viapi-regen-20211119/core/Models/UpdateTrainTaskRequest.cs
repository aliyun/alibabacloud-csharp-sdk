// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class UpdateTrainTaskRequest : TeaModel {
        [NameInMap("AdvancedParameters")]
        [Validation(Required=false)]
        public string AdvancedParameters { get; set; }

        [NameInMap("DatasetIds")]
        [Validation(Required=false)]
        public string DatasetIds { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("LabelIds")]
        [Validation(Required=false)]
        public string LabelIds { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PreTrainTaskFlag")]
        [Validation(Required=false)]
        public bool? PreTrainTaskFlag { get; set; }

        [NameInMap("PreTrainTaskId")]
        [Validation(Required=false)]
        public long? PreTrainTaskId { get; set; }

        [NameInMap("TrainMode")]
        [Validation(Required=false)]
        public string TrainMode { get; set; }

    }

}
