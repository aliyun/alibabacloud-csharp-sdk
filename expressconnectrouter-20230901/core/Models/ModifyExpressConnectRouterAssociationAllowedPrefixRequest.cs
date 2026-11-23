// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class ModifyExpressConnectRouterAssociationAllowedPrefixRequest : TeaModel {
        /// <summary>
        /// <para>The list of allowed route prefixes.</para>
        /// </summary>
        [NameInMap("AllowedPrefixes")]
        [Validation(Required=false)]
        public List<string> AllowedPrefixes { get; set; }

        /// <summary>
        /// <para>The prefix routing pattern. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MatchMode: Publishes only the configured route prefixes to your data center. Existing specific routes are withdrawn.</description></item>
        /// <item><description>IncrementalMode: Publishes the configured route prefixes to your data center. Withdraw previously published more specific routes that are covered by the configured prefixes. More specific routes that are not covered by the configured prefixes remain published.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MatchMode</para>
        /// </summary>
        [NameInMap("AllowedPrefixesMode")]
        [Validation(Required=false)]
        public string AllowedPrefixesMode { get; set; }

        /// <summary>
        /// <para>The ID of the association between the ECR and the VPC or TR.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecr-assoc-9p2qxx5phpca2m****</para>
        /// </summary>
        [NameInMap("AssociationId")]
        [Validation(Required=false)]
        public string AssociationId { get; set; }

        /// <summary>
        /// <para>A client token used to ensure the idempotence of the request.</para>
        /// <para>Generate a parameter value from your client to make sure that the value is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-00****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Performs a dry run.</description></item>
        /// <item><description><b>false</b> (default): Sends a normal request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of ECR.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecr-mezk2idmsd0vx2****</para>
        /// </summary>
        [NameInMap("EcrId")]
        [Validation(Required=false)]
        public string EcrId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
