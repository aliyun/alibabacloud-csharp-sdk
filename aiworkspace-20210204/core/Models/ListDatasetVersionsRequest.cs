// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListDatasetVersionsRequest : TeaModel {
        /// <summary>
        /// <para>The label keys used to filter the dataset list. Datasets are returned if their label keys contain the specified strings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1,key2</para>
        /// </summary>
        [NameInMap("LabelKeys")]
        [Validation(Required=false)]
        public string LabelKeys { get; set; }

        /// <summary>
        /// <para>The label values used to filter the dataset list. Datasets are returned if their label values contain the specified strings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>value1,value2</para>
        /// </summary>
        [NameInMap("LabelValues")]
        [Validation(Required=false)]
        public string LabelValues { get; set; }

        /// <summary>
        /// <para>The sort order for the paged query. The default value is ASC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ASC: Ascending order.</para>
        /// </description></item>
        /// <item><description><para>DESC: Descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. The value starts from 1. The default is 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The default value is 10.</para>
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
        /// <item><description><para>DIRECTORY: Folder.</para>
        /// </description></item>
        /// <item><description><para>FILE: File.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DIRECTORY</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public string Properties { get; set; }

        /// <summary>
        /// <para>The field to use for sorting in a paged query. The default value is GmtCreateTime. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>GmtCreateTime (default): Creation time.</para>
        /// </description></item>
        /// <item><description><para>GmtModifiedTime: Modification time.</para>
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
        /// <para>The ID of the data source.</para>
        /// <list type="bullet">
        /// <item><description><para>If SourceTypes is USER, you can specify a custom ID.</para>
        /// </description></item>
        /// <item><description><para>If SourceTypes is ITAG, this is the ID of the iTAG annotation task.</para>
        /// </description></item>
        /// <item><description><para>If SourceTypes is PAI_PUBLIC_DATASET, this parameter is empty by default.</para>
        /// </description></item>
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
        /// <item><description><para>PAI-PUBLIC-DATASET: A public dataset from PAI.</para>
        /// </description></item>
        /// <item><description><para>ITAG: A dataset generated from the annotation results of the iTAG module.</para>
        /// </description></item>
        /// <item><description><para>USER: A dataset registered by a user.</para>
        /// </description></item>
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
