// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class OSSVolumeConfig : TeaModel {
        /// <summary>
        /// <para>The name of the OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-bucket</para>
        /// </summary>
        [NameInMap("bucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The path to mount within the bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/agent-workspace</para>
        /// </summary>
        [NameInMap("bucketPath")]
        [Validation(Required=false)]
        public string BucketPath { get; set; }

        /// <summary>
        /// <para>The OSS access endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oss-cn-hangzhou.aliyuncs.com">https://oss-cn-hangzhou.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>Specifies whether to mount the volume in read-only mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("readOnly")]
        [Validation(Required=false)]
        public bool? ReadOnly { get; set; }

    }

}
