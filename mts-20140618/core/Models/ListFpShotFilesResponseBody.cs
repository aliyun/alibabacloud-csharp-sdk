// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListFpShotFilesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("FpShotFileList")]
        [Validation(Required=false)]
        public ListFpShotFilesResponseBodyFpShotFileList FpShotFileList { get; set; }
        public class ListFpShotFilesResponseBodyFpShotFileList : TeaModel {
            [NameInMap("FpShotFile")]
            [Validation(Required=false)]
            public List<ListFpShotFilesResponseBodyFpShotFileListFpShotFile> FpShotFile { get; set; }
            public class ListFpShotFilesResponseBodyFpShotFileListFpShotFile : TeaModel {
                public string PrimaryKey { get; set; }
                public ListFpShotFilesResponseBodyFpShotFileListFpShotFileInputFile InputFile { get; set; }
                public class ListFpShotFilesResponseBodyFpShotFileListFpShotFileInputFile : TeaModel {
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                }
                public string FileId { get; set; }
            }
        };

    }

}
