// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ModifyFlowShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The folder.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public string CategoriesShrink { get; set; }

        /// <summary>
        /// <para>The space ID of the ISV sub-customer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-1sdkjwen2</para>
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
        /// <para>The ID of the flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21231232312</para>
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        /// <summary>
        /// <para>The name of the flow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Flow-**001</para>
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
