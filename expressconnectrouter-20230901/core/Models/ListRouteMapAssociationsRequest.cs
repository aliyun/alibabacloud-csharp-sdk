// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class ListRouteMapAssociationsRequest : TeaModel {
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can generate the value from your client and make sure that the value is unique across different requests. The client token supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-00****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether this is a dry run on the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run. The system checks the request but does not modify EPS resources.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a normal request.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The instance ID of the Express Connect Router (ECR).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecr-mezk2idmsd0vx2****</para>
        /// </summary>
        [NameInMap("EcrId")]
        [Validation(Required=false)]
        public string EcrId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return. Valid values: 1 to 2147483647. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to start the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is the first query or no next query is to be sent, this parameter is not required.</description></item>
        /// <item><description>If a next query is to be sent, set the value to the <b>NextToken</b> value returned by the last API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>e0a2dbeb69a8beeeb8194e92b702df3fd3e7bfe6ce7bfc16e0b5e8707e68181f</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the route map in the Cloud Enterprise Network (CEN).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-6m58b17417tg5a****</para>
        /// </summary>
        [NameInMap("RouteMapId")]
        [Validation(Required=false)]
        public string RouteMapId { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
