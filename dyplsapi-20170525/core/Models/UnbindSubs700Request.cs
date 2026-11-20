// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class UnbindSubs700Request : TeaModel {
        /// <summary>
        /// <para>Optional. The Industrial Internet identification code, which has a one-to-one mapping with the OrderID. The code supports characters such as periods (.) and forward slashes (/) to separate code domains. The code must not contain non-printable characters, such as spaces or line feeds. This field is required when the service consumer generates the Industrial Internet identification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>700.100.1/12345678</para>
        /// </summary>
        [NameInMap("IndustrialId")]
        [Validation(Required=false)]
        public string IndustrialId { get; set; }

        /// <summary>
        /// <para>The order ID. This parameter is required in practice. Encrypt the order ID for reporting to the regulatory platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number pool key.</para>
        /// <para>To obtain the <b>number pool key</b>, go to the <a href="https://dyplsnext.console.aliyun.com/number-pool">Number pool management</a> page in the Phone Number Privacy Protection console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC10000016848****</para>
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The number binding ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000****</para>
        /// </summary>
        [NameInMap("SubsId")]
        [Validation(Required=false)]
        public long? SubsId { get; set; }

        /// <summary>
        /// <para>The intermediate number X. If the service consumer does not specify number X, the application platform assigns a number from the number pool as number X.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>700********0000</para>
        /// </summary>
        [NameInMap("TelX")]
        [Validation(Required=false)]
        public string TelX { get; set; }

    }

}
