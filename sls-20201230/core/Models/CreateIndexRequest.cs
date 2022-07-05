// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateIndexRequest : TeaModel {
        [NameInMap("keys")]
        [Validation(Required=false)]
        public Dictionary<string, KeysValue> Keys { get; set; }

        /// <summary>
        /// 配置全文索引
        /// </summary>
        [NameInMap("line")]
        [Validation(Required=false)]
        public CreateIndexRequestLine Line { get; set; }
        public class CreateIndexRequestLine : TeaModel {
            [NameInMap("caseSensitive")]
            [Validation(Required=false)]
            public bool? CaseSensitive { get; set; }
            [NameInMap("chn")]
            [Validation(Required=false)]
            public bool? Chn { get; set; }
            [NameInMap("exclude_keys")]
            [Validation(Required=false)]
            public List<string> ExcludeKeys { get; set; }
            [NameInMap("include_keys")]
            [Validation(Required=false)]
            public List<string> IncludeKeys { get; set; }
            [NameInMap("token")]
            [Validation(Required=false)]
            public List<string> Token { get; set; }
        };

        /// <summary>
        /// 开启日志聚类，开启后白名单与黑名单至多生效其中一个。
        /// </summary>
        [NameInMap("log_reduce")]
        [Validation(Required=false)]
        public bool? LogReduce { get; set; }

        /// <summary>
        /// 日志聚类的聚类字段黑名单
        /// </summary>
        [NameInMap("log_reduce_black_list")]
        [Validation(Required=false)]
        public List<string> LogReduceBlackList { get; set; }

        /// <summary>
        /// 日志聚类的聚类字段白名单
        /// </summary>
        [NameInMap("log_reduce_white_list")]
        [Validation(Required=false)]
        public List<string> LogReduceWhiteList { get; set; }

        /// <summary>
        /// 统计字段的最大长度
        /// </summary>
        [NameInMap("max_text_len")]
        [Validation(Required=false)]
        public int? MaxTextLen { get; set; }

        /// <summary>
        /// 保存时间，单位为天
        /// </summary>
        [NameInMap("ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
