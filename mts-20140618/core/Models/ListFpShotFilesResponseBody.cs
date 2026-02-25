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
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                [NameInMap("InputFile")]
                [Validation(Required=false)]
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

                [NameInMap("PrimaryKey")]
                [Validation(Required=false)]
                public string PrimaryKey { get; set; }

                [NameInMap("StoreTime")]
                [Validation(Required=false)]
                public string StoreTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned value of NextPageToken is a pagination token, which can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ae0fd49c0840e14daf0d66a75b83****</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A13-BEF6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
