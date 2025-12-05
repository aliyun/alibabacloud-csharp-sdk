// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetJMeterSampleMetricsRequest : TeaModel {
        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1637157070000</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1637157073000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The report ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7R4RE352</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        /// <summary>
        /// <para>The sampler ID. This parameter value starts from 0. If this parameter value is -1, the data of the whole scenario is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SamplerId")]
        [Validation(Required=false)]
        public int? SamplerId { get; set; }

    }

}
