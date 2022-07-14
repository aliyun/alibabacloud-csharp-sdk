// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListFpShotFilesResponseBody : TeaModel {
        [NameInMap("FpShotFileList")]
        [Validation(Required=false)]
        public ListFpShotFilesResponseBodyFpShotFileList FpShotFileList { get; set; }
        public class ListFpShotFilesResponseBodyFpShotFileList : TeaModel {
            [NameInMap("FpShotFile")]
            [Validation(Required=false)]
            public List<ListFpShotFilesResponseBodyFpShotFileListFpShotFile> FpShotFile { get; set; }
            public class ListFpShotFilesResponseBodyFpShotFileListFpShotFile : TeaModel {
                public string FileId { get; set; }
                public ListFpShotFilesResponseBodyFpShotFileListFpShotFileInputFile InputFile { get; set; }
                public class ListFpShotFilesResponseBodyFpShotFileListFpShotFileInputFile : TeaModel {
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
                public string PrimaryKey { get; set; }
            }
        };

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
