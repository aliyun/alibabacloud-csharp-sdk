// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListDatasetVersionsRequest : TeaModel {
        /// <summary>
        /// <para>The dataset tag keys, which are used to filter datasets. Datasets whose tag keys or tag values contain a specified string are filtered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1,key2</para>
        /// </summary>
        [NameInMap("LabelKeys")]
        [Validation(Required=false)]
        public string LabelKeys { get; set; }

        /// <summary>
        /// <para>The dataset tag values, which are used to filter datasets. Datasets whose tag keys or tag values contain a specified string are filtered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>value1,value2</para>
        /// </summary>
        [NameInMap("LabelValues")]
        [Validation(Required=false)]
        public string LabelValues { get; set; }

        /// <summary>
        /// <para>The order in which the entries are sorted by the specific field on the returned page. Default value: ASC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: ascending order</description></item>
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
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The dataset properties. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DIRECTORY</description></item>
        /// <item><description>FILE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DIRECTORY</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public string Properties { get; set; }

        /// <summary>
        /// <para>The field used to sort the results in queries by page. Default value: GmtCreateTime.</para>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// </list>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SourceType</description></item>
        /// <item><description>DataSourceType</description></item>
        /// <item><description>DataSize</description></item>
        /// <item><description>DataCount</description></item>
        /// <item><description>Property</description></item>
        /// <item><description>GmtCreateTime: The results are sorted by creation time. This is the default value.</description></item>
        /// <item><description>GmtModifiedTime: The results are sorted by modification time.</description></item>
        /// <item><description>DatasetId</description></item>
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
        /// <item><description>If SourceType is set to USER, the value of SourceId is a custom string.</description></item>
        /// <item><description>If SourceType is set to ITAG, the value of SourceId is the ID of the labeling job of iTAG.</description></item>
        /// <item><description>If SourceType is set to PAI_PUBLIC_DATASET, SourceId is empty by default.</description></item>
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
        /// <item><description>PAI-PUBLIC-DATASET: a public dataset of Platform for AI (PAI).</description></item>
        /// <item><description>ITAG: a dataset generated from a labeling job of iTAG.</description></item>
        /// <item><description>USER: a dataset registered by a user.</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <list type="bullet">
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// <item><description></description></item>
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
