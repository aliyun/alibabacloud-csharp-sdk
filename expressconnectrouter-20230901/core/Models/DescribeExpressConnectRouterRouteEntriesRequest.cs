// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class DescribeExpressConnectRouterRouteEntriesRequest : TeaModel {
        /// <summary>
        /// <para>The Autonomous System (AS) path of the route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[64993,64512]</para>
        /// </summary>
        [NameInMap("AsPath")]
        [Validation(Required=false)]
        public string AsPath { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-00****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The community value that is carried in the Border Gateway Protocol (BGP) route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9001:9263</para>
        /// </summary>
        [NameInMap("Community")]
        [Validation(Required=false)]
        public string Community { get; set; }

        /// <summary>
        /// <para>The destination CIDR block of the route that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.20.47.0/24</para>
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ECR ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecr-mezk2idmsd0vx2****</para>
        /// </summary>
        [NameInMap("EcrId")]
        [Validation(Required=false)]
        public string EcrId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to read. Valid values: 1 to 2147483647. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first request.</description></item>
        /// <item><description>You must specify the token that is obtained from the previous query as the value of NextToken.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FF9nMec/RZ6H9oqFn1pvyir/SLRlxCCyHJonbGzqL01hiM6Jb3wJowdHvjCfog7ww1b9rSHMRFJnrUBfVba68TJg==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the next-hop instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>br-hp3u4u5f03tfuljis****</para>
        /// </summary>
        [NameInMap("NexthopInstanceId")]
        [Validation(Required=false)]
        public string NexthopInstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the ECR.</para>
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
