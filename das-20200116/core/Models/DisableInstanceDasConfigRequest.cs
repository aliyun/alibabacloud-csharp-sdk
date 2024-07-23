// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DisableInstanceDasConfigRequest : TeaModel {
        /// <summary>
        /// <para>The database engine. Set the value to Redis.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Redis</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The database instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1nti25tc7bq5****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of auto scaling. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>specScale</b>: The specifications of a database instance are automatically scaled up or down.</description></item>
        /// <item><description><b>shardScale</b>: The number of shards for a database instance is automatically increased or decreased.</description></item>
        /// <item><description><b>bandwidthScale</b>: The bandwidth of a database instance is automatically increased or decreased.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bandwidthScale</para>
        /// </summary>
        [NameInMap("ScaleType")]
        [Validation(Required=false)]
        public string ScaleType { get; set; }

    }

}
