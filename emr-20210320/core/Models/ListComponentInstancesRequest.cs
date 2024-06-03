// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListComponentInstancesRequest : TeaModel {
        /// <summary>
        /// 应用名称列表。
        /// </summary>
        [NameInMap("ApplicationNames")]
        [Validation(Required=false)]
        public List<string> ApplicationNames { get; set; }

        /// <summary>
        /// 集群ID。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 组件名称列表。
        /// </summary>
        [NameInMap("ComponentNames")]
        [Validation(Required=false)]
        public List<string> ComponentNames { get; set; }

        [NameInMap("ComponentStates")]
        [Validation(Required=false)]
        public List<string> ComponentStates { get; set; }

        /// <summary>
        /// 一次获取的最大记录数。取值范围：1~100。
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 标记当前开始读取的位置，置空表示从头开始。
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 节点ID列表。
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public List<string> NodeIds { get; set; }

        /// <summary>
        /// 节点名称列表。
        /// </summary>
        [NameInMap("NodeNames")]
        [Validation(Required=false)]
        public List<string> NodeNames { get; set; }

        /// <summary>
        /// 地域ID。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
