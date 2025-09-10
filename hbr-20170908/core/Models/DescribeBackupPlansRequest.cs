// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeBackupPlansRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>The filters.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeBackupPlansRequestFilters> Filters { get; set; }
        public class DescribeBackupPlansRequestFilters : TeaModel {
            /// <summary>
            /// <para>The keys in the filter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>regionId</b>: the ID of a region</description></item>
            /// <item><description><b>planId</b>: the ID of a backup plan</description></item>
            /// <item><description><b>sourceType</b>: the type of a data source</description></item>
            /// <item><description><b>vaultId</b>: the ID of a backup vault</description></item>
            /// <item><description><b>instanceName</b>: the name of an instance</description></item>
            /// <item><description><b>instanceId</b>: the ID of an instance</description></item>
            /// <item><description><b>planName</b>: the name of a backup plan</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vaultId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The values that you want to match in the filter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;v-*********************&quot;]</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 99. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS_FILE</b>: Elastic Compute Service (ECS) files</description></item>
        /// <item><description><b>OSS</b>: Object Storage Service (OSS) buckets</description></item>
        /// <item><description><b>NAS</b>: File Storage NAS (NAS) file systems</description></item>
        /// <item><description><b>OTS</b>: Tablestore instances</description></item>
        /// <item><description><b>UDM_ECS</b>: ECS instances</description></item>
        /// <item><description><b>SYNC</b>: data synchronization</description></item>
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
