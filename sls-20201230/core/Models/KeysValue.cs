// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class KeysValue : TeaModel {
        /// <summary>
        /// 大小写敏感
        /// </summary>
        [NameInMap("caseSensitive")]
        [Validation(Required=false)]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// 包含中文
        /// </summary>
        [NameInMap("chn")]
        [Validation(Required=false)]
        public bool? Chn { get; set; }

        /// <summary>
        /// 字段的索引类型
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// 别名
        /// </summary>
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// 分词符列表。仅当type参数取值为text时，必须设置。
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public List<string> Token { get; set; }

        /// <summary>
        /// 开启统计
        /// </summary>
        [NameInMap("doc_value")]
        [Validation(Required=false)]
        public bool? DocValue { get; set; }

    }

}
