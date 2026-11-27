// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class AssociateAclsWithListenerRequest : TeaModel {
        /// <summary>
        /// <para>The ACL instance IDs. You can specify up to three ACL instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AclIds")]
        [Validation(Required=false)]
        public List<string> AclIds { get; set; }

        /// <summary>
        /// <para>The access control type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>White</b>: specifies a whitelist. Only requests from the IP addresses or CIDR blocks in the Settings of the selected access control policy group are forwarded. Whitelists apply to scenarios in which you want to allow only specific IP addresses to access an application. Configuring a whitelist poses risks to your business. After a whitelist is configured, only the IP addresses in the whitelist can access the load balancing listener. If you enable a whitelist but do not add IP addresses to the access control policy group, the load balancing listener forwards all requests.</description></item>
        /// <item><description><b>Black</b>: specifies a blacklist. Requests from the IP addresses or CIDR blocks in the Settings of the selected access control policy group are not forwarded. Blacklists apply to scenarios in which you want to block access from specific IP addresses. If you enable a blacklist but do not add IP addresses to the access control policy group, the load balancing listener forwards all requests.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>White</para>
        /// </summary>
        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, and you must make sure that the value is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not set this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run and does not associate the ACLs with the listener. The system checks whether the required parameters are set, and validates the request format and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the actual request. If the request passes the dry run, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The listener instance ID. Before you invoke this operation, confirm that the Application Load Balancer (ALB) instance to which the listener belongs is not associated with a security group. After an ALB instance is associated with a security group, you cannot attach an access control policy to the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsn-bp1bpn0kn9*******</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

    }

}
