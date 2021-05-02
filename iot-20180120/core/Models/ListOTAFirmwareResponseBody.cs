// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListOTAFirmwareResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("FirmwareInfo")]
        [Validation(Required=false)]
        public ListOTAFirmwareResponseBodyFirmwareInfo FirmwareInfo { get; set; }
        public class ListOTAFirmwareResponseBodyFirmwareInfo : TeaModel {
            [NameInMap("SimpleFirmwareInfo")]
            [Validation(Required=false)]
            public List<ListOTAFirmwareResponseBodyFirmwareInfoSimpleFirmwareInfo> SimpleFirmwareInfo { get; set; }
            public class ListOTAFirmwareResponseBodyFirmwareInfoSimpleFirmwareInfo : TeaModel {
                public string FirmwareName { get; set; }
                public string FirmwareId { get; set; }
                public string SrcVersion { get; set; }
                public string DestVersion { get; set; }
                public string UtcCreate { get; set; }
                public string UtcModified { get; set; }
                public int? Status { get; set; }
                public string FirmwareDesc { get; set; }
                public string FirmwareSign { get; set; }
                public int? FirmwareSize { get; set; }
                public string ProductKey { get; set; }
                public string SignMethod { get; set; }
                public string ProductName { get; set; }
                public int? Type { get; set; }
                public string ModuleName { get; set; }
            }
        };

    }

}
