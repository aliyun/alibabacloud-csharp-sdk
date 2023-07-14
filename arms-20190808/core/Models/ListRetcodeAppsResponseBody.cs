// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListRetcodeAppsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of applications monitored by Browser Monitoring.
        /// </summary>
        [NameInMap("RetcodeApps")]
        [Validation(Required=false)]
        public List<ListRetcodeAppsResponseBodyRetcodeApps> RetcodeApps { get; set; }
        public class ListRetcodeAppsResponseBodyRetcodeApps : TeaModel {
            /// <summary>
            /// The ID of the application. The parameter is an auto-increment parameter.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            /// <summary>
            /// The name of the application.
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// The alias of the application monitored by Browser Monitoring.
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// The PID of the application.
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The type of the application. Valid values:
            /// 
            /// *   `web`: web application
            /// *   `weex`: Weex mobile app
            /// *   `mini_dd`: DingTalk mini program
            /// *   `mini_alipay`: Alipay mini program
            /// *   `mini_wx`: WeChat mini program
            /// *   `mini_common`: mini program on other platforms
            /// </summary>
            [NameInMap("RetcodeAppType")]
            [Validation(Required=false)]
            public string RetcodeAppType { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListRetcodeAppsResponseBodyRetcodeAppsTags> Tags { get; set; }
            public class ListRetcodeAppsResponseBodyRetcodeAppsTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
