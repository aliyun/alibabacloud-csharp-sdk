// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListGlobalAppsResponseBody : TeaModel {
        /// <summary>
        /// 公共应用集合
        /// </summary>
        [NameInMap("GlobalApps")]
        [Validation(Required=false)]
        public List<ListGlobalAppsResponseBodyGlobalApps> GlobalApps { get; set; }
        public class ListGlobalAppsResponseBodyGlobalApps : TeaModel {
            /// <summary>
            /// 应用默认版本
            /// </summary>
            [NameInMap("AppDefaultVersion")]
            [Validation(Required=false)]
            public string AppDefaultVersion { get; set; }

            /// <summary>
            /// 应用描述
            /// </summary>
            [NameInMap("AppDescription")]
            [Validation(Required=false)]
            public string AppDescription { get; set; }

            /// <summary>
            /// 应用计费说明
            /// </summary>
            [NameInMap("AppFee")]
            [Validation(Required=false)]
            public string AppFee { get; set; }

            /// <summary>
            /// 应用名称
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// 应用权限
            /// </summary>
            [NameInMap("AppScope")]
            [Validation(Required=false)]
            public string AppScope { get; set; }

            /// <summary>
            /// 应用所属分类
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// 更新时间
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// 应用支持的区域ids
            /// </summary>
            [NameInMap("Locations")]
            [Validation(Required=false)]
            public List<string> Locations { get; set; }

            /// <summary>
            /// 命名空间名称
            /// </summary>
            [NameInMap("NamespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

            /// <summary>
            /// 应用收藏置顶标记
            /// </summary>
            [NameInMap("Pinned")]
            [Validation(Required=false)]
            public bool? Pinned { get; set; }

            /// <summary>
            /// 应用工具合集
            /// </summary>
            [NameInMap("Toolkit")]
            [Validation(Required=false)]
            public string Toolkit { get; set; }

        }

        /// <summary>
        /// 主机ID
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// 分页数
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 翻页Token用来表示当前调用返回读取到的位置，空代表数据已经读取完毕
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 本次请求条件下的数据总量
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
