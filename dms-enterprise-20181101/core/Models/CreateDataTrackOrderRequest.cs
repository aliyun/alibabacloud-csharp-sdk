// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDataTrackOrderRequest : TeaModel {
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateDataTrackOrderRequestParam Param { get; set; }
        public class CreateDataTrackOrderRequestParam : TeaModel {
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public string DbId { get; set; }

            [NameInMap("JobEndTime")]
            [Validation(Required=false)]
            public string JobEndTime { get; set; }

            [NameInMap("JobStartTime")]
            [Validation(Required=false)]
            public string JobStartTime { get; set; }

            [NameInMap("TableNames")]
            [Validation(Required=false)]
            public List<string> TableNames { get; set; }

            [NameInMap("TrackTypes")]
            [Validation(Required=false)]
            public List<string> TrackTypes { get; set; }

        }

        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<string> RelatedUserList { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
