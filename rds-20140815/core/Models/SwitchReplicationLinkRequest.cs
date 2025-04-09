// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class SwitchReplicationLinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the source or primary instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2zecuz9tolf******</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The name of the destination DR instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-t4neh0q12v1******</para>
        /// </summary>
        [NameInMap("TargetInstanceName")]
        [Validation(Required=false)]
        public string TargetInstanceName { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the destination DR instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-southeast-1</para>
        /// </summary>
        [NameInMap("TargetInstanceRegionId")]
        [Validation(Required=false)]
        public string TargetInstanceRegionId { get; set; }

    }

}
