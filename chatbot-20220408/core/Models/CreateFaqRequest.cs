// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateFaqRequest : TeaModel {
        /// <summary>
        /// 业务空间key,不设置则访问默认业务空间，key值在主账号业务管理页面获取
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// 知识的类目ID
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// 默认答案内容
        /// </summary>
        [NameInMap("SolutionContent")]
        [Validation(Required=false)]
        public string SolutionContent { get; set; }

        /// <summary>
        /// 默认答案类型
        /// </summary>
        [NameInMap("SolutionType")]
        [Validation(Required=false)]
        public int? SolutionType { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// 知识标题
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
