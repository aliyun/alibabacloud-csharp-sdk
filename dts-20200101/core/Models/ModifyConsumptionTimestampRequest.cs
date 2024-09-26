// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyConsumptionTimestampRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account. You do not need to specify this parameter because this parameter will be removed in the future.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The consumption checkpoint. The format is <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z. The time is displayed in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-10-15T17:20:03Z</para>
        /// </summary>
        [NameInMap("ConsumptionTimestamp")]
        [Validation(Required=false)]
        public string ConsumptionTimestamp { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the change tracking instance. You can call the <b>DescribeSubscriptionInstances</b> operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsg2m10r1x15a****</para>
        /// </summary>
        [NameInMap("SubscriptionInstanceId")]
        [Validation(Required=false)]
        public string SubscriptionInstanceId { get; set; }

    }

}
