// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class ListPwnedPasswordsResponseBody : TeaModel {
        [NameInMap("PwnedPasswordInfos")]
        [Validation(Required=false)]
        public List<ListPwnedPasswordsResponseBodyPwnedPasswordInfos> PwnedPasswordInfos { get; set; }
        public class ListPwnedPasswordsResponseBodyPwnedPasswordInfos : TeaModel {
            /// <summary>
            /// 泄露密码SHA1值
            /// </summary>
            [NameInMap("HexPasswordSha1Hash")]
            [Validation(Required=false)]
            public string HexPasswordSha1Hash { get; set; }

            /// <summary>
            /// 泄露次数
            /// </summary>
            [NameInMap("PwnedCount")]
            [Validation(Required=false)]
            public long? PwnedCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回列表长度
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
