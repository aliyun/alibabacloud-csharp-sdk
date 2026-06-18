// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeColdDataBasicInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeColdDataBasicInfoResponseBodyData Data { get; set; }
        public class DescribeColdDataBasicInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of backup sets.</para>
            /// </summary>
            [NameInMap("BackupSetCount")]
            [Validation(Required=false)]
            public int? BackupSetCount { get; set; }

            /// <summary>
            /// <para>The data size of valid backup sets.</para>
            /// </summary>
            [NameInMap("BackupSetSpaceSize")]
            [Validation(Required=false)]
            public double? BackupSetSpaceSize { get; set; }

            /// <summary>
            /// <para>The underlying storage cloud service.</para>
            /// </summary>
            [NameInMap("CloudProduct")]
            [Validation(Required=false)]
            public string CloudProduct { get; set; }

            /// <summary>
            /// <para>The data size of cold storage.</para>
            /// </summary>
            [NameInMap("CurrentSpaceSize")]
            [Validation(Required=false)]
            public double? CurrentSpaceSize { get; set; }

            [NameInMap("DataRedundancyType")]
            [Validation(Required=false)]
            public string DataRedundancyType { get; set; }

            /// <summary>
            /// <para>Indicates whether cold storage is enabled.</para>
            /// </summary>
            [NameInMap("EnableStatus")]
            [Validation(Required=false)]
            public bool? EnableStatus { get; set; }

            [NameInMap("ReadAccessNum")]
            [Validation(Required=false)]
            public long? ReadAccessNum { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The storage volume name.</para>
            /// </summary>
            [NameInMap("VolumeName")]
            [Validation(Required=false)]
            public string VolumeName { get; set; }

            [NameInMap("WriteAccessNum")]
            [Validation(Required=false)]
            public double? WriteAccessNum { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
