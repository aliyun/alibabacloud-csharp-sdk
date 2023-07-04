// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class PageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public PageResponseBodyModel Model { get; set; }
        public class PageResponseBodyModel : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<PageResponseBodyModelList> List { get; set; }
            public class PageResponseBodyModelList : TeaModel {
                /// <summary>
                /// 添加时间
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// 过期时间
                /// </summary>
                [NameInMap("ExpirationTime")]
                [Validation(Required=false)]
                public string ExpirationTime { get; set; }

                /// <summary>
                /// 手机号码
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                /// <summary>
                /// 手机号MD5
                /// </summary>
                [NameInMap("NumberMD5")]
                [Validation(Required=false)]
                public string NumberMD5 { get; set; }

                /// <summary>
                /// 备注
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

            }

            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
