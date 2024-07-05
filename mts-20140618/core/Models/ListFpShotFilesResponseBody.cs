// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListFpShotFilesResponseBody : TeaModel {
        /// <summary>
        /// The media fingerprint files. For more information, see the "FpShotFile" section of the [Data types](https://help.aliyun.com/document_detail/29251.html) topic.
        /// </summary>
        [NameInMap("FpShotFileList")]
        [Validation(Required=false)]
        public ListFpShotFilesResponseBodyFpShotFileList FpShotFileList { get; set; }
        public class ListFpShotFilesResponseBodyFpShotFileList : TeaModel {
            [NameInMap("FpShotFile")]
            [Validation(Required=false)]
            public List<ListFpShotFilesResponseBodyFpShotFileListFpShotFile> FpShotFile { get; set; }
            public class ListFpShotFilesResponseBodyFpShotFileListFpShotFile : TeaModel {
                /// <summary>
                /// The ID of the video file.
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                /// <summary>
                /// The information about the input file.
                /// </summary>
                [NameInMap("InputFile")]
                [Validation(Required=false)]
                public ListFpShotFilesResponseBodyFpShotFileListFpShotFileInputFile InputFile { get; set; }
                public class ListFpShotFilesResponseBodyFpShotFileListFpShotFileInputFile : TeaModel {
                    /// <summary>
                    /// The name of the OSS bucket in which the input file is stored.
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// The ID of the OSS region in which the input file resides.
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// The name of the OSS object that is used as the input file.
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                }

                /// <summary>
                /// The unique primary key of the input video.
                /// </summary>
                [NameInMap("PrimaryKey")]
                [Validation(Required=false)]
                public string PrimaryKey { get; set; }

                /// <summary>
                /// The time when the media fingerprint file was stored. The time follows the ISO 8601 standard in the `YYYY-MM-DDThh:mm:ssZ` format. The time is displayed in UTC.
                /// 
                /// > This parameter is available only in the China (Beijing), China (Hangzhou), and China (Shanghai) regions.
                /// </summary>
                [NameInMap("StoreTime")]
                [Validation(Required=false)]
                public string StoreTime { get; set; }

            }

        }

        /// <summary>
        /// The returned value of NextPageToken is a pagination token, which can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
