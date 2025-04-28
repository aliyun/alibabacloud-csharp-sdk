// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListDatasetsRequest : TeaModel {
        /// <summary>
        /// <para>The storage types of the data source. Multiple data source types are separated by commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NAS: File Storage NAS (NAS).</description></item>
        /// <item><description>OSS: Object Storage Service (OSS).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("DataSourceTypes")]
        [Validation(Required=false)]
        public string DataSourceTypes { get; set; }

        /// <summary>
        /// <para>The dataset types. Multiple dataset types are separated by commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Video: video</description></item>
        /// <item><description>COMMON: common</description></item>
        /// <item><description>TEXT: text</description></item>
        /// <item><description>PIC: picture</description></item>
        /// <item><description>AUDIO: audio</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>COMMON,TEXT</para>
        /// </summary>
        [NameInMap("DataTypes")]
        [Validation(Required=false)]
        public string DataTypes { get; set; }

        /// <summary>
        /// <para>The dataset tag, which is used to filter datasets. Datasets whose tag key or tag value contains a specified string are filtered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The dataset name. Fuzzy search based on the dataset name is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The order of specific fields of the entries on the returned page. Valid values: ASC and DESC. Default value: ASC.</para>
        /// <list type="bullet">
        /// <item><description>ASC: The entries are sorted in ascending order.</description></item>
        /// <item><description>DESC: The entries are sorted in descending order.</description></item>
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
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The dataset properties. Multiple properties are separated by commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DIRECTORY</description></item>
        /// <item><description>FILE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FILE</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public string Properties { get; set; }

        /// <summary>
        /// <para>The dataset provider. If the value pai is returned, the dataset is a public dataset provided by PAI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pai</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The field used for sorting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The ID of the iTAG labeled dataset that is used as the source dataset.</para>
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
        /// <item><description>If SourceType is set to USER, the value of SourceId is a custom string.</description></item>
        /// <item><description>If SourceType is set to ITAG, the value of SourceId is the ID of the labeling job of iTAG.</description></item>
        /// <item><description>If SourceType is set to PAI_PUBLIC_DATASET, SourceId is empty by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>d-rbvg5wzljzjhc9ks92</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The source types. Multiple source types are separated by commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PAI-PUBLIC-DATASET: a public dataset of Platform for AI (PAI).</description></item>
        /// <item><description>ITAG: a dataset generated from a labeling job of iTAG.</description></item>
        /// <item><description>USER: a dataset registered by a user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER,ITAG</para>
        /// </summary>
        [NameInMap("SourceTypes")]
        [Validation(Required=false)]
        public string SourceTypes { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the dataset belongs. You can call <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> to obtain the workspace ID. If you do not specify this parameter, the default workspace is used. If the default workspace does not exist, an error is reported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>324**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
