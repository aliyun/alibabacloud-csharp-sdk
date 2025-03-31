// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class DeleteSourceServerRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to forcibly delete the migration source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: forcibly deletes the migration source and the migration job created for the migration source, and releases the intermediate resources of the migration job.</description></item>
        /// <item><description>false: does not delete the migration source if a migration job is created for the migration source.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The migration source ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp17m1vi6x20c6g6****</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

    }

}
