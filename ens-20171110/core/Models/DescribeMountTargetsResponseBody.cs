// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeMountTargetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about mount targets.</para>
        /// </summary>
        [NameInMap("MountTargets")]
        [Validation(Required=false)]
        public List<DescribeMountTargetsResponseBodyMountTargets> MountTargets { get; set; }
        public class DescribeMountTargetsResponseBodyMountTargets : TeaModel {
            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-cmcc</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The ID of the file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c50f8*****</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <para>The path of the mount target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LB:/fileSystemName/mountTargetName</para>
            /// </summary>
            [NameInMap("MountTargetDomain")]
            [Validation(Required=false)]
            public string MountTargetDomain { get; set; }

            /// <summary>
            /// <para>The name of the mount target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestMountPath</para>
            /// </summary>
            [NameInMap("MountTargetName")]
            [Validation(Required=false)]
            public string MountTargetName { get; set; }

            /// <summary>
            /// <para>The ID of the network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n-***</para>
            /// </summary>
            [NameInMap("NetWorkId")]
            [Validation(Required=false)]
            public string NetWorkId { get; set; }

            /// <summary>
            /// <para>The state of the mount target. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>active: The mount target is available.</description></item>
            /// <item><description>inactive: The mount target is unavailable.</description></item>
            /// <item><description>pending: A task is being queued for the mount target.</description></item>
            /// <item><description>deleting: The mount target is being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>762DD527-358B-1E48-8005-CCE3ED4EB9E0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of mount targets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
