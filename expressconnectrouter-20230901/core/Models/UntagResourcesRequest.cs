// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to unbind all tags. This parameter is valid only when <b>TagKey</b> is empty. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Unbinds all tags from the Express Connect Router (ECR) instance.</description></item>
        /// <item><description><b>false</b> (default): Does not unbind all tags from the Express Connect Router (ECR) instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify either <b>TagKey</b> or <b>All</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Generate a parameter value from your client to ensure uniqueness across different requests. ClientToken supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-00****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Performs a dry run without modifying EPS resources.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Sends the request normally.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The list of resource instance IDs. You can unbind tags from up to 50 resource instances at a time.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>EXPRESSCONNECTROUTER</b>: Express Connect Router (ECR) instance.</description></item>
        /// <item><description><b>EXPRESSCONNECTROUTERVPCASSOCIATION</b>: the associate relationship between an ECR and a VPC.</description></item>
        /// <item><description><b>EXPRESSCONNECTROUTERTRASSOCIATION</b>: the associate relationship between an ECR and a transit router.</description></item>
        /// <item><description><b>ECRFLOWLOG</b>: ECR flow log.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXPRESSCONNECTROUTER</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tag keys of the Express Connect Router (ECR) instance to unbind.</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
