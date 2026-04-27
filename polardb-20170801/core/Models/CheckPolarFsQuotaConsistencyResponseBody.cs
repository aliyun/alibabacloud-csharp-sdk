// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CheckPolarFsQuotaConsistencyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pfs-2ze0i74ka607*****</para>
        /// </summary>
        [NameInMap("PolarFsInstanceId")]
        [Validation(Required=false)]
        public string PolarFsInstanceId { get; set; }

        [NameInMap("QuotaItem")]
        [Validation(Required=false)]
        public CheckPolarFsQuotaConsistencyResponseBodyQuotaItem QuotaItem { get; set; }
        public class CheckPolarFsQuotaConsistencyResponseBodyQuotaItem : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>104857600</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }

            /// <summary>
            /// <para>Inodes</para>
            /// 
            /// <b>Example:</b>
            /// <para>50000</para>
            /// </summary>
            [NameInMap("Inodes")]
            [Validation(Required=false)]
            public long? Inodes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/zookeepertest718</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>104857600</para>
            /// </summary>
            [NameInMap("UsedCapacity")]
            [Validation(Required=false)]
            public long? UsedCapacity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UsedInodes")]
            [Validation(Required=false)]
            public long? UsedInodes { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E56531A4-E552-40BA-9C58-137B80******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
