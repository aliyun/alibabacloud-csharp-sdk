// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateAntiBruteForceRuleRequest : TeaModel {
        /// <summary>
        /// Specifies whether to set the defense rule as the default rule. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// 
        /// >  If no defense rule is created for a server, the default rule is applied to the server.
        /// </summary>
        [NameInMap("DefaultRule")]
        [Validation(Required=false)]
        public bool? DefaultRule { get; set; }

        /// <summary>
        /// The maximum number of failed logon attempts from an account. Valid values: 2, 3, 4, 5, 10, 50, 80, and 100.
        /// </summary>
        [NameInMap("FailCount")]
        [Validation(Required=false)]
        public int? FailCount { get; set; }

        /// <summary>
        /// The period of time during which logons from an account are not allowed. Unit: minutes. Valid values:
        /// 
        /// *   **5**: 5 minutes
        /// *   **15**: 15 minutes
        /// *   **30**: 30 minutes
        /// *   **60**: 1 hour
        /// *   **120**: 2 hours
        /// *   **360**: 6 hours
        /// *   **720**: 12 hours
        /// *   **1440**: 24 hours
        /// *   **10080**: 7 days
        /// *   **52560000**: permanent
        /// </summary>
        [NameInMap("ForbiddenTime")]
        [Validation(Required=false)]
        public int? ForbiddenTime { get; set; }

        /// <summary>
        /// The name of the defense rule.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
        /// The maximum period of time during which failed logon attempts from an account can occur. Unit: minutes. Valid values:
        /// 
        /// *   **1**
        /// *   **2**
        /// *   **5**
        /// *   **10**
        /// *   **15**
        /// 
        /// >  To configure a defense rule, you must specify the Span, FailCount, and ForbiddenTime parameters. If the number of failed logon attempts from an account within the minutes specified by Span exceeds the value specified by FailCount, the account cannot be used for logons within the minutes specified by ForbiddenTime.
        /// </summary>
        [NameInMap("Span")]
        [Validation(Required=false)]
        public int? Span { get; set; }

        /// <summary>
        /// The UUIDs of the servers to which you want to apply the defense rule.
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
