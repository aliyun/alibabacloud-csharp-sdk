// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class QueryUsageStatisticsByTagIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryUsageStatisticsByTagIdResponseBodyData> Data { get; set; }
        public class QueryUsageStatisticsByTagIdResponseBodyData : TeaModel {
            /// <summary>
            /// 授权码
            /// </summary>
            [NameInMap("AuthorizationCode")]
            [Validation(Required=false)]
            public string AuthorizationCode { get; set; }

            /// <summary>
            /// 查询失败号码数
            /// </summary>
            [NameInMap("FailTotal")]
            [Validation(Required=false)]
            public long? FailTotal { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("GmtDateStr")]
            [Validation(Required=false)]
            public string GmtDateStr { get; set; }

            /// <summary>
            /// 授权码使用记录 id
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 行业名称
            /// </summary>
            [NameInMap("IndustryName")]
            [Validation(Required=false)]
            public string IndustryName { get; set; }

            /// <summary>
            /// 客户 pid
            /// </summary>
            [NameInMap("PartnerId")]
            [Validation(Required=false)]
            public long? PartnerId { get; set; }

            /// <summary>
            /// 场景名称
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// 查询成功号码数
            /// </summary>
            [NameInMap("SuccessTotal")]
            [Validation(Required=false)]
            public long? SuccessTotal { get; set; }

            /// <summary>
            /// 标签名称
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public long? TagId { get; set; }

            /// <summary>
            /// 标签名称
            /// </summary>
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

            /// <summary>
            /// 查询总号码数
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

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
