// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeStorageVolumeResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAE90880-4970-4D81-A534-A6C0F3631F74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of returned results.</para>
        /// </summary>
        [NameInMap("StorageVolumes")]
        [Validation(Required=false)]
        public List<DescribeStorageVolumeResponseBodyStorageVolumes> StorageVolumes { get; set; }
        public class DescribeStorageVolumeResponseBodyStorageVolumes : TeaModel {
            /// <summary>
            /// <para>The authentication protocol. The value is set to <b>CHAP</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CHAP</para>
            /// </summary>
            [NameInMap("AuthProtocol")]
            [Validation(Required=false)]
            public string AuthProtocol { get; set; }

            /// <summary>
            /// <para>The time when the volume was created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-14T09:35:32Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the volume.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen-3</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>Indicates whether authentication is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Authentication is enabled.</description></item>
            /// <item><description><b>0</b> (default): Authentication is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsAuth")]
            [Validation(Required=false)]
            public int? IsAuth { get; set; }

            /// <summary>
            /// <para>Indicates whether the volume is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b> (default): The volume is enabled.</description></item>
            /// <item><description><b>0</b>: The volume is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsEnable")]
            [Validation(Required=false)]
            public int? IsEnable { get; set; }

            /// <summary>
            /// <para>The status of the volume. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>creating</description></item>
            /// <item><description>available</description></item>
            /// <item><description>deleting</description></item>
            /// <item><description>deleted</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the storage gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sgw-***</para>
            /// </summary>
            [NameInMap("StorageGatewayId")]
            [Validation(Required=false)]
            public string StorageGatewayId { get; set; }

            /// <summary>
            /// <para>The ID of the storage medium.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-***</para>
            /// </summary>
            [NameInMap("StorageId")]
            [Validation(Required=false)]
            public string StorageId { get; set; }

            /// <summary>
            /// <para>The ID of the volume.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sv-***</para>
            /// </summary>
            [NameInMap("StorageVolumeId")]
            [Validation(Required=false)]
            public string StorageVolumeId { get; set; }

            /// <summary>
            /// <para>The name of the volume.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testVolumeName</para>
            /// </summary>
            [NameInMap("StorageVolumeName")]
            [Validation(Required=false)]
            public string StorageVolumeName { get; set; }

            /// <summary>
            /// <para>The destination of the volume.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iqn.<em>.</em>.<em>:</em></para>
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
