// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ApplyFileUploadLeaseRequest : TeaModel {
        /// <summary>
        /// <para>The category type. If this parameter is not specified, the default value is UNSTRUCTURED. Valid values:</para>
        /// <para>UNSTRUCTURED: category, used for building <a href="https://help.aliyun.com/document_detail/2807740.html">knowledge base</a> scenarios.
        /// &lt;props=&quot;china&quot;&gt;
        /// SESSION_FILE: upload a file for agent application <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/file-interaction">session interaction</a>.</para>
        /// <remarks>
        /// <para>To create a new data table and upload data, use the Alibaba Cloud Model Studio console. This is not supported through the API.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>UNSTRUCTURED</para>
        /// </summary>
        [NameInMap("CategoryType")]
        [Validation(Required=false)]
        public string CategoryType { get; set; }

        /// <summary>
        /// <para>When uploading a file for building a <a href="https://help.aliyun.com/document_detail/2807740.html">knowledge base</a>:</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter specifies the name of the file to upload. The file name extension must match the file format. Supported formats:</para>
        /// <list type="bullet">
        /// <item><description>Documents (less than 150 MB): doc, docx, wps, ppt, pptx, xls, xlsx, md, txt, pdf, epub, mobi.</description></item>
        /// <item><description>Spreadsheets (10 MB or less recommended, 100,000 rows or less): xls, xlsx.</description></item>
        /// <item><description>Plain text (10 MB or less recommended): md, txt.</description></item>
        /// <item><description>Images (less than 20 MB, shortest side &gt; 15 px, longest side &lt; 8192 px, aspect ratio &lt; 50): png, jpg, jpeg, bmp, gif.</description></item>
        /// <item><description>Audio: aac, amr, flac, flv, m4a, mp3, mpeg, ogg, opus, wav, webm, wma.</description></item>
        /// <item><description>Video: mp4, mkv, avi, mov, wmv.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>The file name must be 4 to 128 characters in length. For other limits, see <a href="https://help.aliyun.com/document_detail/2880605.html">Knowledge base quotas and limits</a>.</para>
        /// <remarks>
        /// <para>To create a new data table and upload data, use the Alibaba Cloud Model Studio console. This is not supported through the API.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;china&quot;&gt;
        /// When uploading a file for agent application <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/file-interaction">session interaction</a>:</para>
        /// </description></item>
        /// <item><description><para>This parameter specifies the name of the file to upload. The file name extension must match the file format. Supported formats:</para>
        /// <list type="bullet">
        /// <item><description>Documents: doc, docx, wps, ppt, pptx, xls, xlsx, md, txt, pdf, epub, mobi.</description></item>
        /// <item><description>Images: png, jpg, jpeg, bmp, gif.</description></item>
        /// <item><description>Audio: aac, amr, flac, flv, m4a, mp3, mpeg, ogg, opus, wav, webm, wma.</description></item>
        /// <item><description>Video: mp4, mkv, avi, mov, wmv.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>The file name must be 4 to 128 characters in length.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ProductList.pdf</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The MD5 value of the file to upload. The server validates this parameter (validation is not currently enabled). Specify the correct value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19657c391f6c70bcea63c154d8606bb3</para>
        /// </summary>
        [NameInMap("Md5")]
        [Validation(Required=false)]
        public string Md5 { get; set; }

        /// <summary>
        /// <para>The size of the file to upload, in bytes. The server validates this parameter (validation is not currently enabled). Specify the correct value. Valid values: 1 B to 100 MB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("SizeInBytes")]
        [Validation(Required=false)]
        public string SizeInBytes { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>If you use <a href="https://www.alibabacloud.com/help/en/model-studio/configure-resources-in-private-network">Alibaba Cloud Model Studio secure storage</a> and need to generate a lease URL accessible only from the Alibaba Cloud internal network in the same region, set this parameter to true for improved security. If this parameter is not specified, the default value is false, which generates a publicly accessible lease URL.</para>
        /// <remarks>
        /// <para>If you have not activated Alibaba Cloud Model Studio secure storage, or are unsure whether you are using it, do not set this parameter to true (the upload will fail).</para>
        /// </remarks>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>If you use Alibaba Cloud Model Studio secure storage and need to generate a lease URL accessible only from the Alibaba Cloud internal network in the same region, set this parameter to true for improved security. If this parameter is not specified, the default value is false, which generates a publicly accessible lease URL.</para>
        /// <remarks>
        /// <para>If you have not activated Alibaba Cloud Model Studio secure storage, or are unsure whether you are using it, do not set this parameter to true (the upload will fail).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseInternalEndpoint")]
        [Validation(Required=false)]
        public bool? UseInternalEndpoint { get; set; }

    }

}
