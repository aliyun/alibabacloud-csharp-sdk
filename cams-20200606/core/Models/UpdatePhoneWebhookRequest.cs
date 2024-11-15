// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdatePhoneWebhookRequest : TeaModel {
        /// <summary>
        /// <para>SpaceId for ISV sub clients.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>293483938849493****</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>Whether to use HTTP to receive receipts. Value:</para>
        /// <list type="bullet">
        /// <item><description>Y: Yes.</description></item>
        /// <item><description>N: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("HttpFlag")]
        [Validation(Required=false)]
        public string HttpFlag { get; set; }

        /// <summary>
        /// <para>phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8613800001234</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>Whether to use queue method to receive receipts. Value:</para>
        /// <list type="bullet">
        /// <item><description>Y: Yes.</description></item>
        /// <item><description>N: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("QueueFlag")]
        [Validation(Required=false)]
        public string QueueFlag { get; set; }

        /// <summary>
        /// <para>HTTP status report interface callback address.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">http://www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("StatusCallbackUrl")]
        [Validation(Required=false)]
        public string StatusCallbackUrl { get; set; }

        /// <summary>
        /// <para>HTTP upstream message interface callback address.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://aliyun.com">http://aliyun.com</a></para>
        /// </summary>
        [NameInMap("UpCallbackUrl")]
        [Validation(Required=false)]
        public string UpCallbackUrl { get; set; }

    }

}
