// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class CostNodeGroupConfig : TeaModel {
        /// <summary>
        /// <para>实例类型列表。</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<CostInstanceType> InstanceTypes { get; set; }

        /// <summary>
        /// <para>最大节点数限制。</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaximalNodeCount")]
        [Validation(Required=false)]
        public int? MaximalNodeCount { get; set; }

        /// <summary>
        /// <para>最小节点数限制。</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MinimalNodeCount")]
        [Validation(Required=false)]
        public int? MinimalNodeCount { get; set; }

        /// <summary>
        /// <para>节点数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NodeCount")]
        [Validation(Required=false)]
        public int? NodeCount { get; set; }

        [NameInMap("NodeGroupName")]
        [Validation(Required=false)]
        public string NodeGroupName { get; set; }

        /// <summary>
        /// <para>节点组类型。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>MASTER：管理类型节点组。</description></item>
        /// <item><description>CORE：存储类型节点组。</description></item>
        /// <item><description>TASK：计算类型节点组。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CORE</para>
        /// </summary>
        [NameInMap("NodeGroupType")]
        [Validation(Required=false)]
        public string NodeGroupType { get; set; }

        /// <summary>
        /// <para>付费类型。</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

    }

}
