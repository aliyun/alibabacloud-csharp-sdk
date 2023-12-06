// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class HandleSimilarSecurityEventsRequest : TeaModel {
        /// <summary>
        /// The whitelist rule. For example, if you want to add a file that contains the string a to the whitelist based on the MD5 hash value, set this parameter to {"field":"md5","operate":"contains","fieldValue":"aa"}.
        /// </summary>
        [NameInMap("MarkMissParam")]
        [Validation(Required=false)]
        public string MarkMissParam { get; set; }

        /// <summary>
        /// The operation that you want to perform to handle the alert events.
        /// 
        /// >  You can call the [DescribeSecurityEventOperations](~~DescribeSecurityEventOperations~~) operation to query the operations.
        /// </summary>
        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

        /// <summary>
        /// The configuration of the operation that you want to perform to handle the alert events. The value of this parameter is in the JSON format.
        /// 
        /// >  If you set **OperationCode** to **kill\_and\_quara**, **block\_ip**, or **virus\_quara**, you must specify OperationParams. If you set **OperationCode** to other values, you can leave OperationParams empty. If you set **OperationCode** to **block_ip**, the value of OperationParams must consist of the following fields:
        /// 
        /// > *   **expireTime**: the end time of locking. Unit: milliseconds.
        /// 
        /// >  If you set **OperationCode** to **kill\_and_quara**, the value of OperationParams must consist of the following fields:
        /// 
        /// > *   **subOperation**: the method of detection and removal. Valid values:
        /// 
        /// >     *   **killAndQuaraFileByMd5andPath**: terminates the process and quarantines the source file of the process.
        /// >     *   **killByMd5andPath**: terminates the running process.
        /// 
        /// >  If you set **OperationCode** to **virus_quara**, the value of OperationParams consists of the following fields:
        /// 
        /// > *   **subOperation**: the method of detection and removal. Valid values:
        /// 
        /// >     *   **quaraFileByMd5andPath**: quarantines the source file of the process.
        /// </summary>
        [NameInMap("OperationParams")]
        [Validation(Required=false)]
        public string OperationParams { get; set; }

        /// <summary>
        /// The remark of the operation.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The ID of the task that handles the alert events at a time.
        /// 
        /// >  You can call the [CreateSimilarSecurityEventsQueryTask](~~CreateSimilarSecurityEventsQueryTask~~) operation to query the IDs of tasks.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
