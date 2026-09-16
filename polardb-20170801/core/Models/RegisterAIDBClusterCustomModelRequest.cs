// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class RegisterAIDBClusterCustomModelRequest : TeaModel {
        /// <summary>
        /// <para>The name of the OSS bucket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-model-bucket</para>
        /// </summary>
        [NameInMap("CustomOssBucketName")]
        [Validation(Required=false)]
        public string CustomOssBucketName { get; set; }

        /// <summary>
        /// <para>The model path within the OSS bucket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>models/qwen3</para>
        /// </summary>
        [NameInMap("CustomOssBucketPath")]
        [Validation(Required=false)]
        public string CustomOssBucketPath { get; set; }

        /// <summary>
        /// <para>The ID of the PolarDB AI 3.0 logical instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pm-2ze4x2mwo81knj08a</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The display name shown in the candidate list and the initial client-facing invocation name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-qwen3</para>
        /// </summary>
        [NameInMap("DisplayModelName")]
        [Validation(Required=false)]
        public string DisplayModelName { get; set; }

        /// <summary>
        /// <para>The custom model registration key and model directory name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen3-32B</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
