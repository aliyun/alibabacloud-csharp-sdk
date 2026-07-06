// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetConsumerProgressRequest : TeaModel {
        /// <summary>
        /// <para>The name of the consumer group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kafka-test</para>
        /// </summary>
        [NameInMap("ConsumerId")]
        [Validation(Required=false)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to hide the \<c>LastTimestamp\\</c> parameter. The default value is false. Set this parameter to true for better performance.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If you set this parameter to true, -1 is returned for the \<c>LastTimestamp\\</c> parameter. Otherwise, a specific value is returned. This parameter is supported only for topics of cloud storage on provisioned instances.</para>
        /// </description></item>
        /// <item><description><para>This operation processes a large amount of data and consumes a high degree of performance. Set this parameter to true to reduce the processing time.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HideLastTimestamp")]
        [Validation(Required=false)]
        public bool? HideLastTimestamp { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_pre-cn-mp919o4v****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
