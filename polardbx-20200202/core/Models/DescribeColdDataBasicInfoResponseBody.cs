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
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BackupSetCount")]
            [Validation(Required=false)]
            public int? BackupSetCount { get; set; }

            /// <summary>
            /// <para>The data size of valid backup sets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BackupSetSpaceSize")]
            [Validation(Required=false)]
            public double? BackupSetSpaceSize { get; set; }

            /// <summary>
            /// <para>The underlying cloud storage service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyunOSS</para>
            /// </summary>
            [NameInMap("CloudProduct")]
            [Validation(Required=false)]
            public string CloudProduct { get; set; }

            /// <summary>
            /// <para>The data size of cold storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CurrentSpaceSize")]
            [Validation(Required=false)]
            public double? CurrentSpaceSize { get; set; }

            /// <summary>
            /// <para>The data redundancy type of cold storage. LRS indicates locally redundant storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LRS</para>
            /// </summary>
            [NameInMap("DataRedundancyType")]
            [Validation(Required=false)]
            public string DataRedundancyType { get; set; }

            /// <summary>
            /// <para>Indicates whether cold storage is enabled.</para>
            /// </summary>
            [NameInMap("EnableStatus")]
            [Validation(Required=false)]
            public bool? EnableStatus { get; set; }

            /// <summary>
            /// <para>The number of read accesses to cold data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ReadAccessNum")]
            [Validation(Required=false)]
            public long? ReadAccessNum { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the storage volume.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polardbx-oss-columnar-bucket-cn-hangzhou-1</para>
            /// </summary>
            [NameInMap("VolumeName")]
            [Validation(Required=false)]
            public string VolumeName { get; set; }

            /// <summary>
            /// <para>The number of write accesses to cold data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WriteAccessNum")]
            [Validation(Required=false)]
            public double? WriteAccessNum { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A6D328C-84B8-40DC-BF49-6C73984D7494</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
