// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListPublicDatasetResponseBody : TeaModel {
        /// <summary>
        /// 公共数据集信息
        /// </summary>
        [NameInMap("Datasets")]
        [Validation(Required=false)]
        public List<ListPublicDatasetResponseBodyDatasets> Datasets { get; set; }
        public class ListPublicDatasetResponseBodyDatasets : TeaModel {
            /// <summary>
            /// 关于公共数据集
            /// </summary>
            [NameInMap("About")]
            [Validation(Required=false)]
            public string About { get; set; }

            /// <summary>
            /// 公共数据集访问要求
            /// </summary>
            [NameInMap("AccessRequirements")]
            [Validation(Required=false)]
            public string AccessRequirements { get; set; }

            /// <summary>
            /// 公共数据集版权信息
            /// </summary>
            [NameInMap("Copyright")]
            [Validation(Required=false)]
            public string Copyright { get; set; }

            /// <summary>
            /// 公共数据集描述
            /// </summary>
            [NameInMap("DatasetDescription")]
            [Validation(Required=false)]
            public string DatasetDescription { get; set; }

            /// <summary>
            /// 公共数据集UUID
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// 公共数据集名称
            /// </summary>
            [NameInMap("DatasetName")]
            [Validation(Required=false)]
            public string DatasetName { get; set; }

            /// <summary>
            /// 最后更新时间
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// 公共数据集可用区域
            /// </summary>
            [NameInMap("Locations")]
            [Validation(Required=false)]
            public List<string> Locations { get; set; }

            /// <summary>
            /// 公共数据集标签
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            /// <summary>
            /// 公共数据集更新频率
            /// </summary>
            [NameInMap("UpdateFrequency")]
            [Validation(Required=false)]
            public string UpdateFrequency { get; set; }

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
        /// 总记录数
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
