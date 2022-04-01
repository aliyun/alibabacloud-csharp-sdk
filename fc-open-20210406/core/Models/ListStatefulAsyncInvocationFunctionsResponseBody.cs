// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListStatefulAsyncInvocationFunctionsResponseBody : TeaModel {
        /// <summary>
        /// 返回的实际数据列表。
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<AsyncConfigMeta> Data { get; set; }

        /// <summary>
        /// 用来表示当前调用返回读取到的位置，空代表数据已经读取完毕。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
