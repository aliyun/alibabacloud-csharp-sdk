// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class DescribeExpressConnectRouterChildInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID used to associate the Express Connect Router (ECR) with the VBR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecr-assoc-9p2qxx5phpca2m****</para>
        /// </summary>
        [NameInMap("AssociationId")]
        [Validation(Required=false)]
        public string AssociationId { get; set; }

        /// <summary>
        /// <para>The instance ID of the network instance to be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-j6cwxhgg0s5nuephp****</para>
        /// </summary>
        [NameInMap("ChildInstanceId")]
        [Validation(Required=false)]
        public string ChildInstanceId { get; set; }

        /// <summary>
        /// <para>The region where the network instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ChildInstanceRegionId")]
        [Validation(Required=false)]
        public string ChildInstanceRegionId { get; set; }

        /// <summary>
        /// <para>The type of the network instance. Valid values: <b>VBR</b>: virtual border router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VBR</para>
        /// </summary>
        [NameInMap("ChildInstanceType")]
        [Validation(Required=false)]
        public string ChildInstanceType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate the value from your client and ensure that the value is unique across different requests. The client token can contain only ASCII characters.</para>
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
        /// <para>Specifies whether this request is only a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: sends a check request without modifying the EPS resource.</description></item>
        /// <item><description><b>false</b> (default): sends a normal request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Instance ID of the Express Connect Router (ECR) instance.</para>
        /// <remarks>
        /// <para>You can call the DescribeExpressConnectRouter API operation to obtain instance ID.</para>
        /// </remarks>
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
        /// <para>The token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is the first query or no next query is required, leave this parameter empty.</description></item>
        /// <item><description>If a next query is required, set the value to the NextToken value returned from the previous API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAYws9fJ0Ur4MGm/5OkDoW/Zn0J0/sCjivzwX9oBcwFnWaaas/kSG+J/WzLOxJHS4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
