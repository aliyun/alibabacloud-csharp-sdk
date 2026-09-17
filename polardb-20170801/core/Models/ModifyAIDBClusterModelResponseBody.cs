// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyAIDBClusterModelResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the request is a dry-run request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The model type of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>3AA6E0E4-1234-5678-90AB-1234567890AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resolved target model name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen3-32B</para>
        /// </summary>
        [NameInMap("TargetModelName")]
        [Validation(Required=false)]
        public string TargetModelName { get; set; }

        /// <summary>
        /// <para>The resolved target OSS path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/my-model-bucket/models/qwen3</para>
        /// </summary>
        [NameInMap("TargetOssPath")]
        [Validation(Required=false)]
        public string TargetOssPath { get; set; }

        /// <summary>
        /// <para>The ID of the asynchronous task. This parameter is empty when DryRun is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public int? TaskId { get; set; }

        /// <summary>
        /// <para>The number of change batches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalBatches")]
        [Validation(Required=false)]
        public long? TotalBatches { get; set; }

        /// <summary>
        /// <para>The number of affected model serving instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalMsds")]
        [Validation(Required=false)]
        public long? TotalMsds { get; set; }

        /// <summary>
        /// <para>The change warnings returned by the upstream. The caller must display these warnings.</para>
        /// </summary>
        [NameInMap("Warnings")]
        [Validation(Required=false)]
        public List<string> Warnings { get; set; }

    }

}
