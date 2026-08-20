// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class AutoRenewInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The cycle unit. This parameter is required when enabling auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Day: day.</description></item>
        /// <item><description>Month: month.</description></item>
        /// <item><description>Year: year.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("AutoRenewCycle")]
        [Validation(Required=false)]
        public string AutoRenewCycle { get; set; }

        /// <summary>
        /// <para>The renewal cycle. This parameter is required when enabling auto-renewal.</para>
        /// </summary>
        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Marketplace instance ID. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OrderBizId")]
        [Validation(Required=false)]
        public long? OrderBizId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>open: enables auto-renewal.</description></item>
        /// <item><description>close: disables auto-renewal.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
