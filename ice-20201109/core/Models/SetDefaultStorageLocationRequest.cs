// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SetDefaultStorageLocationRequest : TeaModel {
        /// <summary>
        /// <para>The name of the OSS bucket you created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-test-bucket</para>
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>When storageType is set to user_oss_bucket, temporary files are stored under this path. If path is empty or set to /, files are stored in the root directory.</para>
        /// </description></item>
        /// <item><description><para>This field does not take effect for VOD storage.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ims/dir</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>Storage type:</para>
        /// <list type="bullet">
        /// <item><description><para><b>vod_oss_bucket</b>: VOD-managed bucket.<br>
        /// Supports adding buckets managed by the VOD system or OSS buckets added within the VOD system. If no active buckets are available, you can add a new bucket in the ApsaraVideo VOD console. After activating ApsaraVideo VOD, the system assigns a storage address in each storage region. You must enable this address before use. For details, see <a href="https://help.aliyun.com/document_detail/86097.html">Manage Storage Buckets</a>.</para>
        /// </description></item>
        /// <item><description><para><b>user_oss_bucket</b>: User private bucket. Before adding an Object Storage address, you must activate Object Storage Service (OSS) and create a bucket. For details, see <a href="https://help.aliyun.com/document_detail/31885.html">Create a Bucket in the Console</a>.</para>
        /// </description></item>
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
