// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alinlp20200629.Models
{
    public class ImportServiceDataV2Request : TeaModel {
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        [NameInMap("Documents")]
        [Validation(Required=false)]
        public List<ImportServiceDataV2RequestDocuments> Documents { get; set; }
        public class ImportServiceDataV2RequestDocuments : TeaModel {
            [NameInMap("BizParams")]
            [Validation(Required=false)]
            public Dictionary<string, string> BizParams { get; set; }

            [NameInMap("DocId")]
            [Validation(Required=false)]
            public string DocId { get; set; }

            [NameInMap("FileExtension")]
            [Validation(Required=false)]
            public string FileExtension { get; set; }

            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public long? ServiceId { get; set; }

    }

}
