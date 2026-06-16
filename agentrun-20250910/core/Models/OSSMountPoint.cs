// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class OSSMountPoint : TeaModel {
        /// <summary>
        /// <para>The OSS bucket to mount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-bucket</para>
        /// </summary>
        [NameInMap("bucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The directory path within the bucket to mount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/my-dir</para>
        /// </summary>
        [NameInMap("bucketPath")]
        [Validation(Required=false)]
        public string BucketPath { get; set; }

        /// <summary>
        /// <para>The OSS endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://oss-cn-shanghai.aliyuncs.com">http://oss-cn-shanghai.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The local directory path where the bucket is mounted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/mnt/dir</para>
        /// </summary>
        [NameInMap("mountDir")]
        [Validation(Required=false)]
        public string MountDir { get; set; }

        /// <summary>
        /// <para>Specifies whether to mount the OSS bucket as read-only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("readOnly")]
        [Validation(Required=false)]
        public bool? ReadOnly { get; set; }

    }

}
