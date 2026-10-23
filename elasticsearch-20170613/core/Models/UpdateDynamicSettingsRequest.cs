// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateDynamicSettingsRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The region ID of the Elasticsearch instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The dynamic configurations of the cluster to be updated. Specify a JSON object where the keys are configuration item names and the values are configuration values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;indices.recovery.max_bytes_per_sec&quot;:&quot;100mb&quot;}</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>The effective mode for dynamic configurations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>persistent: persistent configurations.</description></item>
        /// <item><description>transient: temporary configurations, which become invalid after the cluster is restarted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>persistent</para>
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

    }

}
