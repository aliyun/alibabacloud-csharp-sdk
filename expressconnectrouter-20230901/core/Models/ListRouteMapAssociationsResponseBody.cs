// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class ListRouteMapAssociationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denied error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Authentication is failed for ****</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code that indicates whether the call is successful. A value of 200 indicates success. Other values indicate failure. For more information about the causes of failure, see error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IllegalParamFormat.EcrId</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message, which is used to replace <c>%s</c> in the <b>ErrMessage</b> error message.</para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, the <b>DtsJobId</b> request parameter is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>The param format of EcrId **** is illegal.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The message returned for the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token that is used to start the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next query is to be sent.</description></item>
        /// <item><description>If <b>NextToken</b> has a return value, the value indicates the token used to start the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>e0a2dbeb69a8beeeb8194e92b702df3fd3e7bfe6ce7bfc16e0b5e8707e68181f</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05130E79-588D-5C40-A718-C4863A59****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of route map associations.</para>
        /// </summary>
        [NameInMap("RouteMapAssociationList")]
        [Validation(Required=false)]
        public List<ListRouteMapAssociationsResponseBodyRouteMapAssociationList> RouteMapAssociationList { get; set; }
        public class ListRouteMapAssociationsResponseBodyRouteMapAssociationList : TeaModel {
            /// <summary>
            /// <para>The ID of the route map association.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecr-routemap-assoc-qdoeneegffq4yv****</para>
            /// </summary>
            [NameInMap("AssociationId")]
            [Validation(Required=false)]
            public string AssociationId { get; set; }

            /// <summary>
            /// <para>The direction in which the routing policy is applied. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Inbound</b>: the inbound region gateway direction, indicating the direction in which routing is transmitted to the Express Connect Router (ECR).</description></item>
            /// <item><description><b>Outbound</b>: the outbound region gateway direction, indicating the direction in which routing is transmitted from the Express Connect Router (ECR).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Inbound</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <para>The instance ID of the Express Connect Router (ECR).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecr-mezk2idmsd0vx2****</para>
            /// </summary>
            [NameInMap("EcrId")]
            [Validation(Required=false)]
            public string EcrId { get; set; }

            /// <summary>
            /// <para>The time when the route map association was created.</para>
            /// <para>The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-16T03:34:09Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the route map association was updated.</para>
            /// <para>The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-29T03:27:24Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The priority of the route map. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            /// <summary>
            /// <para>The list of region IDs where the route map is distributed and takes effect.</para>
            /// </summary>
            [NameInMap("RegionIdList")]
            [Validation(Required=false)]
            public List<string> RegionIdList { get; set; }

            /// <summary>
            /// <para>The ID of the route map.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-6m58b17417tg5a****</para>
            /// </summary>
            [NameInMap("RouteMapId")]
            [Validation(Required=false)]
            public string RouteMapId { get; set; }

            /// <summary>
            /// <para>The status of the route map association. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CREATING</b>: The association is being created.</description></item>
            /// <item><description><b>ACTIVE</b>: The association is in a normal state, and no operations are in progress.</description></item>
            /// <item><description><b>DELETING</b>: The association is being deleted.</description></item>
            /// <item><description><b>UPDATING</b>: The association is being updated.</description></item>
            /// <item><description><b>DELETED</b>: The association is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The version number of the route map. The version number increments when the route map in the CEN is changed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: The call is successful.</description></item>
        /// <item><description><b>False</b>: The call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of route map associations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
