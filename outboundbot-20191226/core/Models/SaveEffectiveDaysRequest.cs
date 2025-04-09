// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SaveEffectiveDaysRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("EffectiveDays")]
        [Validation(Required=false)]
        public int? EffectiveDays { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e90b5b8e-c8b4-4182-b28d-a5aa81685e49</para>
        /// </summary>
        [NameInMap("EntryId")]
        [Validation(Required=false)]
        public string EntryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StrategyLevel")]
        [Validation(Required=false)]
        public int? StrategyLevel { get; set; }

    }

}
