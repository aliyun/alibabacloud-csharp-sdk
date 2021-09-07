// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListAppTemplatesResponseBody : TeaModel {
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
        public ListAppTemplatesResponseBodyResult Result { get; set; }
        public class ListAppTemplatesResponseBodyResult : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("PageTotal")]
            [Validation(Required=false)]
            public int? PageTotal { get; set; }
            [NameInMap("AppTemplateInfoList")]
            [Validation(Required=false)]
            public List<ListAppTemplatesResponseBodyResultAppTemplateInfoList> AppTemplateInfoList { get; set; }
            public class ListAppTemplatesResponseBodyResultAppTemplateInfoList : TeaModel {
                public string AppTemplateId { get; set; }
                public string AppTemplateName { get; set; }
                public string AppTemplateCreator { get; set; }
                public string Status { get; set; }
                public List<string> ComponentList { get; set; }
                public string CreateTime { get; set; }
                public string SdkInfo { get; set; }
                public List<ListAppTemplatesResponseBodyResultAppTemplateInfoListConfigList> ConfigList { get; set; }
                public class ListAppTemplatesResponseBodyResultAppTemplateInfoListConfigList : TeaModel {
                    public string Key { get; set; }
                    public string Value { get; set; }
                }
                public string Scene { get; set; }
                public string IntegrationMode { get; set; }
                public string StandardRoomInfo { get; set; }
            }
        };

    }

}
