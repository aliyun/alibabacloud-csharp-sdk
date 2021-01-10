// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class UpdateServiceConfigurationRequest : TeaModel {
        [NameInMap("TaskItemQueueSize")]
        [Validation(Required=false)]
        public int? TaskItemQueueSize { get; set; }

        [NameInMap("ClientQueueSize")]
        [Validation(Required=false)]
        public int? ClientQueueSize { get; set; }

        [NameInMap("LiveRecordEveryOne")]
        [Validation(Required=false)]
        public bool? LiveRecordEveryOne { get; set; }

        [NameInMap("LiveRecordAll")]
        [Validation(Required=false)]
        public bool? LiveRecordAll { get; set; }

        [NameInMap("LiveRecordLayout")]
        [Validation(Required=false)]
        public int? LiveRecordLayout { get; set; }

        [NameInMap("LiveRecordTaskProfile")]
        [Validation(Required=false)]
        public string LiveRecordTaskProfile { get; set; }

        [NameInMap("LiveRecordMaxClient")]
        [Validation(Required=false)]
        public int? LiveRecordMaxClient { get; set; }

        [NameInMap("LiveRecordVideoResolution")]
        [Validation(Required=false)]
        public int? LiveRecordVideoResolution { get; set; }

    }

}
