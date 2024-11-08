// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListInstancePatchStatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of patches of the instance.</para>
        /// </summary>
        [NameInMap("InstancePatchStates")]
        [Validation(Required=false)]
        public List<ListInstancePatchStatesResponseBodyInstancePatchStates> InstancePatchStates { get; set; }
        public class ListInstancePatchStatesResponseBodyInstancePatchStates : TeaModel {
            /// <summary>
            /// <para>The ID of the patch baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pb-f9393021b7a049e1b34e</para>
            /// </summary>
            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public string BaselineId { get; set; }

            /// <summary>
            /// <para>The number of patches that failed to be installed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FailedCount")]
            [Validation(Required=false)]
            public string FailedCount { get; set; }

            /// <summary>
            /// <para>The number of installed patches.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InstalledCount")]
            [Validation(Required=false)]
            public string InstalledCount { get; set; }

            /// <summary>
            /// <para>The number of patches that do not meet the baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InstalledOtherCount")]
            [Validation(Required=false)]
            public string InstalledOtherCount { get; set; }

            /// <summary>
            /// <para>The number of patches that have been installed but require a restart to take effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InstalledPendingRebootCount")]
            [Validation(Required=false)]
            public string InstalledPendingRebootCount { get; set; }

            /// <summary>
            /// <para>The number of patches that are rejected by the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InstalledRejectedCount")]
            [Validation(Required=false)]
            public string InstalledRejectedCount { get; set; }

            /// <summary>
            /// <para>The ID of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1jaxa2bs4bps7*****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The number of patches that are not installed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MissingCount")]
            [Validation(Required=false)]
            public string MissingCount { get; set; }

            /// <summary>
            /// <para>The time when the operation ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-10T11:42:22Z</para>
            /// </summary>
            [NameInMap("OperationEndTime")]
            [Validation(Required=false)]
            public string OperationEndTime { get; set; }

            /// <summary>
            /// <para>The time when the operation was initiated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-10T11:42:22Z</para>
            /// </summary>
            [NameInMap("OperationStartTime")]
            [Validation(Required=false)]
            public string OperationStartTime { get; set; }

            /// <summary>
            /// <para>The operation type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>scan</para>
            /// </summary>
            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            /// <summary>
            /// <para>The information about the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>“”</para>
            /// </summary>
            [NameInMap("OwnerInformation")]
            [Validation(Required=false)]
            public string OwnerInformation { get; set; }

            /// <summary>
            /// <para>The patch group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("PatchGroup")]
            [Validation(Required=false)]
            public string PatchGroup { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9A47C086-E64D-52EE-8B2C-EFD23877C55E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
