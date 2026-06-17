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
        /// <para>An array of objects defining the file quota rules for specific directories.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FilePathQuotas")]
        [Validation(Required=false)]
        public List<SetPolarFsFileQuotaRequestFilePathQuotas> FilePathQuotas { get; set; }
        public class SetPolarFsFileQuotaRequestFilePathQuotas : TeaModel {
            /// <summary>
            /// <para>The capacity quota in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }

            /// <summary>
            /// <para>The absolute path of the directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/a/project</para>
            /// </summary>
            [NameInMap("FilePathId")]
            [Validation(Required=false)]
            public string FilePathId { get; set; }

            /// <summary>
            /// <para>The inode quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Inodes")]
            [Validation(Required=false)]
            public long? Inodes { get; set; }

            /// <summary>
            /// <para>The maximum depth of subdirectories to traverse under the path specified by <c>FilePathId</c>. A value of 1 traverses only the first level of subdirectories. A value of 0 traverses to the deepest level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaxDepth")]
            [Validation(Required=false)]
            public int? MaxDepth { get; set; }

            /// <summary>
            /// <para>A list of file quota rule IDs, separated by a comma (<c>,</c>).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1,2</para>
            /// </summary>
            [NameInMap("QuotaIds")]
            [Validation(Required=false)]
            public string QuotaIds { get; set; }

            /// <summary>
            /// <para>Specifies how to apply the rule to existing files. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>missing</b>: Applies the rule only if one does not already exist. (Default)</para>
            /// </description></item>
            /// <item><description><para><b>all</b>: Applies the rule to all files.</para>
            /// </description></item>
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
        /// <para>The ID of the PolarFS instance.</para>
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
