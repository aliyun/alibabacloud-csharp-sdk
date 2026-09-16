// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class RegisterAIDBClusterCustomModelResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the registration is newly created. A value of false indicates that an existing registration was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Created")]
        [Validation(Required=false)]
        public bool? Created { get; set; }

        /// <summary>
        /// <para>The display name and initial client-facing invocation name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-qwen3</para>
        /// </summary>
        [NameInMap("DisplayModelName")]
        [Validation(Required=false)]
        public string DisplayModelName { get; set; }

        /// <summary>
        /// <para>The model registration ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public long? ModelId { get; set; }

        /// <summary>
        /// <para>The custom model registration key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen3-32B</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The normalized OSS path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/my-model-bucket/models/qwen3</para>
        /// </summary>
        [NameInMap("OssPath")]
        [Validation(Required=false)]
        public string OssPath { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>3AA6E0E4-1234-5678-90AB-1234567890AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
