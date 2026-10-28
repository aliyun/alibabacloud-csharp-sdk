// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class HyperNodeSchedulingConfig : TeaModel {
        /// <summary>
        /// <para>The minimum number of available instances required when the role participates in HyperNode scheduling. The value must be greater than 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinAvailable")]
        [Validation(Required=false)]
        public int? MinAvailable { get; set; }

        /// <summary>
        /// <para>The quality policy. Currently, only AlwaysRequire is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AlwaysRequire</para>
        /// </summary>
        [NameInMap("QualityPolicy")]
        [Validation(Required=false)]
        public string QualityPolicy { get; set; }

    }

}
