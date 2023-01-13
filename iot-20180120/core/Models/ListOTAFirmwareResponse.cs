// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListOTAFirmwareResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=true)]
        public int? CurrentPage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=true)]
        public int? PageCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("FirmwareInfo")]
        [Validation(Required=true)]
        public ListOTAFirmwareResponseFirmwareInfo FirmwareInfo { get; set; }
        public class ListOTAFirmwareResponseFirmwareInfo : TeaModel {
            [NameInMap("SimpleFirmwareInfo")]
            [Validation(Required=true)]
            public List<ListOTAFirmwareResponseFirmwareInfoSimpleFirmwareInfo> SimpleFirmwareInfo { get; set; }
            public class ListOTAFirmwareResponseFirmwareInfoSimpleFirmwareInfo : TeaModel {
                [NameInMap("DestVersion")]
                [Validation(Required=true)]
                public string DestVersion { get; set; }

                [NameInMap("FirmwareDesc")]
                [Validation(Required=true)]
                public string FirmwareDesc { get; set; }

                [NameInMap("FirmwareId")]
                [Validation(Required=true)]
                public string FirmwareId { get; set; }

                [NameInMap("FirmwareName")]
                [Validation(Required=true)]
                public string FirmwareName { get; set; }

                [NameInMap("FirmwareSign")]
                [Validation(Required=true)]
                public string FirmwareSign { get; set; }

                [NameInMap("FirmwareSize")]
                [Validation(Required=true)]
                public int? FirmwareSize { get; set; }

                [NameInMap("ModuleName")]
                [Validation(Required=true)]
                public string ModuleName { get; set; }

                [NameInMap("ProductKey")]
                [Validation(Required=true)]
                public string ProductKey { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=true)]
                public string ProductName { get; set; }

                [NameInMap("SignMethod")]
                [Validation(Required=true)]
                public string SignMethod { get; set; }

                [NameInMap("SrcVersion")]
                [Validation(Required=true)]
                public string SrcVersion { get; set; }

                [NameInMap("Status")]
                [Validation(Required=true)]
                public int? Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=true)]
                public int? Type { get; set; }

                [NameInMap("UtcCreate")]
                [Validation(Required=true)]
                public string UtcCreate { get; set; }

                [NameInMap("UtcModified")]
                [Validation(Required=true)]
                public string UtcModified { get; set; }

            }

        }

    }

}
