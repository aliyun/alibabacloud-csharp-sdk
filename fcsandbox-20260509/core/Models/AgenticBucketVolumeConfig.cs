// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class AgenticBucketVolumeConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>absx9f61c8a-1311999136518149-cn-hangzhou-ab-apsr</para>
        /// </summary>
        [NameInMap("agenticBucket")]
        [Validation(Required=false)]
        public string AgenticBucket { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bs429pop1-1311999136518149-cn-hangzhou-bs-apsr</para>
        /// </summary>
        [NameInMap("bucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/test/</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("bucketPath")]
        [Validation(Required=false)]
        public string BucketPath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://oss-cn-hangzhou-internal.aliyuncs.com">https://oss-cn-hangzhou-internal.aliyuncs.com</a>&quot;</para>
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("readOnly")]
        [Validation(Required=false)]
        public bool? ReadOnly { get; set; }

    }

}
