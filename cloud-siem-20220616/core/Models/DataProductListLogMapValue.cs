/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DataProductListLogMapValue : TeaModel {
        /// <summary>
        /// The code of the log.
        /// </summary>
        [NameInMap("LogCode")]
        [Validation(Required=false)]
        public string LogCode { get; set; }

        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("LogName")]
        [Validation(Required=false)]
        public string LogName { get; set; }

        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("LogNameEn")]
        [Validation(Required=false)]
        public string LogNameEn { get; set; }

        /// <summary>
        /// The language code of the log that is used to indicate the language in which the log is displayed.
        /// </summary>
        [NameInMap("LogNameKey")]
        [Validation(Required=false)]
        public string LogNameKey { get; set; }

        /// <summary>
        /// The status of the log delivery. Valid values:
        /// 
        /// *   true: The logs are being delivered.
        /// *   false: The log delivery feature is disabled.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public bool? Status { get; set; }

        /// <summary>
        /// Indicates whether the log delivery feature can be enabled or disabled. The feature can be enabled or disabled only by the administrator of the threat analysis feature. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("CanOperateOrNot")]
        [Validation(Required=false)]
        public bool? CanOperateOrNot { get; set; }

        /// <summary>
        /// The topic of the log in the Logstore. The value is an index field in the Logstore that can be used to distinguish different logs.
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// The extended parameter.
        /// </summary>
        [NameInMap("ExtraParameters")]
        [Validation(Required=false)]
        public List<DataProductListLogMapValueExtraParameters> ExtraParameters { get; set; }
        public class DataProductListLogMapValueExtraParameters : TeaModel {
            /// <summary>
            /// The ID of the extended parameter.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the extended parameter.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
