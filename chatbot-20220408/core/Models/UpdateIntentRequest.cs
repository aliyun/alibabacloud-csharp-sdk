// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class UpdateIntentRequest : TeaModel {
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

        /// <summary>
        /// 意图定义结构体
        /// </summary>
        [NameInMap("IntentDefinition")]
        [Validation(Required=false)]
        public UpdateIntentRequestIntentDefinition IntentDefinition { get; set; }
        public class UpdateIntentRequestIntentDefinition : TeaModel {
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }
            [NameInMap("IntentName")]
            [Validation(Required=false)]
            public string IntentName { get; set; }
            [NameInMap("SlotInfos")]
            [Validation(Required=false)]
            public List<UpdateIntentRequestIntentDefinitionSlotInfos> SlotInfos { get; set; }
            public class UpdateIntentRequestIntentDefinitionSlotInfos : TeaModel {
                public bool? Array { get; set; }
                public bool? Encrypt { get; set; }
                public bool? Interactive { get; set; }
                public string Name { get; set; }
                public string SlotId { get; set; }
                public string Value { get; set; }
            }
        };

        /// <summary>
        /// 意图ID
        /// </summary>
        [NameInMap("IntentId")]
        [Validation(Required=false)]
        public long? IntentId { get; set; }

    }

}
