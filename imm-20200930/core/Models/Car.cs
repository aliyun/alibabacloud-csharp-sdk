// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Car : TeaModel {
        /// <summary>
        /// <para>The boundary information.</para>
        /// </summary>
        [NameInMap("Boundary")]
        [Validation(Required=false)]
        public Boundary Boundary { get; set; }

        /// <summary>
        /// <para>The vehicle color. Valid values</para>
        /// <list type="bullet">
        /// <item><description>white</description></item>
        /// <item><description>grey</description></item>
        /// <item><description>yellow</description></item>
        /// <item><description>red</description></item>
        /// <item><description>green</description></item>
        /// <item><description>blue</description></item>
        /// <item><description>black</description></item>
        /// <item><description>purple</description></item>
        /// <item><description>brown</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>white</para>
        /// </summary>
        [NameInMap("CarColor")]
        [Validation(Required=false)]
        public string CarColor { get; set; }

        /// <summary>
        /// <para>The confidence level of the vehicle color. Valid values: 0 to 1. The value 0 indicates the lowest confidence level. The value 1 indicates the highest confidence level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.604</para>
        /// </summary>
        [NameInMap("CarColorConfidence")]
        [Validation(Required=false)]
        public double? CarColorConfidence { get; set; }

        /// <summary>
        /// <para>The vehicle type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>car</description></item>
        /// <item><description>bus</description></item>
        /// <item><description>truck</description></item>
        /// <item><description>van</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>van</para>
        /// </summary>
        [NameInMap("CarType")]
        [Validation(Required=false)]
        public string CarType { get; set; }

        /// <summary>
        /// <para>The confidence level of the vehicle type. Valid values: 0 to 1. The value 0 indicates the lowest confidence level. The value 1 indicates the highest confidence level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.516</para>
        /// </summary>
        [NameInMap("CarTypeConfidence")]
        [Validation(Required=false)]
        public double? CarTypeConfidence { get; set; }

        /// <summary>
        /// <para>The confidence level of the vehicle detection result. Valid values: 0 to 1. The value 0 indicates the lowest confidence level. The value 1 indicates the highest confidence level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.999</para>
        /// </summary>
        [NameInMap("Confidence")]
        [Validation(Required=false)]
        public double? Confidence { get; set; }

        /// <summary>
        /// <para>The license plates.</para>
        /// </summary>
        [NameInMap("LicensePlates")]
        [Validation(Required=false)]
        public List<LicensePlate> LicensePlates { get; set; }

    }

}
