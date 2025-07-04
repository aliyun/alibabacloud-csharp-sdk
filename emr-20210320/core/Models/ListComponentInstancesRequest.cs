// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListComponentInstancesRequest : TeaModel {
        /// <summary>
        /// <para>应用名称列表。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;HDFS&quot;]</para>
        /// </summary>
        [NameInMap("ApplicationNames")]
        [Validation(Required=false)]
        public List<string> ApplicationNames { get; set; }

        /// <summary>
        /// <para>集群ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b933c5aac8fe****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>组件名称列表。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;DataNode&quot;]</para>
        /// </summary>
        [NameInMap("ComponentNames")]
        [Validation(Required=false)]
        public List<string> ComponentNames { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ComponentStates")]
        [Validation(Required=false)]
        public List<string> ComponentStates { get; set; }

        /// <summary>
        /// <para>一次获取的最大记录数。取值范围：1~100。</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>标记当前开始读取的位置，置空表示从头开始。</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C89568980</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>节点ID列表。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;i-bp1cudc25w2bfwl5****&quot;]</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public List<string> NodeIds { get; set; }

        /// <summary>
        /// <para>节点名称列表。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;core1-1&quot;]</para>
        /// </summary>
        [NameInMap("NodeNames")]
        [Validation(Required=false)]
        public List<string> NodeNames { get; set; }

        /// <summary>
        /// <para>地域ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
