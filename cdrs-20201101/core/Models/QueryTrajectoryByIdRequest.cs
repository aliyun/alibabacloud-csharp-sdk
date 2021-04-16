// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class QueryTrajectoryByIdRequest : TeaModel {
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("IdList")]
        [Validation(Required=false)]
        public List<QueryTrajectoryByIdRequestIdList> IdList { get; set; }
        public class QueryTrajectoryByIdRequestIdList : TeaModel {
            [NameInMap("IdValue")]
            [Validation(Required=false)]
            public string IdValue { get; set; }

            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

        }

        [NameInMap("DeviceList")]
        [Validation(Required=false)]
        public List<QueryTrajectoryByIdRequestDeviceList> DeviceList { get; set; }
        public class QueryTrajectoryByIdRequestDeviceList : TeaModel {
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

        }

    }

}
