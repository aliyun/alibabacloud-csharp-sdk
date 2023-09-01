// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeColdDataBasicInfoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeColdDataBasicInfoResponseBodyData Data { get; set; }
        public class DescribeColdDataBasicInfoResponseBodyData : TeaModel {
            [NameInMap("BackupSetCount")]
            [Validation(Required=false)]
            public int? BackupSetCount { get; set; }

            [NameInMap("BackupSetSpaceSize")]
            [Validation(Required=false)]
            public double? BackupSetSpaceSize { get; set; }

            [NameInMap("CloudProduct")]
            [Validation(Required=false)]
            public string CloudProduct { get; set; }

            [NameInMap("CurrentSpaceSize")]
            [Validation(Required=false)]
            public double? CurrentSpaceSize { get; set; }

            [NameInMap("DataRedundancyType")]
            [Validation(Required=false)]
            public string DataRedundancyType { get; set; }

            [NameInMap("EnableStatus")]
            [Validation(Required=false)]
            public bool? EnableStatus { get; set; }

            [NameInMap("ReadAccessNum")]
            [Validation(Required=false)]
            public long? ReadAccessNum { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("VolumeName")]
            [Validation(Required=false)]
            public string VolumeName { get; set; }

            [NameInMap("WriteAccessNum")]
            [Validation(Required=false)]
            public double? WriteAccessNum { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
