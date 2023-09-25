// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class QueryTagListPageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTagListPageResponseBodyData Data { get; set; }
        public class QueryTagListPageResponseBodyData : TeaModel {
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<QueryTagListPageResponseBodyDataRecords> Records { get; set; }
            public class QueryTagListPageResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// 前端调用的api名称
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// code
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// API文档链接
                /// </summary>
                [NameInMap("DocAddress")]
                [Validation(Required=false)]
                public string DocAddress { get; set; }

                /// <summary>
                /// 标签 id
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// 行业id
                /// </summary>
                [NameInMap("IndustryId")]
                [Validation(Required=false)]
                public long? IndustryId { get; set; }

                /// <summary>
                /// 行业名称
                /// </summary>
                [NameInMap("IndustryName")]
                [Validation(Required=false)]
                public string IndustryName { get; set; }

                /// <summary>
                /// 标签介绍
                /// </summary>
                [NameInMap("Introduction")]
                [Validation(Required=false)]
                public string Introduction { get; set; }

                /// <summary>
                /// 是否已经申请开通
                /// </summary>
                [NameInMap("IsOpen")]
                [Validation(Required=false)]
                public long? IsOpen { get; set; }

                /// <summary>
                /// 标签名称
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 0 隐藏 1 公开
                /// </summary>
                [NameInMap("SaleStatusStr")]
                [Validation(Required=false)]
                public string SaleStatusStr { get; set; }

                /// <summary>
                /// 场景id
                /// </summary>
                [NameInMap("SceneId")]
                [Validation(Required=false)]
                public long? SceneId { get; set; }

                /// <summary>
                /// 场景名称
                /// </summary>
                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
