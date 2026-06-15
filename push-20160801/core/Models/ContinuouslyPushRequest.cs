// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class ContinuouslyPushRequest : TeaModel {
        /// <summary>
        /// <para>AppKey information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23267207</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <para>Message ID.</para>
        /// <para>Obtain this MessageId by calling the Push API with Target set to TBD. It represents a message already saved in the push system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500131</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>Push target:</para>
        /// <list type="bullet">
        /// <item><description><para><b>DEVICE</b>: Push by device</para>
        /// </description></item>
        /// <item><description><para><b>ACCOUNT</b>: Push by account</para>
        /// </description></item>
        /// <item><description><para><b>ALIAS</b>: Push by alias</para>
        /// </description></item>
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
        /// <para>Specify values based on Target. Separate multiple values with commas. If you exceed the limit, split the push into multiple calls.</para>
        /// <list type="bullet">
        /// <item><description><para>Target=DEVICE: values such as <c>deviceid1,deviceid2</c> (up to 1,000 supported).</para>
        /// </description></item>
        /// <item><description><para>Target=ACCOUNT: values such as <c>account1,account2</c> (up to 1,000 supported).</para>
        /// </description></item>
        /// <item><description><para>Target=ALIAS: values such as <c>alias1,alias2</c> (up to 1,000 supported).</para>
        /// </description></item>
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
