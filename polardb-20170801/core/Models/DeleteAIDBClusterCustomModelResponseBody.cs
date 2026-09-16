// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DeleteAIDBClusterCustomModelResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the deletion was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Deleted")]
        [Validation(Required=false)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// <para>The ID of the deleted model registration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public long? ModelId { get; set; }

        /// <summary>
        /// <para>The key of the deleted custom model registration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen3-32B</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

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
