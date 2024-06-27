// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateSampleRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("clientFileName")]
        [Validation(Required=false)]
        public string ClientFileName { get; set; }

        [NameInMap("clientPath")]
        [Validation(Required=false)]
        public string ClientPath { get; set; }

        [NameInMap("fileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        [NameInMap("sampleTag")]
        [Validation(Required=false)]
        public string SampleTag { get; set; }

        [NameInMap("sampleType")]
        [Validation(Required=false)]
        public string SampleType { get; set; }

        [NameInMap("sampleValues")]
        [Validation(Required=false)]
        public string SampleValues { get; set; }

        [NameInMap("uploadType")]
        [Validation(Required=false)]
        public string UploadType { get; set; }

    }

}
