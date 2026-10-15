// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class AgenticBucketVolumeConfig : TeaModel {
        /// <summary>
        /// <para>The name of the AgenticBucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace01</para>
        /// </summary>
        [NameInMap("agenticBucket")]
        [Validation(Required=false)]
        public string AgenticBucket { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sandbox-test</para>
        /// </summary>
        [NameInMap("bucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The path of the mounted OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("bucketPath")]
        [Validation(Required=false)]
        public string BucketPath { get; set; }

        /// <summary>
        /// <para>The OSS endpoint address.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oss-cn-hangzhou.aliyuncs.com">https://oss-cn-hangzhou.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>Specifies whether the mount directory has read-only access permissions after the OSS bucket is mounted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Read-only.</description></item>
        /// <item><description>false: Read and write.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("readOnly")]
        [Validation(Required=false)]
        public bool? ReadOnly { get; set; }

    }

}
