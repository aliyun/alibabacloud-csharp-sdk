// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRetcodeAppByPidResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned application data.
        /// </summary>
        [NameInMap("RetcodeApp")]
        [Validation(Required=false)]
        public GetRetcodeAppByPidResponseBodyRetcodeApp RetcodeApp { get; set; }
        public class GetRetcodeAppByPidResponseBodyRetcodeApp : TeaModel {
            /// <summary>
            /// The ID of the application. The parameter is an auto-increment parameter.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The name of the application that is monitored by Browser Monitoring.
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// The process identifier (PID) of the application.
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// The ID of the resource group. You can obtain the resource group ID in the **Resource Management** console.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The type of the application that is monitored by Browser Monitoring. Valid values:
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
            /// The tags that are attached to the instance.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetRetcodeAppByPidResponseBodyRetcodeAppTags> Tags { get; set; }
            public class GetRetcodeAppByPidResponseBodyRetcodeAppTags : TeaModel {
                /// <summary>
                /// The key of the tag.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the tag.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
