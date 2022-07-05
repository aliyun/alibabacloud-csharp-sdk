// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetIndexResponseBody : TeaModel {
        /// <summary>
        /// 索引模式
        /// </summary>
        [NameInMap("index_mode")]
        [Validation(Required=false)]
        public string IndexMode { get; set; }

        /// <summary>
        /// 字段索引配置。key为字段名称，value为索引配置。
        /// </summary>
        [NameInMap("keys")]
        [Validation(Required=false)]
        public Dictionary<string, KeysValue> Keys { get; set; }

        /// <summary>
        /// 上次修改时间
        /// </summary>
        [NameInMap("lastModifyTime")]
        [Validation(Required=false)]
        public long? LastModifyTime { get; set; }

        /// <summary>
        /// 配置全文索引。
        /// </summary>
        [NameInMap("line")]
        [Validation(Required=false)]
        public GetIndexResponseBodyLine Line { get; set; }
        public class GetIndexResponseBodyLine : TeaModel {
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
        /// 是否开启日志聚类.
        /// </summary>
        [NameInMap("log_reduce")]
        [Validation(Required=false)]
        public bool? LogReduce { get; set; }

        /// <summary>
        /// 日志聚类的聚类字段过滤黑名单，仅当日志聚类开启时有效。
        /// </summary>
        [NameInMap("log_reduce_black_list")]
        [Validation(Required=false)]
        public List<string> LogReduceBlackList { get; set; }

        /// <summary>
        /// 日志聚类的聚类字段过滤白名单，仅当日志聚类开启时有效。
        /// </summary>
        [NameInMap("log_reduce_white_list")]
        [Validation(Required=false)]
        public List<string> LogReduceWhiteList { get; set; }

        /// <summary>
        /// 日志服务默认字段值的最大长度为2048字节，即2 KB。如果您需要修改字段值的最大长度，可设置统计字段（text）最大长度，取值范围为64~16384字节。
        /// </summary>
        [NameInMap("max_text_len")]
        [Validation(Required=false)]
        public int? MaxTextLen { get; set; }

        /// <summary>
        /// 存储类型，目前固定取值为pg。
        /// </summary>
        [NameInMap("storage")]
        [Validation(Required=false)]
        public string Storage { get; set; }

        /// <summary>
        /// 索引文件生命周期，支持7天、30天、90天。
        /// </summary>
        [NameInMap("ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
