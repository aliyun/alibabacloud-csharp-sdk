// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyConsumerChannelRequest : TeaModel {
        /// <summary>
        /// The ID of the consumer group. You can call the [DescribeConsumerChannel](~~264169~~) operation to query the consumer group ID.
        /// </summary>
        [NameInMap("ConsumerGroupId")]
        [Validation(Required=false)]
        public string ConsumerGroupId { get; set; }

        /// <summary>
        /// The name of the consumer group. The name cannot exceed 128 characters in length. We recommend that you use an informative name for easy identification.
        /// </summary>
        [NameInMap("ConsumerGroupName")]
        [Validation(Required=false)]
        public string ConsumerGroupName { get; set; }

        /// <summary>
        /// The new password of the consumer group.
        /// 
        /// *   A password must contain two or more of the following characters: uppercase letters, lowercase letters, digits, and special characters.
        /// *   A password must be 8 to 32 characters in length.
        /// </summary>
        [NameInMap("ConsumerGroupPassword")]
        [Validation(Required=false)]
        public string ConsumerGroupPassword { get; set; }

        /// <summary>
        /// The new username of the consumer group.
        /// 
        /// *   A username can contain one or more of the following character types: uppercase letters, lowercase letters, digits, and underscores (\_).
        /// *   A username cannot exceed 16 characters in length.
        /// </summary>
        [NameInMap("ConsumerGroupUserName")]
        [Validation(Required=false)]
        public string ConsumerGroupUserName { get; set; }

        /// <summary>
        /// The ID of the change tracking instance. You can call the [DescribeDtsJobs](~~209702~~) operation to query the instance ID.
        /// 
        /// >  You must specify at least one of the **DtsInstanceId** and **DtsJobId** parameters.
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// The ID of the change tracking task. You can call the [DescribeDtsJobs](~~209702~~) operation to query the task ID.
        /// 
        /// >  You must specify at least one of the **DtsInstanceId** and **DtsJobId** parameters.
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// The ID of the region where the change tracking instance resides. For more information, see [List of supported regions](~~141033~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
