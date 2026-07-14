// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreateFlowShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The categories.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public string CategoriesShrink { get; set; }

        /// <summary>
        /// <para>The space ID of the ISV sub-customer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-alk21lk3j2k3lj</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The URL of the WA Flow Endpoint</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.***.com">http://www.***.com</a></para>
        /// </summary>
        [NameInMap("EndpointUri")]
        [Validation(Required=false)]
        public string EndpointUri { get; set; }

        /// <summary>
        /// <para>The name of the Flow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow-001</para>
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
