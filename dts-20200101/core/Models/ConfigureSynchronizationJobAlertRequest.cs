// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ConfigureSynchronizationJobAlertRequest : TeaModel {
        /// <summary>
        /// The ID of the Alibaba Cloud account. You do not need to specify this parameter because this parameter will be removed in the future.
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The mobile phone numbers that receive latency-related alerts. Separate mobile phone numbers with commas (,).
        /// 
        /// > 
        /// *   This parameter is available only for China site (aliyun.com) users. Only mobile phone numbers in the Chinese mainland are supported. Up to 10 mobile phone numbers can be specified.
        /// *   International site (alibabacloud.com) users cannot receive alerts by using mobile phones, but can [set alert rules for DTS tasks in the Cloud Monitor console](https://help.aliyun.com/document_detail/175876.html).
        /// </summary>
        [NameInMap("DelayAlertPhone")]
        [Validation(Required=false)]
        public string DelayAlertPhone { get; set; }

        /// <summary>
        /// Specifies whether to monitor task latency. Valid values:
        /// 
        /// *   **enable**: yes
        /// *   **disable**: no
        /// 
        /// > 
        /// *   The default value is **enable**.
        /// *   You must specify at least one of the DelayAlertStatus and **ErrorAlertStatus** parameters.
        /// </summary>
        [NameInMap("DelayAlertStatus")]
        [Validation(Required=false)]
        public string DelayAlertStatus { get; set; }

        /// <summary>
        /// The threshold for triggering latency alerts. The unit is seconds and the value must be an integer. You can set the threshold based on your business needs. To avoid delay fluctuations caused by network and database loads, we recommend that you set the threshold to more than 10 seconds.
        /// 
        /// >  If the **DelayAlertStatus** parameter is set to **enable**, this parameter must be specified.
        /// </summary>
        [NameInMap("DelayOverSeconds")]
        [Validation(Required=false)]
        public string DelayOverSeconds { get; set; }

        /// <summary>
        /// The mobile phone numbers that receive status-related alerts. Separate mobile phone numbers with commas (,).
        /// 
        /// > 
        /// *   This parameter is available only for China site (aliyun.com) users. Only mobile phone numbers in the Chinese mainland are supported. Up to 10 mobile phone numbers can be specified.
        /// *   International site (alibabacloud.com) users cannot receive alerts by using mobile phones, but can [set alert rules for DTS tasks in the Cloud Monitor console](https://help.aliyun.com/document_detail/175876.html).
        /// </summary>
        [NameInMap("ErrorAlertPhone")]
        [Validation(Required=false)]
        public string ErrorAlertPhone { get; set; }

        /// <summary>
        /// Specifies whether to monitor task status. Valid values:
        /// 
        /// *   **enable**: yes
        /// *   **disable**: no
        /// 
        /// > 
        /// *   The default value is **enable**.
        /// *   You must specify at least one of the **DelayAlertStatus** and ErrorAlertStatus parameters.
        /// *   If the task that you monitor enters an abnormal state, an alert is triggered.
        /// </summary>
        [NameInMap("ErrorAlertStatus")]
        [Validation(Required=false)]
        public string ErrorAlertStatus { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The synchronization direction. Valid values:
        /// 
        /// *   **Forward**
        /// *   **Reverse**
        /// 
        /// >  Default value: **Forward**.
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        /// <summary>
        /// The ID of the data synchronization instance. You can call the DescribeSynchronizationJobs operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SynchronizationJobId")]
        [Validation(Required=false)]
        public string SynchronizationJobId { get; set; }

    }

}
