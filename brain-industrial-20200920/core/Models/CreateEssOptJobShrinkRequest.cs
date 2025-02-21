// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class CreateEssOptJobShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        [NameInMap("ElecPrice")]
        [Validation(Required=false)]
        public string ElecPriceShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FIFTEEN_MIN</para>
        /// </summary>
        [NameInMap("Freq")]
        [Validation(Required=false)]
        public string Freq { get; set; }

        [NameInMap("GenPrice")]
        [Validation(Required=false)]
        public string GenPriceShrink { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string LocationShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>latest</para>
        /// </summary>
        [NameInMap("ModelVersion")]
        [Validation(Required=false)]
        public string ModelVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-02-12</para>
        /// </summary>
        [NameInMap("RunDate")]
        [Validation(Required=false)]
        public string RunDate { get; set; }

        [NameInMap("SystemData")]
        [Validation(Required=false)]
        public string SystemDataShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>LOAD_ESS_SOLAR</para>
        /// </summary>
        [NameInMap("TopoType")]
        [Validation(Required=false)]
        public string TopoType { get; set; }

    }

}
