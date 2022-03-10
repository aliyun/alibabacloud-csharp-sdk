// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorksBloodRelationshipResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryWorksBloodRelationshipResponseBodyResult> Result { get; set; }
        public class QueryWorksBloodRelationshipResponseBodyResult : TeaModel {
            /// <summary>
            /// 组件ID or  sheetId
            /// </summary>
            [NameInMap("ComponentId")]
            [Validation(Required=false)]
            public string ComponentId { get; set; }

            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            /// <summary>
            /// 组件类型
            /// </summary>
            [NameInMap("ComponentType")]
            [Validation(Required=false)]
            public int? ComponentType { get; set; }

            [NameInMap("ComponentTypeName")]
            [Validation(Required=false)]
            public string ComponentTypeName { get; set; }

            /// <summary>
            /// 数据集ID
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// 查询参数引用的列信息
            /// </summary>
            [NameInMap("QueryParams")]
            [Validation(Required=false)]
            public List<QueryWorksBloodRelationshipResponseBodyResultQueryParams> QueryParams { get; set; }
            public class QueryWorksBloodRelationshipResponseBodyResultQueryParams : TeaModel {
                /// <summary>
                /// 所属位置：
                /// </summary>
                [NameInMap("AreaId")]
                [Validation(Required=false)]
                public string AreaId { get; set; }

                [NameInMap("AreaName")]
                [Validation(Required=false)]
                public string AreaName { get; set; }

                /// <summary>
                /// 字段显示名称
                /// </summary>
                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                /// <summary>
                /// 字段类型
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// 是否是度量
                /// </summary>
                [NameInMap("IsMeasure")]
                [Validation(Required=false)]
                public bool? IsMeasure { get; set; }

                /// <summary>
                /// 全局唯一的PathId。位于cube的level中pathId
                /// </summary>
                [NameInMap("PathId")]
                [Validation(Required=false)]
                public string PathId { get; set; }

                /// <summary>
                /// 字段唯一ID。即cube中的name
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
