// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class DescribeExpressConnectRouterRouteEntriesRequest : TeaModel {
        /// <summary>
        /// <para>The AS path traversed by the route entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[64993,64512]</para>
        /// </summary>
        [NameInMap("AsPath")]
        [Validation(Required=false)]
        public string AsPath { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate the parameter value from your client to ensure that the value is unique across different requests. The client token can contain only ASCII characters.</para>
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
        /// <para>The community value carried by the BGP route entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9001:9263</para>
        /// </summary>
        [NameInMap("Community")]
        [Validation(Required=false)]
        public string Community { get; set; }

        /// <summary>
        /// <para>The destination CIDR block of the route entry to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.20.4.0/24</para>
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// <para>Specifies whether it is a dry run for this request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: sends a check request and does not modify EPS resources.</para>
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
        /// <para>The maximum number of entries to return. Valid values: 1 to 2147483647. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>For the first query or when no subsequent query is required, leave this parameter empty.</description></item>
        /// <item><description>If a subsequent query is required, set the value to the NextToken value returned from the previous API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FF9nMec/RZ6H9oqFn1pvyir/SLRlxCCyHJonbGzqL01hiM6Jb3wJowdHvjCfog7ww1b9rSHMRFJnrUBfVba68TJg==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The next hop instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-hp3u4u5f03tfuljis****</para>
        /// </summary>
        [NameInMap("NexthopInstanceId")]
        [Validation(Required=false)]
        public string NexthopInstanceId { get; set; }

        /// <summary>
        /// <para>The region where the Express Connect Router (ECR) instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("QueryRegionId")]
        [Validation(Required=false)]
        public string QueryRegionId { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
