// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class StatisQueryByDayResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// 是否请求成功
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// 返回集合
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<StatisQueryByDayResponseBodyList> List { get; set; }
        public class StatisQueryByDayResponseBodyList : TeaModel {
            /// <summary>
            /// 是否已发布 0:未发布 1：已发布
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// 当前类型数量
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// 日期格式yyyy-MM-dd
            /// </summary>
            [NameInMap("Day")]
            [Validation(Required=false)]
            public string Day { get; set; }

        }

    }

}
