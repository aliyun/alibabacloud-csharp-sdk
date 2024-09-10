// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifyHybridMonitorSLSGroupRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The configurations of the Logstore group.
        /// 
        /// Valid values of N: 1 to 25.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SLSGroupConfig")]
        [Validation(Required=false)]
        public List<ModifyHybridMonitorSLSGroupRequestSLSGroupConfig> SLSGroupConfig { get; set; }
        public class ModifyHybridMonitorSLSGroupRequestSLSGroupConfig : TeaModel {
            /// <summary>
            /// The Logstore.
            /// 
            /// Valid values of N: 1 to 25.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("SLSLogstore")]
            [Validation(Required=false)]
            public string SLSLogstore { get; set; }

            /// <summary>
            /// The Simple Log Service project.
            /// 
            /// Valid values of N: 1 to 25.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("SLSProject")]
            [Validation(Required=false)]
            public string SLSProject { get; set; }

            /// <summary>
            /// The region ID.
            /// 
            /// Valid values of N: 1 to 25.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("SLSRegion")]
            [Validation(Required=false)]
            public string SLSRegion { get; set; }

            /// <summary>
            /// The member ID.
            /// 
            /// Valid values of N: 1 to 25.
            /// 
            /// If you call this operation by using the management account of a resource directory, you can connect the Alibaba Cloud services that are activated for all members in the resource directory to Hybrid Cloud Monitoring. You can use the resource directory to monitor Alibaba Cloud services across enterprise accounts.
            /// 
            /// > If a member uses CloudMonitor for the first time, you must make sure that the service-linked role AliyunServiceRoleForCloudMonitor is attached to the member. For more information, see [Manage the service-linked role for CloudMonitor](https://help.aliyun.com/document_detail/170423.html).
            /// </summary>
            [NameInMap("SLSUserId")]
            [Validation(Required=false)]
            public string SLSUserId { get; set; }

        }

        /// <summary>
        /// The description of the Logstore group.
        /// </summary>
        [NameInMap("SLSGroupDescription")]
        [Validation(Required=false)]
        public string SLSGroupDescription { get; set; }

        /// <summary>
        /// The name of the Logstore group.
        /// 
        /// For information about how to obtain the name of a Logstore group, see [DescribeHybridMonitorSLSGroup](https://help.aliyun.com/document_detail/429526.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SLSGroupName")]
        [Validation(Required=false)]
        public string SLSGroupName { get; set; }

    }

}
