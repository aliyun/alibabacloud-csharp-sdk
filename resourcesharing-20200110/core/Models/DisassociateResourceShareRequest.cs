// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class DisassociateResourceShareRequest : TeaModel {
        /// <summary>
        /// <para>The owner of the resource share. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Self: The resource share belongs to the current account. This is the default value. For resource sharing within a resource directory, if you are a resource owner and you want to disassociate resources or principals from a resource share, set this parameter to Self.</description></item>
        /// <item><description>OtherAccounts: The resource share belongs to another account. For resource sharing outside a resource directory, if you are a principal and you want to exit a resource share, set this parameter to OtherAccounts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Self</para>
        /// </summary>
        [NameInMap("ResourceOwner")]
        [Validation(Required=false)]
        public string ResourceOwner { get; set; }

        /// <summary>
        /// <para>The ID of the resource share.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rs-6GRmdD3X****</para>
        /// </summary>
        [NameInMap("ResourceShareId")]
        [Validation(Required=false)]
        public string ResourceShareId { get; set; }

        /// <summary>
        /// <para>The information about the resources.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<DisassociateResourceShareRequestResources> Resources { get; set; }
        public class DisassociateResourceShareRequestResources : TeaModel {
            /// <summary>
            /// <para>The ID of the shared resource.</para>
            /// <para>Valid values of N: 1 to 5. This indicates that a maximum of five shared resources can be specified at a time.</para>
            /// <remarks>
            /// <para> Resources.N.ResourceId and Resources.N.ResourceType must be used in pairs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp183p93qs667muql****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The type of a shared resource.</para>
            /// <para>Valid values of N: 1 to 5. This indicates that a maximum of five shared resources can be specified at a time.</para>
            /// <para>For more information about the types of resources that can be shared, see <a href="https://help.aliyun.com/document_detail/450526.html">Services that work with Resource Sharing</a>.</para>
            /// <remarks>
            /// <para> Resources.N.ResourceId and Resources.N.ResourceType must be used in pairs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>VSwitch</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The information about the principals.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172050525300****</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<string> Targets { get; set; }

    }

}
