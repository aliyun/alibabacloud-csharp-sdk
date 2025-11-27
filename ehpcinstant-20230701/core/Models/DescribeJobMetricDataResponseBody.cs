// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class DescribeJobMetricDataResponseBody : TeaModel {
        /// <summary>
        /// <para>Monitoring statistics points.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;timestamp&quot;:1709540685000,&quot;Minimum&quot;:28.45,&quot;Maximum&quot;:28.45,&quot;Average&quot;:28.45}]</para>
        /// </summary>
        [NameInMap("DataPoints")]
        [Validation(Required=false)]
        public string DataPoints { get; set; }

        /// <summary>
        /// <para>The statistical period of the monitoring data. Valid values: 15, 60, 900, and 3600. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
