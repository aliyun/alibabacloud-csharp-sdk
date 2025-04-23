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
        /// <item><description>PUBLIC: The image is visible to all users.</description></item>
        /// <item><description>PRIVATE: The image is visible only to you and the administrator of the workspace.</description></item>
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
        /// <para>The tag filter conditions. Multiple conditions are separated by commas (,). The format of a single condition filter is <c>key=value</c>. The following keys are supported:</para>
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
        /// <para>The order in which the entries are sorted by the specific field on the returned page. This parameter must be used together with SortBy. Default value: ASC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: ascending order</description></item>
        /// <item><description>DESC: descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
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
        /// <para>The number of entries per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The image name and description that are used for fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The field used for sorting. The GmtCreateTime field is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>Specifies whether to display non-essential information, which contains tags. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

        /// <summary>
        /// <para>The workspace ID. You can call <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> to obtain the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20******55</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
