// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListApplicationConfigsResponseBody : TeaModel {
        [NameInMap("ApplicationConfigs")]
        [Validation(Required=false)]
        public List<ListApplicationConfigsResponseBodyApplicationConfigs> ApplicationConfigs { get; set; }
        public class ListApplicationConfigsResponseBodyApplicationConfigs : TeaModel {
            /// <summary>
            /// 应用名称。
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// 配置值生效状态。
            /// </summary>
            [NameInMap("ConfigEffectState")]
            [Validation(Required=false)]
            public string ConfigEffectState { get; set; }

            /// <summary>
            /// 配置文件名称。
            /// </summary>
            [NameInMap("ConfigFileName")]
            [Validation(Required=false)]
            public string ConfigFileName { get; set; }

            /// <summary>
            /// 配置项键。
            /// </summary>
            [NameInMap("ConfigItemKey")]
            [Validation(Required=false)]
            public string ConfigItemKey { get; set; }

            /// <summary>
            /// 配置项值。
            /// </summary>
            [NameInMap("ConfigItemValue")]
            [Validation(Required=false)]
            public string ConfigItemValue { get; set; }

            /// <summary>
            /// 创建时间。
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// 是否是自定义配置。
            /// </summary>
            [NameInMap("Custom")]
            [Validation(Required=false)]
            public bool? Custom { get; set; }

            /// <summary>
            /// 描述。
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 初始值。
            /// </summary>
            [NameInMap("InitValue")]
            [Validation(Required=false)]
            public string InitValue { get; set; }

            /// <summary>
            /// 修改人。
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// 节点组ID。
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// 节点ID。
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// 更新时间。
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// 本次请求所返回的最大记录条数。
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 返回读取到的数据位置，空代表数据已经读取完毕。
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 本次请求条件下的数据总量。
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
