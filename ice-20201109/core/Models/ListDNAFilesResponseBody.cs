// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListDNAFilesResponseBody : TeaModel {
        [NameInMap("FileList")]
        [Validation(Required=false)]
        public List<ListDNAFilesResponseBodyFileList> FileList { get; set; }
        public class ListDNAFilesResponseBodyFileList : TeaModel {
            [NameInMap("InputFile")]
            [Validation(Required=false)]
            public ListDNAFilesResponseBodyFileListInputFile InputFile { get; set; }
            public class ListDNAFilesResponseBodyFileListInputFile : TeaModel {
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("Object")]
                [Validation(Required=false)]
                public string Object { get; set; }

            }

            [NameInMap("PrimaryKey")]
            [Validation(Required=false)]
            public string PrimaryKey { get; set; }

        }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
