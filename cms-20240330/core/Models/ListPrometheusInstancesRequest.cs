// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListPrometheusInstancesRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The list of region IDs used for filtering, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("filterRegionIds")]
        [Validation(Required=false)]
        [Obsolete]
        public string FilterRegionIds { get; set; }

        /// <summary>
        /// <para>The maximum number of records to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The next token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11a111111111a1111a1111aaaa1a1aa1aa11aa111aa11a1111a1a111aa1a111111111a11a1aa1111a111aa11a11aa1a1</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of instance IDs, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rw-00001,rw-00002,rw-00003</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("prometheusInstanceIds")]
        [Validation(Required=false)]
        public string PrometheusInstanceIds { get; set; }

        /// <summary>
        /// <para>The name of the instance. Partial match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("prometheusInstanceName")]
        [Validation(Required=false)]
        public string PrometheusInstanceName { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2bhocin5e2na</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The resource type of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Prometheus</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        [Obsolete]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("tag")]
        [Validation(Required=false)]
        public List<ListPrometheusInstancesRequestTag> Tag { get; set; }
        public class ListPrometheusInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testKey</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testValue</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The version of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>V2</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The workspace to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
