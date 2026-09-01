// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpdateKnowledgeSpaceShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>testDesc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pks-xxxxxx</para>
        /// </summary>
        [NameInMap("KnowledgeSpaceId")]
        [Validation(Required=false)]
        public string KnowledgeSpaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen3.6-plus</para>
        /// </summary>
        [NameInMap("LLMModel")]
        [Validation(Required=false)]
        public string LLMModel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen3-rerank</para>
        /// </summary>
        [NameInMap("RerankModel")]
        [Validation(Required=false)]
        public string RerankModel { get; set; }

        [NameInMap("ShardingStrategyConfig")]
        [Validation(Required=false)]
        public string ShardingStrategyConfigShrink { get; set; }

    }

}
