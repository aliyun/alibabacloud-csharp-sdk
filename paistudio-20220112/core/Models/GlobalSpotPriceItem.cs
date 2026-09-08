// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GlobalSpotPriceItem : TeaModel {
        /// <summary>
        /// <para>The effective period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-20T06:45:00Z</para>
        /// </summary>
        [NameInMap("effectiveAt")]
        [Validation(Required=false)]
        public string EffectiveAt { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ml.gp7vf.16.40xlarge</para>
        /// </summary>
        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The current market price.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1</para>
        /// </summary>
        [NameInMap("spotDiscount")]
        [Validation(Required=false)]
        public string SpotDiscount { get; set; }

    }

}
