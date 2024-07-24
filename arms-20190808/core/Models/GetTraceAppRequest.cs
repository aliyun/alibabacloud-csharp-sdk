// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetTraceAppRequest : TeaModel {
        /// <summary>
        /// The process identifier (PID) of the application. For more information about how to obtain the PID, see [Obtain the PID of an application](https://www.alibabacloud.com/help/zh/doc-detail/186100.htm?spm=a2cdw.13409063.0.0.7a72281f0bkTfx#title-imy-7gj-qhr).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// 标签。
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetTraceAppRequestTags> Tags { get; set; }
        public class GetTraceAppRequestTags : TeaModel {
            /// <summary>
            /// 标签的键（key）。
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// 标签的值（value）。
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
