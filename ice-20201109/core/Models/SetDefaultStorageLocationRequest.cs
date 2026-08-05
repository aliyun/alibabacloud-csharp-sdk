// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SetDefaultStorageLocationRequest : TeaModel {
        /// <summary>
        /// <para>The name of the OSS bucket that you created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-test-bucket</para>
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>When StorageType is set to user_oss_bucket, temporary files are stored in this path. If the path is empty or set to /, files are stored in the root directory.</description></item>
        /// <item><description>This field does not take effect for VOD storage.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ims/dir</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>vod_oss_bucket: VOD-managed bucket. You can add VOD system buckets and your own OSS buckets that have been added to the VOD system. If no bucket is available, you can create a bucket in the ApsaraVideo VOD console. The ApsaraVideo VOD system assigns a storage address in each storage region. After you activate ApsaraVideo VOD, you must enable the address before you can use it. For more information, see <a href="https://help.aliyun.com/document_detail/86097.html">Manage storage buckets</a>.</description></item>
        /// <item><description>user_oss_bucket: user-owned private bucket. Before adding an OSS storage address, you must activate OSS and create a storage bucket. For more information, see <a href="https://help.aliyun.com/document_detail/31885.html">Create a bucket in the console</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>user_oss_bucket</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
