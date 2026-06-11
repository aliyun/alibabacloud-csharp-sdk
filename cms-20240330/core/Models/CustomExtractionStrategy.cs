// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CustomExtractionStrategy : TeaModel {
        /// <summary>
        /// <para>Description</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Extraction prompt</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("extractionPrompt")]
        [Validation(Required=false)]
        public string ExtractionPrompt { get; set; }

        /// <summary>
        /// <para>Policy Name</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("strategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        /// <summary>
        /// <para>Policy type. Supports &quot;Episodic&quot;, &quot;Summary&quot;, and &quot;Fact&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Fact</para>
        /// </summary>
        [NameInMap("strategyType")]
        [Validation(Required=false)]
        public string StrategyType { get; set; }

        /// <summary>
        /// <para>Update prompt</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("updatePrompt")]
        [Validation(Required=false)]
        public string UpdatePrompt { get; set; }

    }

}
