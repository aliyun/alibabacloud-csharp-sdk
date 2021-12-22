// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class ListGamesResponseBody : TeaModel {
        /// <summary>
        /// 总记录数
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// 数据列表
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<ListGamesResponseBodyDataList> DataList { get; set; }
        public class ListGamesResponseBodyDataList : TeaModel {
            /// <summary>
            /// 游戏ID
            /// </summary>
            [NameInMap("GameId")]
            [Validation(Required=false)]
            public string GameId { get; set; }

            /// <summary>
            /// 游戏名称
            /// </summary>
            [NameInMap("GameName")]
            [Validation(Required=false)]
            public string GameName { get; set; }

            /// <summary>
            /// 平台类型
            /// </summary>
            [NameInMap("PlatformType")]
            [Validation(Required=false)]
            public long? PlatformType { get; set; }

        }

        /// <summary>
        /// 本次请求所返回的最大记录条数
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 表示当前调用返回读取到的位置，空代表数据已经读取完毕
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
