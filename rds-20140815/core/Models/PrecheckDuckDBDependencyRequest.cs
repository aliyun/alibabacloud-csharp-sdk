// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class PrecheckDuckDBDependencyRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the primary instance.</para>
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
        /// <para>The target node mode for the precheck. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>primary: the primary node.</description></item>
        /// <item><description>readOnly: a read-only node.</description></item>
        /// </list>
        /// <para>Default value: readOnly.</para>
        /// 
        /// <b>Example:</b>
        /// <para>readOnly</para>
        /// </summary>
        [NameInMap("TargetMode")]
        [Validation(Required=false)]
        public string TargetMode { get; set; }

    }

}
