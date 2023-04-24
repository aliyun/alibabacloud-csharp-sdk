// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataTrackOrderDetailResponseBody : TeaModel {
        [NameInMap("DataTrackOrderDetail")]
        [Validation(Required=false)]
        public GetDataTrackOrderDetailResponseBodyDataTrackOrderDetail DataTrackOrderDetail { get; set; }
        public class GetDataTrackOrderDetailResponseBodyDataTrackOrderDetail : TeaModel {
            [NameInMap("DatabaseSearchName")]
            [Validation(Required=false)]
            public string DatabaseSearchName { get; set; }

            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            [NameInMap("JobEndTime")]
            [Validation(Required=false)]
            public string JobEndTime { get; set; }

            [NameInMap("JobStartTime")]
            [Validation(Required=false)]
            public string JobStartTime { get; set; }

            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }

            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            [NameInMap("TableNames")]
            [Validation(Required=false)]
            public List<string> TableNames { get; set; }

            [NameInMap("TrackTypes")]
            [Validation(Required=false)]
            public List<string> TrackTypes { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
