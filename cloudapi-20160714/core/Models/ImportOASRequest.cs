// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ImportOASRequest : TeaModel {
        /// <summary>
        /// API安全认证类型，目前可以取值：
        /// 
        /// - **APP**：只允许已授权的APP调用
        /// - **ANONYMOUS**：允许匿名调用，设置为允许匿名调用需要注意：
        ///      - 任何能够获取该API服务信息的人，都将能够调用该API。网关不会对调用者做身份认证，也无法设置按用户的流量控制，若开放该API请设置好按API的流量控制。
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("BackendName")]
        [Validation(Required=false)]
        public string BackendName { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("IgnoreWarning")]
        [Validation(Required=false)]
        public bool? IgnoreWarning { get; set; }

        [NameInMap("OASVersion")]
        [Validation(Required=false)]
        public string OASVersion { get; set; }

        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        [NameInMap("RequestMode")]
        [Validation(Required=false)]
        public string RequestMode { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("SkipDryRun")]
        [Validation(Required=false)]
        public bool? SkipDryRun { get; set; }

    }

}
