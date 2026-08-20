// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Generate a parameter value from your client to ensure that the value is unique among different requests. The ClientToken value supports only ASCII characters and cannot exceed 64 characters in length. If you retry a request with the same ClientToken value, the complete response of the initial call is returned without creating a duplicate instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the instance. The description can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance_for_test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
