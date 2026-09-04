// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLProgressSync : TeaModel {
        /// <summary>
        /// <para>The parameter synchronization duration in seconds. This property has a value only when State is end.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.5</para>
        /// </summary>
        [NameInMap("Cost")]
        [Validation(Required=false)]
        public double? Cost { get; set; }

        /// <summary>
        /// <para>begin / end</para>
        /// 
        /// <b>Example:</b>
        /// <para>end</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
