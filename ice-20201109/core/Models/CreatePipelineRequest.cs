// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreatePipelineRequest : TeaModel {
        /// <summary>
        /// <para>The pipeline name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-pipeline</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The priority, ranging from 1 to 10. Default value: 6. A larger value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The pipeline type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Standard: standard pipeline.</para>
        /// </description></item>
        /// <item><description><para>Boost: double-speed transcoding pipeline.</para>
        /// </description></item>
        /// <item><description><para>NarrowBandHDV2: Narrowband HD 2.0 pipeline.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("Speed")]
        [Validation(Required=false)]
        public string Speed { get; set; }

    }

}
