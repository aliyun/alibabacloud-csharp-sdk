// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAutoSnapshotTasksRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of automatic snapshot policies.</para>
        /// <para>You can specify a maximum of 100 policy IDs. If you want to query the tasks of multiple automatic snapshot policies, you must separate the policy IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-extreme-233e6****,sp-extreme-233e6****, sp-extreme-233e6****</para>
        /// </summary>
        [NameInMap("AutoSnapshotPolicyIds")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyIds { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <para>You can specify a maximum of 100 file system IDs. If you want to query the snapshots of multiple file systems, you must separate the file system IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>extreme-233e6****,extreme -23vbp****,extreme -23vas****</para>
        /// </summary>
        [NameInMap("FileSystemIds")]
        [Validation(Required=false)]
        public string FileSystemIds { get; set; }

        /// <summary>
        /// <para>The type of the file system.</para>
        /// <para>Valid value: extreme, which indicates Extreme NAS file systems.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>extreme</para>
        /// </summary>
        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
