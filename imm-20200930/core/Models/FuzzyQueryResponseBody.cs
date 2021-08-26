// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class FuzzyQueryResponseBody : TeaModel {
        /// <summary>
        /// 表示当前调用返回读取到的位置，空代表数据已经读取完毕
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 本次请求的唯一 Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<File> Files { get; set; }

    }

}
