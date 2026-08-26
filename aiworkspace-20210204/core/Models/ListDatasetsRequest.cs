// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListDatasetsRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the dataset.</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: public.</description></item>
        /// <item><description>PRIVATE: private.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The data source types. Separate multiple values with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NAS: Alibaba Cloud Network Attached Storage (NAS).</description></item>
        /// <item><description>OSS: Alibaba Cloud Object Storage Service (OSS).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("DataSourceTypes")]
        [Validation(Required=false)]
        public string DataSourceTypes { get; set; }

        /// <summary>
        /// <para>The data types of the dataset. Separate multiple values with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>VIDEO: video.</description></item>
        /// <item><description>COMMON: common.</description></item>
        /// <item><description>TEXT: text.</description></item>
        /// <item><description>PIC: image.</description></item>
        /// <item><description>AUDIO: audio.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>COMMON,TEXT</para>
        /// </summary>
        [NameInMap("DataTypes")]
        [Validation(Required=false)]
        public string DataTypes { get; set; }

        /// <summary>
        /// <para>The dataset IDs. You can specify multiple dataset IDs separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-rcdg3wxxxxxhc5jk87</para>
        /// </summary>
        [NameInMap("DatasetIds")]
        [Validation(Required=false)]
        public string DatasetIds { get; set; }

        /// <summary>
        /// <para>The dataset edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BASIC: Basic Edition. Does not support dataset file metadata management.</description></item>
        /// <item><description>ADVANCED: Advanced Edition. Supported only for OSS type. Each version supports up to 1 million file metadata entries.</description></item>
        /// <item><description>LOGICAL: Logical Edition. Supported only for OSS type. Each version supports up to 1 million file metadata entries. Applicable to most scenarios and requires the use of the SDK.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BASIC</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>The dataset label used to filter the dataset list. Datasets whose label key or value contains the specified string are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The dataset name. Fuzzy match is supported based on the dataset name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The sorting order for the specified sort field in paging queries. Default value: ASC.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page settings for paging queries. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The dataset properties. Separate multiple values with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DIRECTORY: folder.</description></item>
        /// <item><description>FILE: file.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FILE</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public string Properties { get; set; }

        /// <summary>
        /// <para>The dataset provider. A value of &quot;pai&quot; indicates that the dataset is a PAI platform public dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pai</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The sharing filter for datasets:</para>
        /// <list type="bullet">
        /// <item><description>TO_ME: returns only datasets shared with you.</description></item>
        /// <item><description>BY_ME: returns only datasets you shared with others, with sharing configuration details displayed.</description></item>
        /// <item><description>If this parameter is not set or is set to empty: returns all datasets in the current workspace, including TO_ME.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BY_ME</para>
        /// </summary>
        [NameInMap("ShareScope")]
        [Validation(Required=false)]
        public string ShareScope { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The source dataset ID of the iTAG annotation set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-rcdg3wxxxxxhc5jk87</para>
        /// </summary>
        [NameInMap("SourceDatasetId")]
        [Validation(Required=false)]
        public string SourceDatasetId { get; set; }

        /// <summary>
        /// <para>The data source ID.</para>
        /// <list type="bullet">
        /// <item><description>If SourceTypes is set to USER, you can customize the SourceId value.</description></item>
        /// <item><description>If SourceTypes is set to ITAG, which indicates a dataset generated from iTAG annotation results, SourceId is the iTAG task ID.</description></item>
        /// <item><description>If SourceTypes is set to PAI_PUBLIC_DATASET, which indicates a dataset created from a PAI public dataset, SourceId is empty by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>d-rbvg5wzljzjhc9ks92</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The source types. Separate multiple values with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER,ITAG</para>
        /// </summary>
        [NameInMap("SourceTypes")]
        [Validation(Required=false)]
        public string SourceTypes { get; set; }

        /// <summary>
        /// <para>The ID of the workspace where the dataset resides. For information about how to obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.
        /// If you do not specify this parameter, the default workspace is used. If the default workspace does not exist, an error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>324**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
