// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeTotalAttackMaxFlowRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// <remarks>
        /// <para>This UNIX timestamp must indicate a point in time that is accurate to the minute.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1659697200</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The IDs of the Anti-DDoS Proxy instances. Separate multiple instance IDs with commas (,). Example: InstanceIds.1, InstanceIds.2, InstanceIds.3.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs in Resource Management. If you do not configure this parameter, the instance belongs to the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// <remarks>
        /// <para>This UNIX timestamp must indicate a point in time that is accurate to the minute.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1669240800</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
