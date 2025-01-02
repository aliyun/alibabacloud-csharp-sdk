// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetKafkaClientIpRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1716343502000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the consumer group.</para>
        /// <remarks>
        /// <para> This parameter is required only if you set Type to byGroup.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>group_name</para>
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_post-cn-v0h1fgs2****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1716343501000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The topic name.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required only if you set Type to byTopic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>topic_name</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// <para>The query method that you want to use to query the client IP addresses. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>byInstance: queries the IP addresses of the clients that are connected to the instance within a specific period of time.</description></item>
        /// <item><description>byTopic: queries the IP addresses of the clients that are connected to a specific topic on the instance within a specific period of time.</description></item>
        /// <item><description>byGroup: queries the IP addresses of the clients that are connected to a specific group on the instance within a specific period of time.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>byInstance</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
