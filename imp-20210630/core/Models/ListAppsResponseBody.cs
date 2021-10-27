// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListAppsResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回结果体
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListAppsResponseBodyResult Result { get; set; }
        public class ListAppsResponseBodyResult : TeaModel {
            [NameInMap("AppInfoList")]
            [Validation(Required=false)]
            public List<ListAppsResponseBodyResultAppInfoList> AppInfoList { get; set; }
            public class ListAppsResponseBodyResultAppInfoList : TeaModel {
                public string AppConfigStatus { get; set; }
                public string AppId { get; set; }
                public string AppKey { get; set; }
                public string AppName { get; set; }
                public string AppStatus { get; set; }
                public string AppTemplateId { get; set; }
                public string AppTemplateName { get; set; }
                public List<string> ComponentList { get; set; }
                public string CreateTime { get; set; }
                public string IntegrationMode { get; set; }
                public string StandardRoomInfo { get; set; }
            }
            [NameInMap("PageTotal")]
            [Validation(Required=false)]
            public int? PageTotal { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

    }

}
