// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateHybridMonitorSLSGroupRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SLSGroupConfig")]
        [Validation(Required=false)]
        public List<CreateHybridMonitorSLSGroupRequestSLSGroupConfig> SLSGroupConfig { get; set; }
        public class CreateHybridMonitorSLSGroupRequestSLSGroupConfig : TeaModel {
            /// <summary>
            /// The name of the Logstore group.
            /// 
            /// The name must be 2 to 32 characters in length and can contain uppercase letters, lowercase letters, digits, and underscores (\_). The name must start with a letter.
            /// </summary>
            [NameInMap("SLSLogstore")]
            [Validation(Required=false)]
            public string SLSLogstore { get; set; }

            /// <summary>
            /// The IDs of the member accounts.
            /// 
            /// Valid values of N: 1 to 25.
            /// 
            /// If you call API operations by using a management account, you can connect the Alibaba Cloud services that are activated for a member account in Resource Directory to Hybrid Cloud Monitoring. You can use Resource Directory to monitor Alibaba Cloud services across enterprise accounts.
            /// 
            /// >  If a member uses CloudMonitor for the first time, you must make sure that the service-linked role AliyunServiceRoleForCloudMonitor is attached to the member. For more information, see [Manage the service-linked role for CloudMonitor](~~170423~~).
            /// </summary>
            [NameInMap("SLSProject")]
            [Validation(Required=false)]
            public string SLSProject { get; set; }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("SLSRegion")]
            [Validation(Required=false)]
            public string SLSRegion { get; set; }

            /// <summary>
            /// The Logstores.
            /// 
            /// Valid values of N: 1 to 25.
            /// </summary>
            [NameInMap("SLSUserId")]
            [Validation(Required=false)]
            public string SLSUserId { get; set; }

        }

        /// <summary>
        /// The operation that you want to perform. Set the value to **CreateHybridMonitorSLSGroup**.
        /// </summary>
        [NameInMap("SLSGroupDescription")]
        [Validation(Required=false)]
        public string SLSGroupDescription { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call is successful.
        /// </summary>
        [NameInMap("SLSGroupName")]
        [Validation(Required=false)]
        public string SLSGroupName { get; set; }

    }

}
