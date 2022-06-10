// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateUserSayRequest : TeaModel {
        /// <summary>
        /// 业务空间key,不设置则访问默认业务空间，key值在主账号业务管理页面获取
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// 机器人ID
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("UserSayDefinition")]
        [Validation(Required=false)]
        public CreateUserSayRequestUserSayDefinition UserSayDefinition { get; set; }
        public class CreateUserSayRequestUserSayDefinition : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }
            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public long? IntentId { get; set; }
            [NameInMap("SlotInfos")]
            [Validation(Required=false)]
            public List<CreateUserSayRequestUserSayDefinitionSlotInfos> SlotInfos { get; set; }
            public class CreateUserSayRequestUserSayDefinitionSlotInfos : TeaModel {
                public int? EndIndex { get; set; }
                public string SlotId { get; set; }
                public int? StartIndex { get; set; }
            }
        };

    }

}
