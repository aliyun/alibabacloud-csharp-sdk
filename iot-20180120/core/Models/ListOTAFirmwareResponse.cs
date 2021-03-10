// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListOTAFirmwareResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=true)]
        public int? PageCount { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=true)]
        public int? CurrentPage { get; set; }

        [NameInMap("FirmwareInfo")]
        [Validation(Required=true)]
        public ListOTAFirmwareResponseFirmwareInfo FirmwareInfo { get; set; }
        public class ListOTAFirmwareResponseFirmwareInfo : TeaModel {
            [NameInMap("SimpleFirmwareInfo")]
            [Validation(Required=true)]
            public List<ListOTAFirmwareResponseFirmwareInfoSimpleFirmwareInfo> SimpleFirmwareInfo { get; set; }
            public class ListOTAFirmwareResponseFirmwareInfoSimpleFirmwareInfo : TeaModel {
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
                public string FirmwareUrl { get; set; }
                public string ProductKey { get; set; }
                public string SignMethod { get; set; }
                public string ProductName { get; set; }
                public int? Type { get; set; }
                public string ModuleName { get; set; }
            }
        };

    }

}
