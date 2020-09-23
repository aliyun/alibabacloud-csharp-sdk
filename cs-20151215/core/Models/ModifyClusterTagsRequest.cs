// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterTagsRequest : TeaModel {
        /// <summary>
        /// 标签列表。
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<ModifyClusterTagsRequestBody> Body { get; set; }
        public class ModifyClusterTagsRequestBody : TeaModel {
            /// <summary>
            /// 标签名。
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// 标签值
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
