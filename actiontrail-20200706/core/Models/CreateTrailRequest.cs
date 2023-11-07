// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class CreateTrailRequest : TeaModel {
        /// <summary>
        /// The read/write type of the events to be delivered. Valid values:
        /// 
        /// *   Write: write events. It is the default value.
        /// *   Read: read events.
        /// *   All: read and write events.
        /// </summary>
        [NameInMap("EventRW")]
        [Validation(Required=false)]
        public string EventRW { get; set; }

        /// <summary>
        /// Specifies whether to create a multi-account trail. Valid values:
        /// 
        /// *   true: creates a multi-account trail.
        /// *   false (default): creates a single-account trail.
        /// </summary>
        [NameInMap("IsOrganizationTrail")]
        [Validation(Required=false)]
        public bool? IsOrganizationTrail { get; set; }

        /// <summary>
        /// The name of the trail to be created.
        /// 
        /// The name must be 6 to 36 characters in length. The name must start with a lowercase letter and can contain lowercase letters, digits, hyphens (-), and underscores (\_).
        /// 
        /// > The name must be unique within your Alibaba Cloud account.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The name of the OSS bucket to which events are to be delivered.
        /// 
        /// The name must be 3 to 63 characters in length. The name must start with a lowercase letter or a digit and can contain lowercase letters, digits, and hyphens (-).
        /// 
        /// > You must specify at least one of the OssBucketName and SlsProjectArn parameters.
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// The prefix of the log files to be stored in the destination OSS bucket. This parameter can be left empty.
        /// 
        /// The prefix must be 6 to 32 characters in length. The prefix must start with a letter and can contain letters, digits, hyphens (-), forward slashes (/), and underscores (\_).
        /// </summary>
        [NameInMap("OssKeyPrefix")]
        [Validation(Required=false)]
        public string OssKeyPrefix { get; set; }

        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the RAM role that is assumed by ActionTrail to deliver events to the OSS bucket.
        /// 
        /// *   If you do not specify this parameter, ActionTrail creates a service-linked role to create the required resources. For more information, see [Manage the service-linked role](~~169244~~).
        /// *   If you specify this parameter, you must grant the permissions of the service-linked role that is assumed by ActionTrail to the RAM role before you can deliver events to your Alibaba Cloud account. If you need to deliver events to other Alibaba Cloud accounts, you must attach the permission policy that is used to grant permissions related to event delivery to the RAM role. For more information about how to deliver events across Alibaba Cloud accounts, see [Deliver events across Alibaba Cloud accounts](~~207462~~).
        /// </summary>
        [NameInMap("OssWriteRoleArn")]
        [Validation(Required=false)]
        public string OssWriteRoleArn { get; set; }

        /// <summary>
        /// The ARN of the Log Service project to which events are to be delivered.
        /// 
        /// > You must specify at least one of the OssBucketName and SlsProjectArn parameters.
        /// </summary>
        [NameInMap("SlsProjectArn")]
        [Validation(Required=false)]
        public string SlsProjectArn { get; set; }

        /// <summary>
        /// The ARN of the RAM role that is assumed by ActionTrail to deliver events to the Log Service project.
        /// 
        /// *   If you do not specify this parameter, ActionTrail creates a service-linked role to create the corresponding resource. For more information, see [Manage the service-linked role](~~169244~~).
        /// *   If you specify this parameter, you must grant the permissions of the service-linked role that is assumed by ActionTrail to the RAM role before you can deliver events to your Alibaba Cloud account. If you need to deliver events to other Alibaba Cloud accounts, you must attach the permission policy that is used to grant permissions related to event delivery to the RAM role. For more information about how to deliver events across Alibaba Cloud accounts, see [Deliver events across Alibaba Cloud accounts](~~207462~~).
        /// </summary>
        [NameInMap("SlsWriteRoleArn")]
        [Validation(Required=false)]
        public string SlsWriteRoleArn { get; set; }

        /// <summary>
        /// The one or more regions from which the trail delivers events.
        /// 
        /// The default value is All, which indicates that the trail delivers events from all regions.
        /// 
        /// You can also specify specific regions. You can call the [DescribeRegions](~~213597~~) operation to query all the supported regions.
        /// </summary>
        [NameInMap("TrailRegion")]
        [Validation(Required=false)]
        public string TrailRegion { get; set; }

    }

}
