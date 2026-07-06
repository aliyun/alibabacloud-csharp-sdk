// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class EnableAutoTopicCreationRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_post-cn-v0h1fgs2****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Currently only these three request parameters are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>enable: Enable automatic topic creation.</para>
        /// </description></item>
        /// <item><description><para>disable: Disable automatic topic creation.</para>
        /// </description></item>
        /// <item><description><para>updatePartition: Modify the number of partitions for automatic creation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("Operate")]
        [Validation(Required=false)]
        public string Operate { get; set; }

        /// <summary>
        /// <para>Adjust the default number of partitions for automatically created topics.</para>
        /// <remarks>
        /// <para>This value is passed only when the Operate value is updatePartition, or when UpdatePartition is true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PartitionNum")]
        [Validation(Required=false)]
        public long? PartitionNum { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Modify the number of partitions for automatic creation.</para>
        /// <remarks>
        /// <para>If this parameter is set to true, the Operate parameter must be updatePartition or left empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UpdatePartition")]
        [Validation(Required=false)]
        public bool? UpdatePartition { get; set; }

    }

}
