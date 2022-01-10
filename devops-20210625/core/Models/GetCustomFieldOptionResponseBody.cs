// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetCustomFieldOptionResponseBody : TeaModel {
        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 字段值信息
        /// </summary>
        [NameInMap("fileds")]
        [Validation(Required=false)]
        public List<GetCustomFieldOptionResponseBodyFileds> Fileds { get; set; }
        public class GetCustomFieldOptionResponseBodyFileds : TeaModel {
            /// <summary>
            /// 展示的值
            /// </summary>
            [NameInMap("displayValue")]
            [Validation(Required=false)]
            public string DisplayValue { get; set; }

            /// <summary>
            /// 字段唯一标识
            /// </summary>
            [NameInMap("fieldIdentifier")]
            [Validation(Required=false)]
            public string FieldIdentifier { get; set; }

            /// <summary>
            /// 迭代唯一标识符
            /// </summary>
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// 展示级别，数字范围1~9，数字越大，颜色越浅
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public long? Level { get; set; }

            /// <summary>
            /// 待选值顺序
            /// </summary>
            [NameInMap("position")]
            [Validation(Required=false)]
            public long? Position { get; set; }

            /// <summary>
            /// 字段中文名称
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// 字段英文名称
            /// </summary>
            [NameInMap("valueEn")]
            [Validation(Required=false)]
            public string ValueEn { get; set; }

        }

        /// <summary>
        /// 请求id，每次请求都是唯一值，便于后续排查问题
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// true或者false
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
