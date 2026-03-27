// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListPrometheusViewsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Filter by RegionID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-zhangjiakou,cn-beijing</para>
        /// </summary>
        [NameInMap("filterRegionIds")]
        [Validation(Required=false)]
        public string FilterRegionIds { get; set; }

        /// <summary>
        /// <para>Maximum number of records to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Query token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44ANBjKZmQeKnaB1fXRq06w7sFYK3MUcCALMD9qQbmEiE</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>List of Prometheus view instance IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>view-xxx</para>
        /// </summary>
        [NameInMap("prometheusViewIds")]
        [Validation(Required=false)]
        public string PrometheusViewIds { get; set; }

        /// <summary>
        /// <para>Prometheus view name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>view1</para>
        /// </summary>
        [NameInMap("prometheusViewName")]
        [Validation(Required=false)]
        public string PrometheusViewName { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm3gn5i6bigbi</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROMETHEUSVIEW</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>List of tags.</para>
        /// </summary>
        [NameInMap("tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

        /// <summary>
        /// <para>Instance version: V1 or V2</para>
        /// 
        /// <b>Example:</b>
        /// <para>V2</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>Workspace name</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
