// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class OSSVolumeConfig : TeaModel {
        /// <summary>
        /// <para>The name of the OSS bucket to mount as a storage volume.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sandbox-shared-data</para>
        /// </summary>
        [NameInMap("bucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The path prefix within the bucket to use as the mount source. If this parameter is not specified, the entire bucket is mounted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/workspace/</para>
        /// </summary>
        [NameInMap("bucketPath")]
        [Validation(Required=false)]
        public string BucketPath { get; set; }

        /// <summary>
        /// <para>The OSS service registration address used to access the bucket. Use an internal network address in the same region as the sandboxed container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cn-hangzhou-internal.aliyuncs.com</para>
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>Specifies whether the storage volume is mounted as read-only in the sandboxed container.</para>
        /// </summary>
        [NameInMap("readOnly")]
        [Validation(Required=false)]
        public bool? ReadOnly { get; set; }

    }

}
