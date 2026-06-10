// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyOutboundCallNumberRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8fa1953f-4a84-46d8-b80c-8ce9cf684fb3</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number to modify</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10088xxx</para>
        /// </summary>
        [NameInMap("Number")]
        [Validation(Required=false)]
        public string Number { get; set; }

        /// <summary>
        /// <para>Number ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fa0e21e9-caab-4629-9121-1e341243d599</para>
        /// </summary>
        [NameInMap("OutboundCallNumberId")]
        [Validation(Required=false)]
        public string OutboundCallNumberId { get; set; }

        /// <summary>
        /// <para>Number of rate limiting rules</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RateLimitCount")]
        [Validation(Required=false)]
        public int? RateLimitCount { get; set; }

        /// <summary>
        /// <para>Rate limiting time window, in seconds</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("RateLimitPeriod")]
        [Validation(Required=false)]
        public int? RateLimitPeriod { get; set; }

    }

}
