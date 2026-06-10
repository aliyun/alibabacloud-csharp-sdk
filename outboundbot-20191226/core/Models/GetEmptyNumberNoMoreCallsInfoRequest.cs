// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class GetEmptyNumberNoMoreCallsInfoRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db3e679b-7d5e-4d9b-828a-345adca455f3</para>
        /// </summary>
        [NameInMap("EntryId")]
        [Validation(Required=false)]
        public string EntryId { get; set; }

        /// <summary>
        /// <para>Strategy level. Set to 2 for business instances.</para>
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
