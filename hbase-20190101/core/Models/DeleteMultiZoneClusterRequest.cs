// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DeleteMultiZoneClusterRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the multi-zone cluster to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-t4nn71xa0yn56****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately delete the instance. By default, the instance is moved to the recycle bin and permanently deleted after 7 days. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Immediately deletes the instance without moving it to the recycle bin. Use this option with caution.</description></item>
        /// <item><description>false: Moves the instance to the recycle bin. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ImmediateDeleteFlag")]
        [Validation(Required=false)]
        public bool? ImmediateDeleteFlag { get; set; }

    }

}
