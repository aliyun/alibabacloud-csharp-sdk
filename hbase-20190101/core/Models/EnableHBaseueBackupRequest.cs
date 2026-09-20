// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class EnableHBaseueBackupRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cold storage size for the backup service. The minimum value is 800 GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("ColdStorageSize")]
        [Validation(Required=false)]
        public int? ColdStorageSize { get; set; }

        /// <summary>
        /// <para>The ID of the HBaseue cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-m5eznlga4k5bcxxxx</para>
        /// </summary>
        [NameInMap("HbaseueClusterId")]
        [Validation(Required=false)]
        public string HbaseueClusterId { get; set; }

        /// <summary>
        /// <para>The number of backup nodes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NodeCount")]
        [Validation(Required=false)]
        public int? NodeCount { get; set; }

    }

}
