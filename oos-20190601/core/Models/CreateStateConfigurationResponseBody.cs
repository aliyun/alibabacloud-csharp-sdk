// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateStateConfigurationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StateConfiguration")]
        [Validation(Required=false)]
        public CreateStateConfigurationResponseBodyStateConfiguration StateConfiguration { get; set; }
        public class CreateStateConfigurationResponseBodyStateConfiguration : TeaModel {
            [NameInMap("ConfigureMode")]
            [Validation(Required=false)]
            public string ConfigureMode { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public Dictionary<string, string> Parameters { get; set; }
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }
            [NameInMap("ScheduleExpression")]
            [Validation(Required=false)]
            public string ScheduleExpression { get; set; }
            [NameInMap("ScheduleType")]
            [Validation(Required=false)]
            public string ScheduleType { get; set; }
            [NameInMap("StateConfigurationId")]
            [Validation(Required=false)]
            public string StateConfigurationId { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, string> Tags { get; set; }
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public string Targets { get; set; }
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }
        };

    }

}
