// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class BatchRobotSmartCallRequest : TeaModel {
        /// <summary>
        /// <para>The called number. Only mobile phone numbers in the Chinese mainland are supported.</para>
        /// <para>You can set up to 1,000 called numbers and separate the numbers with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1390000****</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>The number displayed to called parties, which must be a number you purchased. You can view the numbers you purchased in the <a href="https://dyvms.console.aliyun.com/dyvms.htm#/number/normal">Voice Messaging Service console</a>.</para>
        /// <para>You can set up to 100 numbers and separate the numbers with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>222</para>
        /// </summary>
        [NameInMap("CalledShowNumber")]
        [Validation(Required=false)]
        public string CalledShowNumber { get; set; }

        /// <summary>
        /// <para>The company name, which must be the same as the <b>company name</b> specified on the <a href="https://dyvms.console.aliyun.com/dyvms.htm#/corp/normal">qualification management page</a>.</para>
        /// <remarks>
        /// <para>This parameter is optional if <b>isSelfLine</b> is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba</para>
        /// </summary>
        [NameInMap("CorpName")]
        [Validation(Required=false)]
        public string CorpName { get; set; }

        /// <summary>
        /// <para>The ID of the robot or communication script that is used to initiate a call.</para>
        /// <para>You can obtain the <b>communication script ID</b> from the <a href="https://dyvms.console.aliyun.com/dyvms.htm#/smart-call/saas/robot/list">Communication script management</a> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("DialogId")]
        [Validation(Required=false)]
        public string DialogId { get; set; }

        /// <summary>
        /// <para>The speech recognition identifier of early media. The default value is <b>false</b>, which means that the speech recognition identifier of early media is not enabled.</para>
        /// <para>Set the parameter to <b>true</b> if you want to enable the speech recognition identifier of early media.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EarlyMediaAsr")]
        [Validation(Required=false)]
        public bool? EarlyMediaAsr { get; set; }

        /// <summary>
        /// <para>Specifies whether to call the self-managed line. Default value: <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
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
        /// <para>Specifies whether the call is scheduled. If you set this parameter to <b>true</b>, the <b>ScheduleTime</b> parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ScheduleCall")]
        [Validation(Required=false)]
        public bool? ScheduleCall { get; set; }

        /// <summary>
        /// <para>The preset call time. This value is a UNIX timestamp. Unit: milliseconds.</para>
        /// <remarks>
        /// <para> This parameter is required only when <b>ScheduleCall</b> is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("ScheduleTime")]
        [Validation(Required=false)]
        public long? ScheduleTime { get; set; }

        /// <summary>
        /// <para>The task name. The task name can be up to 30 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Batch Tasks</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The variable value of the TTS template, in the JSON format.</para>
        /// <para>The variable value must correspond to a number. The TtsParam parameter must be used together with the TtsParamHead parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;number&quot;:&quot;1390000****&quot;,&quot;params&quot;:[“Miss li”,&quot;miss wang&quot;,&quot;Mr.li&quot;]}]</para>
        /// </summary>
        [NameInMap("TtsParam")]
        [Validation(Required=false)]
        public string TtsParam { get; set; }

        /// <summary>
        /// <para>The call tasks with variables, in the JSON format.</para>
        /// <para>The parameter value is a list of variable names. The TtsParamHead parameter must be used together with the TtsParam parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;name1&quot;,&quot;name2&quot;,&quot;name3&quot;]</para>
        /// </summary>
        [NameInMap("TtsParamHead")]
        [Validation(Required=false)]
        public string TtsParamHead { get; set; }

    }

}
