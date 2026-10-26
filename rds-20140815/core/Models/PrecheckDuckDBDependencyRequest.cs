// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class PrecheckDuckDBDependencyRequest : TeaModel {
        /// <summary>
        /// <para>The primary instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-2zegy5pdkg58****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

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
        /// <para>The target node mode for the precheck. primary indicates the primary node. readOnly indicates a read-only node. If you do not specify this parameter, the default value is readOnly.</para>
        /// 
        /// <b>Example:</b>
        /// <para>readOnly</para>
        /// </summary>
        [NameInMap("TargetMode")]
        [Validation(Required=false)]
        public string TargetMode { get; set; }

    }

}
