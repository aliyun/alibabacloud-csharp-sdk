// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class AdjustJMeterSceneSpeedRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the report.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DYYPZIH</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        /// <summary>
        /// <para>The load to which you want to adjust.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Speed")]
        [Validation(Required=false)]
        public int? Speed { get; set; }

    }

}
