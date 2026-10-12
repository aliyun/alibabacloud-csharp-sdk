// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListImagesRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the image. Currently only takes effect for custom images.</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: Public.</description></item>
        /// <item><description>PRIVATE: Private.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The image URI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/pai-compression/nlp:gpu</para>
        /// </summary>
        [NameInMap("ImageUri")]
        [Validation(Required=false)]
        public string ImageUri { get; set; }

        /// <summary>
        /// <para>The label filter conditions. Separate multiple conditions with commas (,).
        /// The format of a single filter condition is <c>Key=Value</c>.
        /// Valid values of Key:</para>
        /// <list type="bullet">
        /// <item><description>system.chipType</description></item>
        /// <item><description>system.dsw.cudaVersion</description></item>
        /// <item><description>system.dsw.fromImageId</description></item>
        /// <item><description>system.dsw.fromInstanceId</description></item>
        /// <item><description>system.dsw.id</description></item>
        /// <item><description>system.dsw.os</description></item>
        /// <item><description>system.dsw.osVersion</description></item>
        /// <item><description>system.dsw.resourceType</description></item>
        /// <item><description>system.dsw.rootImageId</description></item>
        /// <item><description>system.dsw.stage</description></item>
        /// <item><description>system.dsw.tag</description></item>
        /// <item><description>system.dsw.type</description></item>
        /// <item><description>system.framework</description></item>
        /// <item><description>system.origin</description></item>
        /// <item><description>system.pythonVersion</description></item>
        /// <item><description>system.source</description></item>
        /// <item><description>system.supported.dlc</description></item>
        /// <item><description>system.supported.dsw</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>system.framework=XGBoost 1.6.0,system.official=true</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The image name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tensorflow_2.9</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The options. Currently supports ExactMatchName for exact match search on Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ExactMatchName</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>The sort order for the specified sort field in a paged query. Used together with SortBy. Default value: ASC.</para>
        /// <list type="bullet">
        /// <item><description>ASC: Ascending order.</description></item>
        /// <item><description>DESC: Descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number of the image list. Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Fuzzy searches by image name and description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The sort field for a paged query. Currently, the GmtCreateTime field is used for sorting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>Specifies whether to display non-essential information. Non-essential information currently includes Labels. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Includes non-essential information.</description></item>
        /// <item><description>false: Does not include non-essential information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

        /// <summary>
        /// <para>The workspace ID. For information about how to obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20******55</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
