// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebOSSMountPoint : TeaModel {
        /// <summary>
        /// <para>The name of the bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gcx-pic-test</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The storage path in an OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>billing-2023-11-06_17:30:18-rn7wG8</para>
        /// </summary>
        [NameInMap("BucketPath")]
        [Validation(Required=false)]
        public string BucketPath { get; set; }

        /// <summary>
        /// <para>The local mount directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/k8s-prod/oms-api-yy-prod/log</para>
        /// </summary>
        [NameInMap("MountDir")]
        [Validation(Required=false)]
        public string MountDir { get; set; }

        /// <summary>
        /// <para>Specifies whether it is read-only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ReadOnly")]
        [Validation(Required=false)]
        public bool? ReadOnly { get; set; }

    }

}
