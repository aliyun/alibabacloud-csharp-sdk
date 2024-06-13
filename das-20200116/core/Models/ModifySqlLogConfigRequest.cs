// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class ModifySqlLogConfigRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable DAS Enterprise Edition. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// >  This parameter is required if you want to enable DAS Enterprise Edition. By default, the latest version of DAS Enterprise Edition that supports the database instance is enabled.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// A reserved parameter.
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ModifySqlLogConfigRequestFilters> Filters { get; set; }
        public class ModifySqlLogConfigRequestFilters : TeaModel {
            /// <summary>
            /// A reserved parameter.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// A reserved parameter.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The number of days for which the SQL Explorer and Audit data is stored in hot storage. Valid values: 1 to 7.
        /// 
        /// >  This parameter is required if only DAS Enterprise Edition V3 can be enabled for the database instance.
        /// </summary>
        [NameInMap("HotRetention")]
        [Validation(Required=false)]
        public int? HotRetention { get; set; }

        /// <summary>
        /// The ID of the database instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Specifies whether to enable the SQL Explorer feature. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// >  This parameter is required if only DAS Enterprise Edition V3 can be enabled for the database instance.
        /// </summary>
        [NameInMap("RequestEnable")]
        [Validation(Required=false)]
        public bool? RequestEnable { get; set; }

        /// <summary>
        /// The total storage duration of the SQL Explorer and Audit data. Unit: day. Valid values:
        /// 
        /// *   7
        /// *   30
        /// *   180
        /// *   365
        /// 
        /// >  If you want to enable DAS Enterprise Edition V3, the value of this parameter must be greater than or equal to 30.
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public int? Retention { get; set; }

    }

}
