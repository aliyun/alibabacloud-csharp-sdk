// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class AppMaterialFile : TeaModel {
        /// <summary>
        /// <para>The application instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250703155602000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The content type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image/png</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-11-03 02:05:01</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The deletion time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-11-03 02:05:01</para>
        /// </summary>
        [NameInMap("DeletedTime")]
        [Validation(Required=false)]
        public string DeletedTime { get; set; }

        /// <summary>
        /// <para>The folder ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddddwww</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The file ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d75e1e9693cc460da218419d67735567</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The file URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://demo-moshicloud-test.oss-cn-hangzhou-internal.aliyuncs.com/document/testcase/aliyun/api_case/pdf_angle90_page1.pdf">https://demo-moshicloud-test.oss-cn-hangzhou-internal.aliyuncs.com/document/testcase/aliyun/api_case/pdf_angle90_page1.pdf</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>The image height.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1280</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        /// <summary>
        /// <para>The file name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>文件名</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The file status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The storage size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23M</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public string StorageSize { get; set; }

        /// <summary>
        /// <para>The file name extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>png</para>
        /// </summary>
        [NameInMap("Suffix")]
        [Validation(Required=false)]
        public string Suffix { get; set; }

        /// <summary>
        /// <para>The file type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The image width.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1920</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
