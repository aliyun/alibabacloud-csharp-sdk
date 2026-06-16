// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class UploadMaterialFileRequest : TeaModel {
        /// <summary>
        /// <para>The business ID of the application instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20250801152639000005</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The ID of the parent folder.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68157a0a-769a-4364-bbdc-a0e2cf3d5ad</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The path of the file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://docmind-api-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/4a7f_209934244261306272_14fd429b731245a79f291c64acf3ac77">http://docmind-api-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/4a7f_209934244261306272_14fd429b731245a79f291c64acf3ac77</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>The name of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试文件</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
