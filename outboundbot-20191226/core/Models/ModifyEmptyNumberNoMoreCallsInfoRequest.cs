// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyEmptyNumberNoMoreCallsInfoRequest : TeaModel {
        /// <summary>
        /// <para>Enable or disable the nonexistent number no-call feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EmptyNumberNoMoreCalls")]
        [Validation(Required=false)]
        public bool? EmptyNumberNoMoreCalls { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6cc9f5ca-2cb6-4cc7-a46b-2bbfd3e61b22</para>
        /// </summary>
        [NameInMap("EntryId")]
        [Validation(Required=false)]
        public string EntryId { get; set; }

        /// <summary>
        /// <para>Policy level. Use 2 for business instances.</para>
        /// <list type="bullet">
        /// <item><description><para>0: system</para>
        /// </description></item>
        /// <item><description><para>1: tenant</para>
        /// </description></item>
        /// <item><description><para>2: instance</para>
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
