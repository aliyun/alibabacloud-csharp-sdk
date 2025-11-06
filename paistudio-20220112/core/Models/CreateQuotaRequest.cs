// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class CreateQuotaRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ByNodeSpecs</para>
        /// </summary>
        [NameInMap("AllocateStrategy")]
        [Validation(Required=false)]
        public string AllocateStrategy { get; set; }

        [NameInMap("ClusterSpec")]
        [Validation(Required=false)]
        public ClusterSpec ClusterSpec { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>this is a test quota</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        [NameInMap("Min")]
        [Validation(Required=false)]
        public ResourceSpec Min { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>quota1ci8g793pgm</para>
        /// </summary>
        [NameInMap("ParentQuotaId")]
        [Validation(Required=false)]
        public string ParentQuotaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PaiStrategyIntelligent</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("QueueStrategy")]
        [Validation(Required=false)]
        public string QueueStrategy { get; set; }

        [NameInMap("QuotaConfig")]
        [Validation(Required=false)]
        public QuotaConfig QuotaConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-quota</para>
        /// </summary>
        [NameInMap("QuotaName")]
        [Validation(Required=false)]
        public string QuotaName { get; set; }

        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public List<string> ResourceGroupIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
