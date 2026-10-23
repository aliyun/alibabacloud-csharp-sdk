// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class ListProtectedResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return per query.</para>
        /// <para>Valid values: 10 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The return message. A value of successful indicates success. If an error occurs, the corresponding error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJJ************MX0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of protected resources.</para>
        /// </summary>
        [NameInMap("ProtectedResources")]
        [Validation(Required=false)]
        public List<ListProtectedResourcesResponseBodyProtectedResources> ProtectedResources { get; set; }
        public class ListProtectedResourcesResponseBodyProtectedResources : TeaModel {
            /// <summary>
            /// <para>The number of backup plans.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BackupPlanCount")]
            [Validation(Required=false)]
            public long? BackupPlanCount { get; set; }

            /// <summary>
            /// <para>The product capability to which the resource belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>HBR</b>: Cloud Backup standard capabilities.</description></item>
            /// <item><description><b>BASIC</b>: ECS File Backup Essential Edition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BASIC</para>
            /// </summary>
            [NameInMap("CreatedByProduct")]
            [Validation(Required=false)]
            public string CreatedByProduct { get; set; }

            /// <summary>
            /// <para>The protected data volume, in bytes. This parameter is supported only for ECS File Backup Essential Edition.</para>
            /// <list type="bullet">
            /// <item><description><b>SourceType=ECS_FILE</b>: the storage capacity of the backed-up block storage.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>107374182400</para>
            /// </summary>
            [NameInMap("ProtectedDataSize")]
            [Validation(Required=false)]
            public long? ProtectedDataSize { get; set; }

            /// <summary>
            /// <para>The ID of the protected resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pr-0004************gs61</para>
            /// </summary>
            [NameInMap("ProtectedResourceId")]
            [Validation(Required=false)]
            public string ProtectedResourceId { get; set; }

            /// <summary>
            /// <para>The resource ID. The meaning of this parameter varies based on the value of SourceType:</para>
            /// <list type="bullet">
            /// <item><description><b>SourceType=ECS_FILE</b>: the ECS instance ID.</description></item>
            /// <item><description><b>SourceType=COMMON_FILE_SYSTEM</b>: the CPFS data source ID.</description></item>
            /// <item><description><b>SourceType=COMMON_NAS</b>: the on-premises NAS data source ID.</description></item>
            /// <item><description><b>SourceType=File</b>: the on-premises server client ID.</description></item>
            /// <item><description><b>SourceType=NAS</b>: the Alibaba Cloud NAS file system ID.</description></item>
            /// <item><description><b>SourceType=OSS</b>: the OSS bucket.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz95************7zrd</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The UID of the user to whom the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024********0703</para>
            /// </summary>
            [NameInMap("ResourceOwnerId")]
            [Validation(Required=false)]
            public long? ResourceOwnerId { get; set; }

            /// <summary>
            /// <para>The ID of the region to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("ResourceRegionId")]
            [Validation(Required=false)]
            public string ResourceRegionId { get; set; }

            /// <summary>
            /// <para>The number of backup snapshots.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("SnapshotCount")]
            [Validation(Required=false)]
            public long? SnapshotCount { get; set; }

            /// <summary>
            /// <para>The type of backup feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ECS_FILE</b>: ECS file backup.</description></item>
            /// <item><description><b>COMMON_FILE_SYSTEM</b>: CPFS backup.</description></item>
            /// <item><description><b>COMMON_NAS</b>: On-premises NAS backup.</description></item>
            /// <item><description><b>File</b>: On-premises file backup.</description></item>
            /// <item><description><b>NAS</b>: Alibaba Cloud NAS backup.</description></item>
            /// <item><description><b>OSS</b>: OSS backup.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_FILE</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EB09****-<b><b>-</b></b>-****-********6C38</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of protected resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
