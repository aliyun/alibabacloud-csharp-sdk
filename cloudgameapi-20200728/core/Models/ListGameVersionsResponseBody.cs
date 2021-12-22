// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class ListGameVersionsResponseBody : TeaModel {
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
        public List<ListGameVersionsResponseBodyDataList> DataList { get; set; }
        public class ListGameVersionsResponseBodyDataList : TeaModel {
            /// <summary>
            /// 版本ID
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

            /// <summary>
            /// 版本名称
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

            /// <summary>
            /// 版本号
            /// </summary>
            [NameInMap("VersionNumber")]
            [Validation(Required=false)]
            public string VersionNumber { get; set; }

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
