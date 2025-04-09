// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DeleteOutboundCallNumberRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33014787-cc13-49d3-ab2f-a98aa8f15fbb</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ffa367e0-58f3-43b6-9615-c63db99c5add</para>
        /// </summary>
        [NameInMap("OutboundCallNumberId")]
        [Validation(Required=false)]
        public string OutboundCallNumberId { get; set; }

    }

}
