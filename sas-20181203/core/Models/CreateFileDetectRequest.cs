// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateFileDetectRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to decompress the archive for detection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: No.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not supported when <c>Type</c> is set to <c>6</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Decompress")]
        [Validation(Required=false)]
        public bool? Decompress { get; set; }

        /// <summary>
        /// <para>The maximum number of files that can be decompressed from an archive. The maximum value is 1000.</para>
        /// <para>This parameter is required if you set <c>Decompress</c> to <c>true</c>.</para>
        /// <remarks>
        /// <para>This parameter is not supported when <c>Type</c> is set to <c>6</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DecompressMaxFileCount")]
        [Validation(Required=false)]
        public int? DecompressMaxFileCount { get; set; }

        /// <summary>
        /// <para>The maximum number of decompression layers for nested archives. The maximum value is 5.</para>
        /// <para>This parameter is required if you set <c>Decompress</c> to <c>true</c>.</para>
        /// <remarks>
        /// <para>This parameter is not supported when <c>Type</c> is set to <c>6</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DecompressMaxLayer")]
        [Validation(Required=false)]
        public int? DecompressMaxLayer { get; set; }

        /// <summary>
        /// <para>The download link for the file. You can provide a public URL to trigger file detection without uploading the file.</para>
        /// <remarks>
        /// <para>Skill archives can be submitted only by providing a download link. Therefore, this parameter is required when <c>Type</c> is set to <c>6</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxxxxxxx.oss-cn-hangzhou-1.aliyuncs.com/xxxxx/xxxxxxxxxxxxxx?Expires=1671448125&OSSAccessKeyId=xxx">https://xxxxxxxx.oss-cn-hangzhou-1.aliyuncs.com/xxxxx/xxxxxxxxxxxxxx?Expires=1671448125&amp;OSSAccessKeyId=xxx</a></para>
        /// </summary>
        [NameInMap("DownloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>The unique identifier of the file.</para>
        /// <para>This parameter is required if <c>Type</c> is <c>0</c>. Its value must be the MD5 or SHA-256 hash of the file.</para>
        /// <para>If you set <c>Type</c> to <c>6</c>, you do not need to specify this parameter. The operation returns the file\&quot;s unique identifier in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a212417e65c26ff133cfff28f6c****</para>
        /// </summary>
        [NameInMap("HashKey")]
        [Validation(Required=false)]
        public string HashKey { get; set; }

        /// <summary>
        /// <para>The storage key of the file in an Object Storage Service (OSS) bucket.</para>
        /// <para>If you submit the file by using the <c>DownloadUrl</c> parameter, you can leave this parameter empty. To obtain the value of this parameter, call the <a href="~~CreateFileDetectUploadUrl~~">CreateFileDetectUploadUrl</a> operation.</para>
        /// <remarks>
        /// <para>This parameter is not supported when <c>Type</c> is set to <c>6</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1/2022/06/23/15/41/16559701077444693a0c6-33b2-4cc2-a99f-9f38b8b8****</para>
        /// </summary>
        [NameInMap("OssKey")]
        [Validation(Required=false)]
        public string OssKey { get; set; }

        /// <summary>
        /// <para>The IP address of the source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>115.213.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The type of the file to detect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Malicious file detection</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: Skill archive detection</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
