// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class SetPolarFsFileQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The details of the quota rules to apply to directories.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FilePathQuotas")]
        [Validation(Required=false)]
        public List<SetPolarFsFileQuotaRequestFilePathQuotas> FilePathQuotas { get; set; }
        public class SetPolarFsFileQuotaRequestFilePathQuotas : TeaModel {
            /// <summary>
            /// <para>The quota capacity. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }

            /// <summary>
            /// <para>The directory path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/a/project</para>
            /// </summary>
            [NameInMap("FilePathId")]
            [Validation(Required=false)]
            public string FilePathId { get; set; }

            /// <summary>
            /// <para>The quota inodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Inodes")]
            [Validation(Required=false)]
            public long? Inodes { get; set; }

            /// <summary>
            /// <para>The number of subdirectory levels to traverse under <c>FilePathId</c>. A value of 1 indicates that only the first-level subdirectories are traversed. A value of 0 indicates that all levels are traversed to the deepest level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaxDepth")]
            [Validation(Required=false)]
            public int? MaxDepth { get; set; }

            /// <summary>
            /// <para>The IDs of the rules to apply, separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1,2</para>
            /// </summary>
            [NameInMap("QuotaIds")]
            [Validation(Required=false)]
            public string QuotaIds { get; set; }

            /// <summary>
            /// <para>The mode in which rules take effect on existing files. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>missing</b>: Rules take effect only when they are missing. This is the default value.</description></item>
            /// <item><description><b>all</b>: Rules take effect on all files.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>missing</para>
            /// </summary>
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public string Strategy { get; set; }

        }

        /// <summary>
        /// <para>The Polarlakebase instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-2ze0i74ka607*****</para>
        /// </summary>
        [NameInMap("PolarFsInstanceId")]
        [Validation(Required=false)]
        public string PolarFsInstanceId { get; set; }

    }

}
