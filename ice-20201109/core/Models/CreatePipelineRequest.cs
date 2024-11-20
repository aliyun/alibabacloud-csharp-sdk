// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreatePipelineRequest : TeaModel {
        /// <summary>
        /// <para>The name of the MPS queue.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-pipeline</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The priority. Default value: 6. Valid values: 1 to 10. A greater value specifies a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The type of the MPS queue. Valid values:</para>
        /// <ol>
        /// <item><description>Standard: standard MPS queue.</description></item>
        /// <item><description>Boost: MPS queue with transcoding speed boosted.</description></item>
        /// <item><description>NarrowBandHDV2: MPS queue that supports Narrowband HD 2.0.</description></item>
        /// </ol>
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
