// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class CreateAppSessionRequest : TeaModel {
        /// <summary>
        /// 适配文件ID。此功能灰度开放，如未约定使用请勿传入。
        /// </summary>
        [NameInMap("AdapterFileId")]
        [Validation(Required=false)]
        public string AdapterFileId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CustomSessionId")]
        [Validation(Required=false)]
        public string CustomSessionId { get; set; }

        [NameInMap("CustomUserId")]
        [Validation(Required=false)]
        public string CustomUserId { get; set; }

        [NameInMap("DistrictId")]
        [Validation(Required=false)]
        public string DistrictId { get; set; }

        [NameInMap("EnablePostpaid")]
        [Validation(Required=false)]
        public bool? EnablePostpaid { get; set; }

        /// <summary>
        /// 项目ID。如果已将应用关联到项目，创建会话时需填写正确的项目ID。
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("StartParameters")]
        [Validation(Required=false)]
        public List<CreateAppSessionRequestStartParameters> StartParameters { get; set; }
        public class CreateAppSessionRequestStartParameters : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("SystemInfo")]
        [Validation(Required=false)]
        public List<CreateAppSessionRequestSystemInfo> SystemInfo { get; set; }
        public class CreateAppSessionRequestSystemInfo : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

    }

}
