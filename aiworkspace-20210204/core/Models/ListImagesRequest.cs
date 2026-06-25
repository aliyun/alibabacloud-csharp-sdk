// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListImagesRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the image. This parameter is valid only for custom images.</para>
        /// <list type="bullet">
        /// <item><description><para>PUBLIC: The image is public.</para>
        /// </description></item>
        /// <item><description><para>PRIVATE: The image is private.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("ImageUri")]
        [Validation(Required=false)]
        public string ImageUri { get; set; }

        /// <summary>
        /// <para>The filter conditions for labels. Separate multiple conditions with commas (,).
        /// The format for a single filter condition is <c>Key=Value</c>.
        /// The supported values for Key are:</para>
        /// <list type="bullet">
        /// <item><description><para>system.chipType</para>
        /// </description></item>
        /// <item><description><para>system.dsw\.cudaVersion</para>
        /// </description></item>
        /// <item><description><para>system.dsw\.fromImageId</para>
        /// </description></item>
        /// <item><description><para>system.dsw\.fromInstanceId</para>
        /// </description></item>
        /// <item><description><para>system.dsw\.id</para>
        /// </description></item>
        /// <item><description><para>system.dsw\.os</para>
        /// </description></item>
        /// <item><description><para>system.dsw\.osVersion</para>
        /// </description></item>
        /// <item><description><para>system.dsw\.resourceType</para>
        /// </description></item>
        /// <item><description><para>system.dsw\.rootImageId</para>
        /// </description></item>
        /// <item><description><para>system.dsw\.stage</para>
        /// </description></item>
        /// <item><description><para>system.dsw\.tag</para>
        /// </description></item>
        /// <item><description><para>system.dsw\.type</para>
        /// </description></item>
        /// <item><description><para>system.framework</para>
        /// </description></item>
        /// <item><description><para>system.origin</para>
        /// </description></item>
        /// <item><description><para>system.pythonVersion</para>
        /// </description></item>
        /// <item><description><para>system.source</para>
        /// </description></item>
        /// <item><description><para>system.supported.dlc</para>
        /// </description></item>
        /// <item><description><para>system.supported.dsw</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>system.framework=XGBoost 1.6.0,system.official=true</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The name of the image. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tensorflow_2.9</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The order in which to sort the results of a paged query. This parameter is used with SortBy. The default value is ASC.</para>
        /// <list type="bullet">
        /// <item><description><para>ASC: ascending order.</para>
        /// </description></item>
        /// <item><description><para>DESC: descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number of the image list. The value starts from 1. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page for a paged query. The default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Performs a fuzzy search by image name and description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The field to use for sorting in a paged query. Currently, only the GmtCreateTime field is used for sorting.</para>
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
        /// <item><description><para>true: Includes non-essential information.</para>
        /// </description></item>
        /// <item><description><para>false: Does not include non-essential information.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

        /// <summary>
        /// <para>The workspace ID. For more information about how to obtain a workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20******55</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
