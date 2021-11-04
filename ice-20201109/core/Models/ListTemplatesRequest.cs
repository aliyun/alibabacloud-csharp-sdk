// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListTemplatesRequest : TeaModel {
        /// <summary>
        /// 创建来源
        /// </summary>
        [NameInMap("CreateSource")]
        [Validation(Required=false)]
        public string CreateSource { get; set; }

        /// <summary>
        /// 搜索关键词，可以根据模板id和title搜索
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// 排序参数，默认根据创建时间倒序
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        /// <summary>
        /// 模板状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 模板类型
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
