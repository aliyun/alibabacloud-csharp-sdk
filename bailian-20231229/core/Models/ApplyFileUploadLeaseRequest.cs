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
        /// <para>UNSTRUCTURED: category for building <a href="https://help.aliyun.com/document_detail/2807740.html">knowledge base</a> scenarios.
        /// &lt;props=&quot;china&quot;&gt;
        /// SESSION_FILE: upload files for agent application <a href="https://help.aliyun.com/zh/model-studio/user-guide/file-interaction">conversational interactions</a>.</para>
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
        /// <para>When uploading files for building a <a href="https://help.aliyun.com/document_detail/2807740.html">knowledge base</a>:</para>
        /// <list type="bullet">
        /// <item><description><para>This field represents the name of the uploaded file. The file name must include the file format extension. Supported formats:</para>
        /// <list type="bullet">
        /// <item><description>Documents (less than 150 MB): doc, docx, wps, ppt, pptx, xls, xlsx, md, txt, pdf, epub, mobi.</description></item>
        /// <item><description>Spreadsheets (recommended within 10 MB and 100,000 rows): xls, xlsx.</description></item>
        /// <item><description>Plain text (recommended not to exceed 10 MB): md, txt.</description></item>
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
        /// When uploading files for agent application <a href="https://help.aliyun.com/zh/model-studio/user-guide/file-interaction">conversational interactions</a>:</para>
        /// </description></item>
        /// <item><description><para>This field represents the name of the uploaded file. The file name must include the file format extension. Supported formats:</para>
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
        /// <para>XXXX产品清单.pdf</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The MD5 value of the uploaded file. The server will verify this field (currently not enabled). Please fill in the correct value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19657c391f6c70bcea63c154d8606bb3</para>
        /// </summary>
        [NameInMap("Md5")]
        [Validation(Required=false)]
        public string Md5 { get; set; }

        /// <summary>
        /// <para>The size of the uploaded file in bytes. The server will verify this field (currently not enabled). Please fill in the correct value. Valid values: 1 B to 100 MB.</para>
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
        /// <para>If you have enabled <a href="https://help.aliyun.com/zh/model-studio/configure-resources-in-private-network">Alibaba Cloud Model Studio secure storage</a> and need to generate a lease URL that is only accessible from the Alibaba Cloud internal network in the same region, you can set this parameter to true to improve security. If this parameter is not specified, the default value is false, which generates a publicly accessible lease URL.</para>
        /// <remarks>
        /// <para>If you have not enabled Alibaba Cloud Model Studio secure storage, or are unsure whether you are using it, do not set this parameter to true (upload will fail).</para>
        /// </remarks>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>If you have enabled Alibaba Cloud Model Studio secure storage and need to generate a lease URL that is only accessible from the Alibaba Cloud internal network in the same region, you can set this parameter to true to improve security. If this parameter is not specified, the default value is false, which generates a publicly accessible lease URL.</para>
        /// <remarks>
        /// <para>If you have not enabled Alibaba Cloud Model Studio secure storage, or are unsure whether you are using it, do not set this parameter to true (upload will fail).</para>
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
