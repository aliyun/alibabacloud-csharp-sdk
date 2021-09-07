// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class GetAppTemplateResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetAppTemplateResponseBodyResult Result { get; set; }
        public class GetAppTemplateResponseBodyResult : TeaModel {
            [NameInMap("AppTemplateName")]
            [Validation(Required=false)]
            public string AppTemplateName { get; set; }
            [NameInMap("AppTemplateCreator")]
            [Validation(Required=false)]
            public string AppTemplateCreator { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("ComponentList")]
            [Validation(Required=false)]
            public List<string> ComponentList { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("SdkInfo")]
            [Validation(Required=false)]
            public string SdkInfo { get; set; }
            [NameInMap("ConfigList")]
            [Validation(Required=false)]
            public List<GetAppTemplateResponseBodyResultConfigList> ConfigList { get; set; }
            public class GetAppTemplateResponseBodyResultConfigList : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }
            [NameInMap("IntegrationMode")]
            [Validation(Required=false)]
            public string IntegrationMode { get; set; }
            [NameInMap("StandardRoomInfo")]
            [Validation(Required=false)]
            public string StandardRoomInfo { get; set; }
        };

    }

}
