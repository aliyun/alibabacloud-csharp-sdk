// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListPipelinesRequest : TeaModel {
        /// <summary>
        /// <para>The type of the MPS queue.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Boost: MPS queue with transcoding speed boosted.</para>
        /// </description></item>
        /// <item><description><para>Standard: standard MPS queue.</para>
        /// </description></item>
        /// <item><description><para>NarrowBandHDV2: MPS queue that supports Narrowband HD 2.0.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("Speed")]
        [Validation(Required=false)]
        public string Speed { get; set; }

    }

}
