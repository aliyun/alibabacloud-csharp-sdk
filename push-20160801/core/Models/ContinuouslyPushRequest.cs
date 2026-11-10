// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class ContinuouslyPushRequest : TeaModel {
        /// <summary>
        /// <para>The AppKey information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23267207</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <para>The message ID.</para>
        /// <para>The MessageId obtained after calling the Push operation and setting Target to TBD. It represents a message that has been saved to the push system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500131</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The push target:</para>
        /// <list type="bullet">
        /// <item><description><b>DEVICE</b>: Push based on devices.</description></item>
        /// <item><description><b>ACCOUNT</b>: Push based on accounts.</description></item>
        /// <item><description><b>ALIAS</b>: Push based on aliases.</description></item>
        /// </list>
        /// <para>Continuous push supports only these three target types.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEVICE</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>Set this parameter based on Target. Separate multiple values with commas. If the limit is exceeded, push the message in multiple batches.</para>
        /// <list type="bullet">
        /// <item><description>If Target is set to DEVICE, the value is in the format of <c>deviceid1,deviceid2</c>. A maximum of 1,000 devices are supported.</description></item>
        /// <item><description>If Target is set to ACCOUNT, the value is in the format of <c>account1,account2</c>. A maximum of 1,000 accounts are supported.</description></item>
        /// <item><description>If Target is set to ALIAS, the value is in the format of <c>alias1,alias2</c>. A maximum of 1,000 aliases are supported.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a692961a92534047ad3625****</para>
        /// </summary>
        [NameInMap("TargetValue")]
        [Validation(Required=false)]
        public string TargetValue { get; set; }

    }

}
