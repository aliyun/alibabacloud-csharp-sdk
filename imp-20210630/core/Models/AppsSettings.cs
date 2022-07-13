// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class AppsSettings : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 云帐号Id
        /// </summary>
        [NameInMap("CloudUid")]
        [Validation(Required=false)]
        public string CloudUid { get; set; }

        /// <summary>
        /// 客户非敏感信息
        /// </summary>
        [NameInMap("Customer")]
        [Validation(Required=false)]
        public CommonCustomer Customer { get; set; }

        /// <summary>
        /// 互动视频配置
        /// </summary>
        [NameInMap("InteractiveVideoSettings")]
        [Validation(Required=false)]
        public AppsInteractiveVideoSettings InteractiveVideoSettings { get; set; }

    }

}
