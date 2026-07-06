// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class QueryMessageRequest : TeaModel {
        /// <summary>
        /// <para>The start timestamp of the query range. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1672410180000</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

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
        /// <para>The partition offset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public string Offset { get; set; }

        /// <summary>
        /// <para>The partition ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Partition")]
        [Validation(Required=false)]
        public string Partition { get; set; }

        /// <summary>
        /// <para>The query type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>byOffset: Query by offset. When selecting offset query, you need to fill in the partition ID and partition offset parameters.</para>
        /// </description></item>
        /// <item><description><para>byTimestamp: Query by time. When selecting time query, you need to fill in the BeginTime parameter.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>byTimestamp</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// <para>The region ID of the resource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The topic name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testkafka</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
