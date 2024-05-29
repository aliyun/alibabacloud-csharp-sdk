// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DeleteConsumerChannelRequest : TeaModel {
        /// <summary>
        /// The ID of the consumer group. You can call the [DescribeConsumerChannel](https://help.aliyun.com/document_detail/264169.html) operation to query the consumer group ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConsumerGroupId")]
        [Validation(Required=false)]
        public string ConsumerGroupId { get; set; }

        /// <summary>
        /// The ID of the change tracking instance. You can call the [DescribeDtsJobs](https://help.aliyun.com/document_detail/209702.html) operation to query the instance ID.
        /// 
        /// >  You must specify at least one of the **DtsInstanceId** and **DtsJobId** parameters.
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// The ID of the change tracking task. You can call the [DescribeDtsJobs](https://help.aliyun.com/document_detail/209702.html) operation to query the task ID.
        /// 
        /// >  You must specify at least one of the **DtsInstanceId** and **DtsJobId** parameters.
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// The ID of the region where the change tracking instance resides. For more information, see [List of supported regions](https://help.aliyun.com/document_detail/141033.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
