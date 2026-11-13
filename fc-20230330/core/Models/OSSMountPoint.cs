// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class OSSMountPoint : TeaModel {
        /// <summary>
        /// <para>The mounted OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-bucket</para>
        /// </summary>
        [NameInMap("bucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The mounted OSS bucket path.</para>
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
        /// <para>The mount directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/mnt/dir</para>
        /// </summary>
        [NameInMap("mountDir")]
        [Validation(Required=false)]
        public string MountDir { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow mounting OSS to a local directory that contains existing files or subdirectories.</para>
        /// </summary>
        [NameInMap("nonempty")]
        [Validation(Required=false)]
        public bool? Nonempty { get; set; }

        /// <summary>
        /// <para>Specifies whether the mount is read-only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("readOnly")]
        [Validation(Required=false)]
        public bool? ReadOnly { get; set; }

    }

}
