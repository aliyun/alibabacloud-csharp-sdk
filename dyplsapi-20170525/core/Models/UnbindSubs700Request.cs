// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class UnbindSubs700Request : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>700.100.1/12345678</para>
        /// </summary>
        [NameInMap("IndustrialId")]
        [Validation(Required=false)]
        public string IndustrialId { get; set; }

        /// <summary>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000****</para>
        /// </summary>
        [NameInMap("SubsId")]
        [Validation(Required=false)]
        public long? SubsId { get; set; }

        /// <summary>
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
