// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class AddFilesFromAuthorizedOssShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the target category for file import. This is the <c>CategoryId</c> returned by the AddCategory operation. You can also obtain the category ID from the &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a> - Files tab&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> - Files tab by clicking the ID icon next to the category name. You can also pass in default, which uses the system-created &quot;Default Category&quot;.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cate_cdd11b1b79a74e8bbd675c356a91ee35xxxxxxxx</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>Category type. Optional. The default value is UNSTRUCTURED. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>UNSTRUCTURED: Category used for building knowledge base scenarios.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>This operation does not support importing SESSION_FILE used for agent application <a href="https://help.aliyun.com/zh/model-studio/user-guide/file-interaction">session interaction</a>. Please use the <b>AddFile</b> operation to upload SESSION_FILE from local.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNSTRUCTURED</para>
        /// </summary>
        [NameInMap("CategoryType")]
        [Validation(Required=false)]
        public string CategoryType { get; set; }

        /// <summary>
        /// <para>The list of files to import. Up to 10 files can be uploaded at a time.</para>
        /// <remarks>
        /// <para>Up to 10 files can be uploaded at a time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FileDetails")]
        [Validation(Required=false)]
        public string FileDetailsShrink { get; set; }

        /// <summary>
        /// <para>The OSS Bucket name. For details, see <a href="https://help.aliyun.com/document_detail/177682.html">Buckets</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bucketNamexxxxx</para>
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <para>The region ID of the OSS Bucket. For how to obtain it, see <a href="https://help.aliyun.com/document_detail/31837.html">OSS regions and endpoints</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("OssRegionId")]
        [Validation(Required=false)]
        public string OssRegionId { get; set; }

        /// <summary>
        /// <para>Whether to overwrite the same file in the category by OssKey. The default value is false, meaning no overwrite.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OverWriteFileByOssKey")]
        [Validation(Required=false)]
        public bool? OverWriteFileByOssKey { get; set; }

        /// <summary>
        /// <para>The list of tags associated with the file. The default is empty, meaning the file is not associated with any tags. Up to 10 tags can be passed in.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
