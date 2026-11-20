// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreateSmsSignRequest : TeaModel {
        /// <summary>
        /// <para>The recipient number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>178****3614</para>
        /// </summary>
        [NameInMap("CalledNo")]
        [Validation(Required=false)]
        public string CalledNo { get; set; }

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
        /// <para>The sender number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150****6539</para>
        /// </summary>
        [NameInMap("CallingNo")]
        [Validation(Required=false)]
        public string CallingNo { get; set; }

        /// <summary>
        /// <para>The number pool key.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC5**********************a1a</para>
        /// </summary>
        [NameInMap("CustomerPoolKey")]
        [Validation(Required=false)]
        public string CustomerPoolKey { get; set; }

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

    }

}
