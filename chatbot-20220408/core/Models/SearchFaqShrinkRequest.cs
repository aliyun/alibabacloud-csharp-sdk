// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class SearchFaqShrinkRequest : TeaModel {
        /// <summary>
        /// 业务空间key,不设置则访问默认业务空间，key值在主账号业务管理页面获取
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// 类目唯一标识
        /// </summary>
        [NameInMap("CategoryIds")]
        [Validation(Required=false)]
        public string CategoryIdsShrink { get; set; }

        /// <summary>
        /// 创建开始时间
        /// </summary>
        [NameInMap("CreateTimeBegin")]
        [Validation(Required=false)]
        public string CreateTimeBegin { get; set; }

        /// <summary>
        /// 创建结束时间
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [NameInMap("CreateUserName")]
        [Validation(Required=false)]
        public string CreateUserName { get; set; }

        /// <summary>
        /// 失效开始时间
        /// </summary>
        [NameInMap("EndTimeBegin")]
        [Validation(Required=false)]
        public string EndTimeBegin { get; set; }

        /// <summary>
        /// 失效结束时间
        /// </summary>
        [NameInMap("EndTimeEnd")]
        [Validation(Required=false)]
        public string EndTimeEnd { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// 修改开始时间
        /// </summary>
        [NameInMap("ModifyTimeBegin")]
        [Validation(Required=false)]
        public string ModifyTimeBegin { get; set; }

        /// <summary>
        /// 修改结束时间
        /// </summary>
        [NameInMap("ModifyTimeEnd")]
        [Validation(Required=false)]
        public string ModifyTimeEnd { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [NameInMap("ModifyUserName")]
        [Validation(Required=false)]
        public string ModifyUserName { get; set; }

        /// <summary>
        /// 页码 默认1
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 每页数量，默认10，最大50
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 搜索范围： 1-搜索标题相似问, 2-搜索答案, 3-搜索全部
        /// </summary>
        [NameInMap("SearchScope")]
        [Validation(Required=false)]
        public int? SearchScope { get; set; }

        /// <summary>
        /// 生效开始时间
        /// </summary>
        [NameInMap("StartTimeBegin")]
        [Validation(Required=false)]
        public string StartTimeBegin { get; set; }

        /// <summary>
        /// 生效结束时间
        /// </summary>
        [NameInMap("StartTimeEnd")]
        [Validation(Required=false)]
        public string StartTimeEnd { get; set; }

        /// <summary>
        /// 知识状态: -1-已删除未发布, 1-未发布, 2-已发布, 3-已更新未发布
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
