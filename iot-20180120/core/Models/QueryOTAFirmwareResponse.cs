// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryOTAFirmwareResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("FirmwareInfo")]
        [Validation(Required=true)]
        public QueryOTAFirmwareResponseFirmwareInfo FirmwareInfo { get; set; }
        public class QueryOTAFirmwareResponseFirmwareInfo : TeaModel {
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

            [NameInMap("FirmwareUrl")]
            [Validation(Required=true)]
            public string FirmwareUrl { get; set; }

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

            [NameInMap("Udi")]
            [Validation(Required=true)]
            public string Udi { get; set; }

            [NameInMap("UtcCreate")]
            [Validation(Required=true)]
            public string UtcCreate { get; set; }

            [NameInMap("UtcModified")]
            [Validation(Required=true)]
            public string UtcModified { get; set; }

            [NameInMap("VerifyProgress")]
            [Validation(Required=true)]
            public int? VerifyProgress { get; set; }

            [NameInMap("MultiFiles")]
            [Validation(Required=true)]
            public List<QueryOTAFirmwareResponseFirmwareInfoMultiFiles> MultiFiles { get; set; }
            public class QueryOTAFirmwareResponseFirmwareInfoMultiFiles : TeaModel {
                [NameInMap("FileMd5")]
                [Validation(Required=true)]
                public string FileMd5 { get; set; }

                [NameInMap("Name")]
                [Validation(Required=true)]
                public string Name { get; set; }

                [NameInMap("SignValue")]
                [Validation(Required=true)]
                public string SignValue { get; set; }

                [NameInMap("Size")]
                [Validation(Required=true)]
                public int? Size { get; set; }

                [NameInMap("Url")]
                [Validation(Required=true)]
                public string Url { get; set; }

            }

        }

    }

}
