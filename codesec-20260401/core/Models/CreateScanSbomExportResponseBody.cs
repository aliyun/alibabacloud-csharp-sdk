// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class CreateScanSbomExportResponseBody : TeaModel {
        /// <summary>
        /// <para>短时签名的 GET URL（有效期见 <b><c>url_expires_at</c></b>），对象上已带 Content-Disposition</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://krypton-codesafe.oss-cn-hangzhou.aliyuncs.com/1609837153086803%2F1000108%2F1000893%2F1001080%2Fartifacts%2Fcyclonedx-json%2F1f8dc54097780e9c32941289d2aff5161df694b5bfb2d0aa3fe87fe72a751363.cdx.json?Expires=1789713461&OSSAccessKeyId=STS.NYDdfgGGhFqA4XBNu2EQebMeV&Signature=pnZPAML9CPKOIDyC4b1DK6gQmhs%3D&response-content-disposition=attachment%3B%20filename%3D%22test-sbom-cyclonedx.cdx.json%22%3B%20filename%2A%3DUTF-8%27%27test-sbom-cyclonedx.cdx.json&security-token=CAIS">https://krypton-codesafe.oss-cn-hangzhou.aliyuncs.com/1609837153086803%2F1000108%2F1000893%2F1001080%2Fartifacts%2Fcyclonedx-json%2F1f8dc54097780e9c32941289d2aff5161df694b5bfb2d0aa3fe87fe72a751363.cdx.json?Expires=1789713461&amp;OSSAccessKeyId=STS.NYDdfgGGhFqA4XBNu2EQebMeV&amp;Signature=pnZPAML9CPKOIDyC4b1DK6gQmhs%3D&amp;response-content-disposition=attachment%3B%20filename%3D%22test-sbom-cyclonedx.cdx.json%22%3B%20filename%2A%3DUTF-8%27%27test-sbom-cyclonedx.cdx.json&amp;security-token=CAIS</a>*</para>
        /// </summary>
        [NameInMap("downloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>最终生效的文件名（客户端指定或后端默认），已签进 <b><c>download_url</c></b> 的 <b><c>Content-Disposition</c></b>， 浏览器直连下载即按此落盘。</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-sbom-cyclonedx.cdx.json</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cyclonedx-json</para>
        /// </summary>
        [NameInMap("format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        /// <summary>
        /// <para>交付文件 MIME 类型</para>
        /// 
        /// <b>Example:</b>
        /// <para>application/vnd.cyclonedx+json</para>
        /// </summary>
        [NameInMap("mediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9A1F403F-0A85-5578-8B7C-55E3E9408659</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>交付文件本身（注入后重算）的摘要，供下载完整性校验；与源制品的 sha256 不同</para>
        /// 
        /// <b>Example:</b>
        /// <para>1f8dc54097780e9c32941289d2aff5161df694b5bfb2d0aa3fe87fe72a751363</para>
        /// </summary>
        [NameInMap("sha256")]
        [Validation(Required=false)]
        public string Sha256 { get; set; }

        /// <summary>
        /// <para>交付文件字节数</para>
        /// 
        /// <b>Example:</b>
        /// <para>791355</para>
        /// </summary>
        [NameInMap("sizeBytes")]
        [Validation(Required=false)]
        public long? SizeBytes { get; set; }

    }

}
