// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyEmptyNumberNoMoreCallsInfoRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EmptyNumberNoMoreCalls")]
        [Validation(Required=false)]
        public bool? EmptyNumberNoMoreCalls { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6cc9f5ca-2cb6-4cc7-a46b-2bbfd3e61b22</para>
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
