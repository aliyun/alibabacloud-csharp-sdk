// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeApsDatasourcesRequest : TeaModel {
        /// <summary>
        /// <para>The ADB instance ID. This parameter is required. You can invoke the DescribeDBClusters operation to query the cluster ID in the specified region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-******</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The name of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DatasourceName")]
        [Validation(Required=false)]
        public string DatasourceName { get; set; }

        /// <summary>
        /// <para>The type of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SLS</para>
        /// </summary>
        [NameInMap("DatasourceType")]
        [Validation(Required=false)]
        public string DatasourceType { get; set; }

        /// <summary>
        /// <para>The end date. Format: yyyy-MM-dd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-30</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The start date. Format: yyyy-MM-dd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
