// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class AddFilesFromAuthorizedOssRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cate_cdd11b1b79a74e8bbd675c356a91ee35xxxxxxxx</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNSTRUCTURED</para>
        /// </summary>
        [NameInMap("CategoryType")]
        [Validation(Required=false)]
        public string CategoryType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FileDetails")]
        [Validation(Required=false)]
        public List<AddFilesFromAuthorizedOssRequestFileDetails> FileDetails { get; set; }
        public class AddFilesFromAuthorizedOssRequestFileDetails : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>this_is_temp_xxxx.pdf</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root/path/this_is_temp_xxxx.pdf</para>
            /// </summary>
            [NameInMap("OssKey")]
            [Validation(Required=false)]
            public string OssKey { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bucketNamexxxxx</para>
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("OssRegionId")]
        [Validation(Required=false)]
        public string OssRegionId { get; set; }

        [NameInMap("OverWriteFileByOssKey")]
        [Validation(Required=false)]
        public bool? OverWriteFileByOssKey { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

    }

}
