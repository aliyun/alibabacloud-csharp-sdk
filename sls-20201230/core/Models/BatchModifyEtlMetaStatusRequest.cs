// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class BatchModifyEtlMetaStatusRequest : TeaModel {
        /// <summary>
        /// 当 range 的值为 "list" 时有效，匹配list中的 metaKey
        /// </summary>
        [NameInMap("etlMetaKeyList")]
        [Validation(Required=false)]
        public List<string> EtlMetaKeyList { get; set; }

        [NameInMap("etlMetaName")]
        [Validation(Required=false)]
        public string EtlMetaName { get; set; }

        /// <summary>
        /// 匹配的 tag，当 tag 为 "__all_etl_meta_tag_match__" 时表示全部匹配。
        /// </summary>
        [NameInMap("etlMetaTag")]
        [Validation(Required=false)]
        public string EtlMetaTag { get; set; }

        /// <summary>
        /// 操作作用的范围，可选 all 代表匹配全部，list 按名单列表匹配 key 两种模式。
        /// </summary>
        [NameInMap("range")]
        [Validation(Required=false)]
        public string Range { get; set; }

        /// <summary>
        /// 操作类型，支持启用、禁用、删除三种，即 batch_enable、batch_disable、batch_delete。
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
