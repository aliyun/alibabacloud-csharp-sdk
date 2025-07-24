// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListComponentsRequest : TeaModel {
        /// <summary>
        /// <para>应用名称列表。</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ApplicationNames")]
        [Validation(Required=false)]
        public List<string> ApplicationNames { get; set; }

        /// <summary>
        /// <para>集群ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C-8CFEBCCFFEF5****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>组件名称列表。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;HDFS&quot;]</para>
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
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>标记当前开始读取的位置，置空表示从头开始。</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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

    }

}
