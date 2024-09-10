// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateMonitorGroupInstancesRequest : TeaModel {
        /// <summary>
        /// The ID of the application group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The instances that you want to add to the application group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<CreateMonitorGroupInstancesRequestInstances> Instances { get; set; }
        public class CreateMonitorGroupInstancesRequestInstances : TeaModel {
            /// <summary>
            /// The abbreviation of the Alibaba Cloud service name.
            /// 
            /// To obtain the abbreviation of an Alibaba Cloud service name, call the [DescribeProjectMeta](https://help.aliyun.com/document_detail/114916.html) operation. The `metricCategory` tag in the `Labels` response parameter indicates the abbreviation of the Alibaba Cloud service name.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The instance ID.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The instance name.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The region ID of the instance.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
