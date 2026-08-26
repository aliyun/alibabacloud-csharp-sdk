// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListDatasetVersionsRequest : TeaModel {
        /// <summary>
        /// <para>The dataset label used to filter the dataset list. Datasets whose label key or value contains the specified string are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1,key2</para>
        /// </summary>
        [NameInMap("LabelKeys")]
        [Validation(Required=false)]
        public string LabelKeys { get; set; }

        /// <summary>
        /// <para>The dataset label used to filter the dataset list. Datasets whose label key or value contains the specified string are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>value1,value2</para>
        /// </summary>
        [NameInMap("LabelValues")]
        [Validation(Required=false)]
        public string LabelValues { get; set; }

        /// <summary>
        /// <para>The order in which entries are sorted by the specified field in a paged query. Default value: ASC.</para>
        /// <list type="bullet">
        /// <item><description>ASC: ascending order.</description></item>
        /// <item><description>DESC: descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number of the dataset list. Minimum value: 1. Default value: 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query. Default value: 10.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The dataset property. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DIRECTORY: folder.</description></item>
        /// <item><description>FILE: file.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DIRECTORY</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public string Properties { get; set; }

        /// <summary>
        /// <para>The field by which entries are sorted in a paged query. Default value: GmtCreateTime. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>GmtCreateTime (default): sort by creation time.</para>
        /// </description></item>
        /// <item><description><para>GmtModifiedTime: sort by modification time.</para>
        /// </description></item>
        /// <item><description><para>SourceType</para>
        /// </description></item>
        /// <item><description><para>DataSourceType</para>
        /// </description></item>
        /// <item><description><para>Property</para>
        /// </description></item>
        /// <item><description><para>DataSize</para>
        /// </description></item>
        /// <item><description><para>DataCount</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The data source ID.</para>
        /// <list type="bullet">
        /// <item><description>If SourceTypes is set to USER, SourceId can be customized.</description></item>
        /// <item><description>If SourceTypes is set to ITAG, which indicates a dataset generated from iTAG labeling results, SourceId is the iTAG task ID.</description></item>
        /// <item><description>If SourceTypes is set to PAI_PUBLIC_DATASET, which indicates a dataset created from a PAI public dataset, SourceId is empty by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>d-a0xbe5n03bhqof46ce</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The source type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PAI-PUBLIC-DATASET: PAI public dataset.</description></item>
        /// <item><description>ITAG: dataset generated from iTAG labeling results.</description></item>
        /// <item><description>USER: dataset registered by a user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("SourceTypes")]
        [Validation(Required=false)]
        public string SourceTypes { get; set; }

    }

}
