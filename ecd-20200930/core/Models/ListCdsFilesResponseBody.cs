// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListCdsFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The execution result. A value of <c>success</c> indicates success. Otherwise, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The total number of entries in the file list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public string Count { get; set; }

        /// <summary>
        /// <para>The file list.</para>
        /// </summary>
        [NameInMap("FileModels")]
        [Validation(Required=false)]
        public List<ListCdsFilesResponseBodyFileModels> FileModels { get; set; }
        public class ListCdsFilesResponseBodyFileModels : TeaModel {
            /// <summary>
            /// <para>The file category. The cloud drive categorizes files based on file name extensions and MIME types. The main categories include <c>doc</c>, <c>image</c>, <c>audio</c>, and <c>video</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>image</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The content type of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>application/json</para>
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>The creation time. The time follows the ISO 8601 standard in the UTC format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-06T07:27:08Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The creator of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:demo_user01@cn-shanghai.148875033399">demo_user01@cn-shanghai.148875033399</a>****</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The file description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The download URL. The URL is valid for 15 minutes by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899ef****?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx">https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899ef****?Expires=xxx&amp;OSSAccessKeyId=xxx&amp;Signature=xxx</a></para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The file name extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("FileExtension")]
            [Validation(Required=false)]
            public string FileExtension { get; set; }

            /// <summary>
            /// <para>The file ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>637725ff2f63db8470984e6c92c692b87d52****</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The file path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>isv/1019236948660053/temp/</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>The file type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>file</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <para>The MD5 hash value of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>63c83ececb4e6926c51448fc5ecb****</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <para>The time when the file was last modified. The time follows the ISO 8601 standard in the UTC format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-06T07:27:08Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The modifier of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:demo_user02@cn-shanghai.148875033399">demo_user02@cn-shanghai.148875033399</a>****</para>
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SampleFile.pdf</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The time when the file was last opened. The time follows the ISO 8601 standard in the UTC format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-06T07:27:08Z</para>
            /// </summary>
            [NameInMap("OpenTime")]
            [Validation(Required=false)]
            public string OpenTime { get; set; }

            /// <summary>
            /// <para>The timestamp of the last time the file was opened.</para>
            /// 
            /// <b>Example:</b>
            /// <para>168951245231</para>
            /// </summary>
            [NameInMap("OpenTimeStamp")]
            [Validation(Required=false)]
            public long? OpenTimeStamp { get; set; }

            /// <summary>
            /// <para>The parent folder ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3343213ff2f63db8470984e6c92c3213dfdw****</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The SHA1 hash value of the data file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EA4942AA8761213890A5C386F88E6464D2C3****</para>
            /// </summary>
            [NameInMap("Sha1")]
            [Validation(Required=false)]
            public string Sha1 { get; set; }

            /// <summary>
            /// <para>The file size. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102400</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The thumbnail URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899ef****?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx">https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899ef****?Expires=xxx&amp;OSSAccessKeyId=xxx&amp;Signature=xxx</a></para>
            /// </summary>
            [NameInMap("Thumbnail")]
            [Validation(Required=false)]
            public string Thumbnail { get; set; }

        }

        /// <summary>
        /// <para>The error message. This parameter is not returned if Code is <c>success</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination token for the next query. If NextToken is empty, no more results exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aGN4YzAxQGNuLWhhbmd6aG91LjExNzU5NTMyNjgzMTQ1****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40D86754-20FD-53DC-A9B8-25F7FECC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
