// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class OssConfiguration : TeaModel {
        /// <summary>
        /// <para>The name of the OSS bucket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a-test-oss</para>
        /// </summary>
        [NameInMap("bucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The mount point for the OSS bucket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/mnt/oss1</para>
        /// </summary>
        [NameInMap("mountPoint")]
        [Validation(Required=false)]
        public string MountPoint { get; set; }

        /// <summary>
        /// <para>The access permission for the mount point.</para>
        /// 
        /// <b>Example:</b>
        /// <para>READ_WRITE</para>
        /// </summary>
        [NameInMap("permission")]
        [Validation(Required=false)]
        public string Permission { get; set; }

        /// <summary>
        /// <para>The object prefix or path within the OSS bucket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <para>The region where the OSS bucket is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ch-hangzhou</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
