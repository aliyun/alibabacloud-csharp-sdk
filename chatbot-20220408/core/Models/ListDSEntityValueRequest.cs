// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListDSEntityValueRequest : TeaModel {
        /// <summary>
        /// 业务空间key,不设置则访问默认业务空间，key值在主账号业务管理页面获取
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// 实体ID
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        /// <summary>
        /// 实体成员ID
        /// </summary>
        [NameInMap("EntityValueId")]
        [Validation(Required=false)]
        public long? EntityValueId { get; set; }

        /// <summary>
        /// 机器人ID
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 实体成员名称搜索关键词
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
