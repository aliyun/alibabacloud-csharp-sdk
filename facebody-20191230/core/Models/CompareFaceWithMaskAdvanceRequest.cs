// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class CompareFaceWithMaskAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ImageURLA")]
        [Validation(Required=false)]
        public Stream ImageURLAObject { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ImageURLB")]
        [Validation(Required=false)]
        public Stream ImageURLBObject { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>97.0</para>
        /// </summary>
        [NameInMap("QualityScoreThreshold")]
        [Validation(Required=false)]
        public float? QualityScoreThreshold { get; set; }

    }

}
