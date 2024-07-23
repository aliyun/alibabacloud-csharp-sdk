// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListCdsFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the operation. A value of success indicates that the operation is successful. If the operation failed, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public string Count { get; set; }

        /// <summary>
        /// <para>The files.</para>
        /// </summary>
        [NameInMap("FileModels")]
        [Validation(Required=false)]
        public List<ListCdsFilesResponseBodyFileModels> FileModels { get; set; }
        public class ListCdsFilesResponseBodyFileModels : TeaModel {
            /// <summary>
            /// <para>The file category. PDS categorizes files based on their suffixes and MIME types. The following major categories are included: doc, image, audio, and video.</para>
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
            /// <para>The time when the file was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-06T07:27:08Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The file creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user01</para>
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
            /// <para>The URL that is used to download the file. The download URL is valid for only 15 minutes. If the URL is expired, you can call the GetFile operation to obtain the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899ef****?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx">https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899ef****?Expires=xxx&amp;OSSAccessKeyId=xxx&amp;Signature=xxx</a></para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The filename extension.</para>
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
            /// <para>The MD5 value of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>63c83ececb4e6926c51448fc5ecb****</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <para>The time when the file was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-06T07:27:08Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The user who modified the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user02</para>
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fvt-appcenterp4qwa</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The time when the file was last opened.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-06T07:27:08Z</para>
            /// </summary>
            [NameInMap("OpenTime")]
            [Validation(Required=false)]
            public string OpenTime { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates the time when the file was last opened.</para>
            /// 
            /// <b>Example:</b>
            /// <para>168951245231</para>
            /// </summary>
            [NameInMap("OpenTimeStamp")]
            [Validation(Required=false)]
            public long? OpenTimeStamp { get; set; }

            /// <summary>
            /// <para>The ID of the parent folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3343213ff2f63db8470984e6c92c3213dfdw****</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// <para>The region ID You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the most recent region list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The SHA 1 file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EA4942AA8761213890A5C386F88E6464D2C3****</para>
            /// </summary>
            [NameInMap("Sha1")]
            [Validation(Required=false)]
            public string Sha1 { get; set; }

            /// <summary>
            /// <para>The file size. Unit: bits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102400</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The URL of the thumbnail.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899ef****?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx">https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899ef****?Expires=xxx&amp;OSSAccessKeyId=xxx&amp;Signature=xxx</a></para>
            /// </summary>
            [NameInMap("Thumbnail")]
            [Validation(Required=false)]
            public string Thumbnail { get; set; }

        }

        /// <summary>
        /// <para>The error message returned if the request failed. This parameter is empty if the value of Code is success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token used for the next query. If this parameter is empty, all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WyI2MzhmMjA2ZTFmZGZlZGVjZDk3OTRlNzVhZmIwMDFiZmM5NWQ3YTgwIiwibiIsIm4iLDEsLTEsMTY3MDMyNDMzNTAzMSwiNjM4ZjIwNmZjNDFkMzIwOTZmZWU0NGYxODkwY2I5ZjI0Mjg0NzM2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID. An ID is the unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40D86754-20FD-53DC-A9B8-25F7FECC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><!-- -->
        /// 
        /// <para>false</para>
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
