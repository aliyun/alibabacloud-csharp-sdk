// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CreateRobotTaskRequest : TeaModel {
        /// <summary>
        /// The calling number.
        /// 
        /// You must use the phone numbers that you have purchased and separate multiple numbers with commas (,). You can log on to the [Voice Messaging Service console](https://dyvms.console.aliyun.com/overview/home) and choose **Real Number Service** > **Real Number Management** to view the numbers you purchased.
        /// </summary>
        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        /// <summary>
        /// The company name, which must be the same as the **enterprise name** on the qualification management page.
        /// </summary>
        [NameInMap("CorpName")]
        [Validation(Required=false)]
        public string CorpName { get; set; }

        /// <summary>
        /// The ID of the robot or communication script that is used to initiate the call.
        /// 
        /// You can log on to the [Voice Messaging Service console](https://dyvms.console.aliyun.com/overview/home) and choose **Intelligent Voice Robot** > **Communication Script Management** to view the communication script ID.
        /// </summary>
        [NameInMap("DialogId")]
        [Validation(Required=false)]
        public long? DialogId { get; set; }

        /// <summary>
        /// Specifies whether to call the self-managed line. Valid values:
        /// 
        /// *   **false** (default)
        /// *   **true**
        /// 
        /// > If you set this parameter to **true**, calling numbers are not verified.
        /// </summary>
        [NameInMap("IsSelfLine")]
        [Validation(Required=false)]
        public bool? IsSelfLine { get; set; }

        /// <summary>
        /// Specifies whether to enable number status identification. Valid values:
        /// 
        /// *   **false** (default)
        /// *   **true**
        /// 
        /// > If you set this parameter to **true**, the reason why a call is not answered is recorded.
        /// </summary>
        [NameInMap("NumberStatusIdent")]
        [Validation(Required=false)]
        public bool? NumberStatusIdent { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The redial interval. Unit: minutes. The value must be greater than 1.
        /// 
        /// > The maximum redial interval is 30 minutes.
        /// </summary>
        [NameInMap("RecallInterval")]
        [Validation(Required=false)]
        public int? RecallInterval { get; set; }

        /// <summary>
        /// The call state in which redial is required. Separate multiple call states with commas (,). Valid values:
        /// 
        /// *   **200010**: The phone of the called party is powered off.
        /// *   **200011**: The number of the called party is out of service.
        /// *   **200002**: The line is busy.
        /// *   **200012**: The call is lost.
        /// *   **200005**: The called party cannot be connected.
        /// *   **200003**: The called party does not respond to the call.
        /// </summary>
        [NameInMap("RecallStateCodes")]
        [Validation(Required=false)]
        public string RecallStateCodes { get; set; }

        /// <summary>
        /// The number of redial times.
        /// </summary>
        [NameInMap("RecallTimes")]
        [Validation(Required=false)]
        public int? RecallTimes { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-redial. Valid values:
        /// 
        /// *   **1**: enables auto-redial.
        /// *   **0**: disables auto-redial.
        /// </summary>
        [NameInMap("RetryType")]
        [Validation(Required=false)]
        public int? RetryType { get; set; }

        /// <summary>
        /// The task name. The task name can be up to 30 characters in length.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
