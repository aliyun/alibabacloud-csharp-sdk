// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class GetBaseStrategyPeriodRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>024f8cf0-c842-4c01-b74b-c8667e4579c7</para>
        /// </summary>
        [NameInMap("EntryId")]
        [Validation(Required=false)]
        public string EntryId { get; set; }

        /// <summary>
        /// <para>Strategy level. Default value is 2.</para>
        /// <list type="bullet">
        /// <item><description><para>0: System</para>
        /// </description></item>
        /// <item><description><para>1: Tenant</para>
        /// </description></item>
        /// <item><description><para>2: Instance</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StrategyLevel")]
        [Validation(Required=false)]
        public int? StrategyLevel { get; set; }

    }

}
