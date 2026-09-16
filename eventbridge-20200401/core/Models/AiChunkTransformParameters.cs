// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class AiChunkTransformParameters : TeaModel {
        /// <summary>
        /// <para>The chunking algorithm. Valid values: markdown_header and recursive_character.</para>
        /// 
        /// <b>Example:</b>
        /// <para>recursive_character</para>
        /// </summary>
        [NameInMap("ChunkingType")]
        [Validation(Required=false)]
        public string ChunkingType { get; set; }

        /// <summary>
        /// <para>The text field to chunk. This operator does not use InputField.</para>
        /// </summary>
        [NameInMap("InputField")]
        [Validation(Required=false)]
        public AiTransformField InputField { get; set; }

        /// <summary>
        /// <para>The chunk overlap length. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxOverlapSize")]
        [Validation(Required=false)]
        public int? MaxOverlapSize { get; set; }

        /// <summary>
        /// <para>The maximum chunk length. Default value: 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxSegmentSize")]
        [Validation(Required=false)]
        public int? MaxSegmentSize { get; set; }

        /// <summary>
        /// <para>The field name in the CloudEvent to which the output is attached. Default value: transform0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chunks</para>
        /// </summary>
        [NameInMap("StepName")]
        [Validation(Required=false)]
        public string StepName { get; set; }

        /// <summary>
        /// <para>Specifies whether to split the output into multiple events. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Unpack")]
        [Validation(Required=false)]
        public bool? Unpack { get; set; }

    }

}
