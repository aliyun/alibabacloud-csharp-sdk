// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DeleteTransitRouterVbrAttachmentRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Use the client to generate the token, but you must make sure that the token is unique among requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>When left empty, the system automatically uses the <b>RequestId</b> as the <b>ClientToken</b>. The <b>RequestId</b> is different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run to check permissions and instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): sends a request and deletes the VBR connection.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: sends a check request without deleting the VBR connection. The system checks the required parameters and request syntax. If the request fails the dry run, an error code is returned. If the request passes the dry run, a request ID is returned.</para>
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
        /// <para>Specifies whether to forcibly delete the VBR connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): The system checks resources, such as forwarding associations or route learning. If there are such resources, the VBR connection is not deleted and an error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: When the VBR connection is deleted, all associated resources are also deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the VBR connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-attach-9nlnjv7by7n7a****</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentId")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentId { get; set; }

    }

}
