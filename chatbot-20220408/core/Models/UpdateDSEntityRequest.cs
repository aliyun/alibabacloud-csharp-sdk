// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class UpdateDSEntityRequest : TeaModel {
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
        /// 实体名称，仅支持中文、大小写字母、数字、下划线
        /// </summary>
        [NameInMap("EntityName")]
        [Validation(Required=false)]
        public string EntityName { get; set; }

        /// <summary>
        /// 实体类型：详见:,EntityTypeEnum[synonyms(同义词),regex(正则)]
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// 机器人ID
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
