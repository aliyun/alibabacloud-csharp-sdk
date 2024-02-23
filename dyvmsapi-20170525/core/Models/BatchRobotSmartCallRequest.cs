// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class BatchRobotSmartCallRequest : TeaModel {
        /// <summary>
        /// The called number. Only mobile phone numbers in the Chinese mainland are supported.
        /// 
        /// You can set up to 1,000 called numbers and separate the numbers with commas (,).
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// The number displayed to called parties, which must be a number you purchased. You can view the numbers you purchased in the [Voice Messaging Service console](https://dyvms.console.aliyun.com/dyvms.htm#/number/normal).
        /// 
        /// You can set up to 100 numbers and separate the numbers with commas (,).
        /// </summary>
        [NameInMap("CalledShowNumber")]
        [Validation(Required=false)]
        public string CalledShowNumber { get; set; }

        /// <summary>
        /// The company name, which must be the same as the **company name** specified on the [qualification management page](https://dyvms.console.aliyun.com/dyvms.htm#/corp/normal).
        /// 
        /// > This parameter is optional if **isSelfLine** is set to **true**.
        /// </summary>
        [NameInMap("CorpName")]
        [Validation(Required=false)]
        public string CorpName { get; set; }

        /// <summary>
        /// The ID of the robot or communication script that is used to initiate a call.
        /// 
        /// You can obtain the **communication script ID** from the [Communication script management](https://dyvms.console.aliyun.com/dyvms.htm#/smart-call/saas/robot/list) page.
        /// </summary>
        [NameInMap("DialogId")]
        [Validation(Required=false)]
        public string DialogId { get; set; }

        /// <summary>
        /// The speech recognition identifier of early media. The default value is **false**, which means that the speech recognition identifier of early media is not enabled.
        /// 
        /// Set the parameter to **true** if you want to enable the speech recognition identifier of early media.
        /// </summary>
        [NameInMap("EarlyMediaAsr")]
        [Validation(Required=false)]
        public bool? EarlyMediaAsr { get; set; }

        /// <summary>
        /// Specifies whether to call the self-managed line. Default value: **false**.
        /// </summary>
        [NameInMap("IsSelfLine")]
        [Validation(Required=false)]
        public bool? IsSelfLine { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Specifies whether the call is scheduled. If you set this parameter to **true**, the **ScheduleTime** parameter is required.
        /// </summary>
        [NameInMap("ScheduleCall")]
        [Validation(Required=false)]
        public bool? ScheduleCall { get; set; }

        /// <summary>
        /// The preset call time. This value is a UNIX timestamp. Unit: milliseconds.
        /// 
        /// >  This parameter is required only when **ScheduleCall** is set to **true**.
        /// </summary>
        [NameInMap("ScheduleTime")]
        [Validation(Required=false)]
        public long? ScheduleTime { get; set; }

        /// <summary>
        /// The task name. The task name can be up to 30 characters in length.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The variable value of the TTS template, in the JSON format.
        /// 
        /// The variable value must correspond to a number. The TtsParam parameter must be used together with the TtsParamHead parameter.
        /// </summary>
        [NameInMap("TtsParam")]
        [Validation(Required=false)]
        public string TtsParam { get; set; }

        /// <summary>
        /// The call tasks with variables, in the JSON format.
        /// 
        /// The parameter value is a list of variable names. The TtsParamHead parameter must be used together with the TtsParam parameter.
        /// </summary>
        [NameInMap("TtsParamHead")]
        [Validation(Required=false)]
        public string TtsParamHead { get; set; }

    }

}
