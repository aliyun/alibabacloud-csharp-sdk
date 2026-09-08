// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class UpdateCallSummaryRequest : TeaModel {
        /// <summary>
        /// <para>Content to update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;summaryTitle&quot;:&quot;标题&quot;,&quot;summaryContent&quot;:&quot;内容&quot;,&quot;keywords&quot;:&quot;关键信息&quot;}</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public string Context { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Summary ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f2c6722b-cd13-442d-bf10-22a07c70d6d5</para>
        /// </summary>
        [NameInMap("TicketId")]
        [Validation(Required=false)]
        public string TicketId { get; set; }

    }

}
