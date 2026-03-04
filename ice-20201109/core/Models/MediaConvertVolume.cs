// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertVolume : TeaModel {
        /// <summary>
        /// <para>The output volume.</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only if Method is set to dynamic.</description></item>
        /// <item><description>Unit: dB.</description></item>
        /// <item><description>Valid values: [-70,-5].</description></item>
        /// <item><description>Default value: -6.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-6</para>
        /// </summary>
        [NameInMap("IntegratedLoudnessTarget")]
        [Validation(Required=false)]
        public int? IntegratedLoudnessTarget { get; set; }

        /// <summary>
        /// <para>The amount of gain to apply, relative to the input audio.</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only if Method is set to linear.</description></item>
        /// <item><description>Unit: dB.</description></item>
        /// <item><description>Valid values: less than or equal to 20.</description></item>
        /// <item><description>Default value: -20.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-20</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public int? Level { get; set; }

        /// <summary>
        /// <para>The target loudness range.</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only if Method is set to dynamic.</description></item>
        /// <item><description>Unit: dB.</description></item>
        /// <item><description>Valid values: [1,20].</description></item>
        /// <item><description>Default value: 8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("LoudnessRangeTarget")]
        [Validation(Required=false)]
        public int? LoudnessRangeTarget { get; set; }

        /// <summary>
        /// <para>The volume adjustment method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>auto</description></item>
        /// <item><description>dynamic</description></item>
        /// <item><description>linear</description></item>
        /// <item><description>Default value: dynamic.</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <list type="bullet">
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>linear</para>
        /// </summary>
        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>The maximum volume.</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only if Method is set to dynamic.</description></item>
        /// <item><description>Unit: dB.</description></item>
        /// <item><description>Valid values: [-9,0].</description></item>
        /// <item><description>Default value: -1.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("TruePeak")]
        [Validation(Required=false)]
        public int? TruePeak { get; set; }

    }

}
