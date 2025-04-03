// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateCustomImageRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. By default, this parameter is left empty. The token cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20393E53-8FF1-524C-B494-B478A5369733</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the custom image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>create for cc5g group auth rules test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the custom image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom image name</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The ID of the cloud phone instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acp-2zecay9ponatdc4m****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
