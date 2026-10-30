// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListRouteMapsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on each page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next query is available.</description></item>
        /// <item><description>If <b>NextToken</b> returns a value, the value is the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B2063B16-852B-5B66-B73D-4ED4D1A5E5C2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the route maps.</para>
        /// </summary>
        [NameInMap("RouteMaps")]
        [Validation(Required=false)]
        public List<ListRouteMapsResponseBodyRouteMaps> RouteMaps { get; set; }
        public class ListRouteMapsResponseBodyRouteMaps : TeaModel {
            /// <summary>
            /// <para>The time when the route map was created.</para>
            /// <para>The time follows the ISO 8601 standard in the <c>YYYY-MM-DDThh:mmZ</c> format. The time is displayed in UTC.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-28T02:29:19Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the route map.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desctest</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The direction of the route map. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>Inbound: inbound.</description></item>
            /// <item><description>Outbound: outbound.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Inbound</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <para>The name of the route map.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The priority of the route map. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmydlzjd6dlhi</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the route map.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-y40mxdvf7joc12****</para>
            /// </summary>
            [NameInMap("RouteMapId")]
            [Validation(Required=false)]
            public string RouteMapId { get; set; }

            /// <summary>
            /// <para>The status of the route map. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b>: The route map is being created.</description></item>
            /// <item><description><b>Updating</b>: The route map is being updated.</description></item>
            /// <item><description><b>Active</b>: The route map is available.</description></item>
            /// <item><description><b>Deleting</b>: The route map is being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<ListRouteMapsResponseBodyRouteMapsTag> Tag { get; set; }
            public class ListRouteMapsResponseBodyRouteMapsTag : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>jg</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The version number of the route map configuration.
            /// The version number increases each time the route map and its associated route map rules are modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
