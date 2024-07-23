// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListFpShotFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The media fingerprint files. For more information, see the &quot;FpShotFile&quot; section of the <a href="https://help.aliyun.com/document_detail/29251.html">Data types</a> topic.</para>
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
                /// <para>The ID of the video file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>41e6536e4f2250e2e9bf26cdea19****</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                /// <summary>
                /// <para>The information about the input file.</para>
                /// </summary>
                [NameInMap("InputFile")]
                [Validation(Required=false)]
                public ListFpShotFilesResponseBodyFpShotFileListFpShotFileInputFile InputFile { get; set; }
                public class ListFpShotFilesResponseBodyFpShotFileListFpShotFileInputFile : TeaModel {
                    /// <summary>
                    /// <para>The name of the OSS bucket in which the input file is stored.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example-bucket-****</para>
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// <para>The ID of the OSS region in which the input file resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss-cn-beijing</para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// <para>The name of the OSS object that is used as the input file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example-****.mp4</para>
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                }

                /// <summary>
                /// <para>The unique primary key of the input video.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fb712a6890464059b1b2ea7c8647****</para>
                /// </summary>
                [NameInMap("PrimaryKey")]
                [Validation(Required=false)]
                public string PrimaryKey { get; set; }

                /// <summary>
                /// <para>The time when the media fingerprint file was stored. The time follows the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time is displayed in UTC.</para>
                /// <remarks>
                /// <para>This parameter is available only in the China (Beijing), China (Hangzhou), and China (Shanghai) regions.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-08T23:32:56Z</para>
                /// </summary>
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
