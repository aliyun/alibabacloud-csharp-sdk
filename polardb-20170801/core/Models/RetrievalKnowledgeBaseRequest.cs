// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class RetrievalKnowledgeBaseRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pkb-xxxxx</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>财报</para>
        /// </summary>
        [NameInMap("QueryText")]
        [Validation(Required=false)]
        public string QueryText { get; set; }

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
        /// <para>true</para>
        /// </summary>
        [NameInMap("RerankEnabled")]
        [Validation(Required=false)]
        public bool? RerankEnabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.7</para>
        /// </summary>
        [NameInMap("ScoreThreshold")]
        [Validation(Required=false)]
        public double? ScoreThreshold { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

    }

}
