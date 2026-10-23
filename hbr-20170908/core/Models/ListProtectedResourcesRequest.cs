// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class ListProtectedResourcesRequest : TeaModel {
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
        /// <para>Specifies whether backup points exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasSnapshot")]
        [Validation(Required=false)]
        public bool? HasSnapshot { get; set; }

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
        /// <para>The pagination token for the next page. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aWQj********MCMy</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>The number of entries to skip for a paged query.
        /// If the number of skipped entries exceeds the total number of matched entries, an empty list is returned. The number of skipped entries must be a multiple of MaxResults.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Skip")]
        [Validation(Required=false)]
        public int? Skip { get; set; }

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

}
