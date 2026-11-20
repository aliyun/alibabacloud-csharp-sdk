// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindAXBCallRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the BX binding relationship.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12353</para>
        /// </summary>
        [NameInMap("AuthId")]
        [Validation(Required=false)]
        public string AuthId { get; set; }

        /// <summary>
        /// <para>The customer UID. This parameter is automatically obtained by the system and does not need to be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("CallerParentId")]
        [Validation(Required=false)]
        public long? CallerParentId { get; set; }

        /// <summary>
        /// <para>The key of the number pool.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC5**********************a1a</para>
        /// </summary>
        [NameInMap("CustomerPoolKey")]
        [Validation(Required=false)]
        public string CustomerPoolKey { get; set; }

        /// <summary>
        /// <para>The expiration time of the binding relationship. The value must be greater than 0. Unit: seconds. The automatic unbinding time is calculated by adding the binding time and the expiration time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7200</para>
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public long? Expiration { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The request deduplication ID. The maximum length is 20 characters. Ensure the atomicity of the request ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>564**********879</para>
        /// </summary>
        [NameInMap("ReqId")]
        [Validation(Required=false)]
        public string ReqId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The phone number of customer A.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13*******43</para>
        /// </summary>
        [NameInMap("TelA")]
        [Validation(Required=false)]
        public string TelA { get; set; }

        /// <summary>
        /// <para>The custom callback parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>000</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
