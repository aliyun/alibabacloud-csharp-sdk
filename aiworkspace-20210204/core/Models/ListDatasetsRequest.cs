// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListDatasetsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the dataset\&quot;s visibility.</para>
        /// <list type="bullet">
        /// <item><description><para><c>PUBLIC</c>: The dataset is publicly accessible.</para>
        /// </description></item>
        /// <item><description><para><c>PRIVATE</c>: The dataset is privately accessible.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The data source type. To specify multiple types, separate them with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>NAS</c>: The data source is NAS.</para>
        /// </description></item>
        /// <item><description><para><c>OSS</c>: The data source is OSS.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("DataSourceTypes")]
        [Validation(Required=false)]
        public string DataSourceTypes { get; set; }

        /// <summary>
        /// <para>The data type of the dataset. To specify multiple data types, separate them with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>VIDEO</c>: video.</para>
        /// </description></item>
        /// <item><description><para><c>COMMON</c>: general.</para>
        /// </description></item>
        /// <item><description><para><c>TEXT</c>: text.</para>
        /// </description></item>
        /// <item><description><para><c>PIC</c>: image.</para>
        /// </description></item>
        /// <item><description><para><c>AUDIO</c>: audio.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>COMMON,TEXT</para>
        /// </summary>
        [NameInMap("DataTypes")]
        [Validation(Required=false)]
        public string DataTypes { get; set; }

        /// <summary>
        /// <para>A comma-separated list of dataset IDs.</para>
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
        /// <item><description><para><c>BASIC</c>: Basic edition. Does not support file metadata management.</para>
        /// </description></item>
        /// <item><description><para><c>ADVANCED</c>: Advanced edition. This edition is supported only for OSS datasets. Each version can manage metadata for up to 1 million files.</para>
        /// </description></item>
        /// <item><description><para><c>LOGICAL</c>: Logical edition. This edition is supported only for OSS datasets and is suitable for most use cases. Each version can manage metadata for up to 1 million files. You must use an SDK with this edition.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BASIC</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>A label used to filter datasets. The operation returns datasets whose label key or value contains the specified string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The dataset name. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The sort order for the results, based on the <c>SortBy</c> parameter. The default is <c>ASC</c>.</para>
        /// <list type="bullet">
        /// <item><description><para><c>ASC</c>: ascending order.</para>
        /// </description></item>
        /// <item><description><para><c>DESC</c>: descending order.</para>
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
        /// <para>The page number for the paged query. Starts at 1. The default is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of datasets to return per page. The default is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The dataset properties. To specify multiple properties, separate them with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>DIRECTORY</c>: A folder.</para>
        /// </description></item>
        /// <item><description><para><c>FILE</c>: A file.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FILE</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public string Properties { get; set; }

        /// <summary>
        /// <para>The dataset provider. Set this parameter to <c>pai</c> to query public datasets on the PAI platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pai</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>A filter for shared datasets.</para>
        /// <list type="bullet">
        /// <item><description><para><c>TO_ME</c>: Returns only datasets shared with you.</para>
        /// </description></item>
        /// <item><description><para><c>BY_ME</c>: Returns only datasets that you have shared with others and displays details of the sharing configuration.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is omitted or empty, the operation returns all datasets in the current workspace, including those shared with you.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BY_ME</para>
        /// </summary>
        [NameInMap("ShareScope")]
        [Validation(Required=false)]
        public string ShareScope { get; set; }

        /// <summary>
        /// <para>The sort field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The source dataset ID for an iTAG annotation set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-rcdg3wxxxxxhc5jk87</para>
        /// </summary>
        [NameInMap("SourceDatasetId")]
        [Validation(Required=false)]
        public string SourceDatasetId { get; set; }

        /// <summary>
        /// <para>The source ID. The value of this parameter varies based on the <c>SourceTypes</c> value:</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>SourceTypes</c> is <c>USER</c>, you can specify a custom value for <c>SourceId</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>SourceTypes</c> is <c>ITAG</c>, <c>SourceId</c> is the ID of the iTAG task.</para>
        /// </description></item>
        /// <item><description><para>If <c>SourceTypes</c> is <c>PAI_PUBLIC_DATASET</c>, this parameter is empty by default.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>d-rbvg5wzljzjhc9ks92</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The source type. To specify multiple types, separate them with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER,ITAG</para>
        /// </summary>
        [NameInMap("SourceTypes")]
        [Validation(Required=false)]
        public string SourceTypes { get; set; }

        /// <summary>
        /// <para>The ID of the workspace that contains the dataset. For information about how to obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.
        /// If this parameter is not specified, the default workspace is used. An error is returned if the default workspace does not exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>324**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
