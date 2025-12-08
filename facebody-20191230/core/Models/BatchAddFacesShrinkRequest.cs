// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class BatchAddFacesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>U1</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Faces")]
        [Validation(Required=false)]
        public string FacesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50.0</para>
        /// </summary>
        [NameInMap("QualityScoreThreshold")]
        [Validation(Required=false)]
        public float? QualityScoreThreshold { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50.0</para>
        /// </summary>
        [NameInMap("SimilarityScoreThresholdBetweenEntity")]
        [Validation(Required=false)]
        public float? SimilarityScoreThresholdBetweenEntity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50.0</para>
        /// </summary>
        [NameInMap("SimilarityScoreThresholdInEntity")]
        [Validation(Required=false)]
        public float? SimilarityScoreThresholdInEntity { get; set; }

    }

}
