// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListCallDetailRecordsRequest : TeaModel {
        [NameInMap("ContactDisposition")]
        [Validation(Required=false)]
        public string ContactDisposition { get; set; }

        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        [NameInMap("ContactType")]
        [Validation(Required=false)]
        public string ContactType { get; set; }

        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("StopTime")]
        [Validation(Required=false)]
        public long? StopTime { get; set; }

        [NameInMap("WithRecording")]
        [Validation(Required=false)]
        public bool? WithRecording { get; set; }

    }

}
