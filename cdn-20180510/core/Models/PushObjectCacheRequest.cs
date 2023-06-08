// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class PushObjectCacheRequest : TeaModel {
        /// <summary>
        /// The accelerated region where content is to be prefetched. Valid values:
        /// 
        /// *   **domestic****: Chinese mainland**
        /// *   **overseas****: regions outside the Chinese mainland**
        /// 
        /// If you do not set this parameter, content in the accelerated region of the domain name is prefetched.
        /// 
        /// *   If the accelerated region is set to **Mainland China Only**, content in regions in the Chinese mainland is prefetched.
        /// *   If the accelerated region is set to **Global**, content in all regions is prefetched.
        /// *   If the accelerated region is set to **Global (Excluding Mainland China)**, content in regions outside the Chinese mainland is prefetched.
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// Specifies whether to prefetch content to POPs. Valid values:
        /// 
        /// *   **true**: prefetches content to POPs.
        /// *   **false**: prefetches content to regular POPs. Regular POPs can be L2 POPs or L3 POPs. Default value: **false**.
        /// </summary>
        [NameInMap("L2Preload")]
        [Validation(Required=false)]
        public bool? L2Preload { get; set; }

        /// <summary>
        /// The URLs based on which content is prefetched. Format: **accelerated domain name/files to be prefetched**.
        /// 
        /// > Separate URLs with line feeds (\n or \r\n). Each object path can be up to 1,024 characters in length.
        /// </summary>
        [NameInMap("ObjectPath")]
        [Validation(Required=false)]
        public string ObjectPath { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The custom header for prefetch in the JSON format.
        /// </summary>
        [NameInMap("WithHeader")]
        [Validation(Required=false)]
        public string WithHeader { get; set; }

    }

}
