// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateModelGroupRequest : TeaModel {
        /// <summary>
        /// <para>The description of the model group. This parameter can be empty and contain up to 1,024 UTF-16 code units.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Model group for service integration</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the AI gateway instance to which the resource belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-d00000000000000000000</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The IDs of the actual or logical models within the same instance. This parameter can be empty, but the IDs must be unique. Model groups cannot be used as members.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("modelCardIds")]
        [Validation(Required=false)]
        public List<string> ModelCardIds { get; set; }

        /// <summary>
        /// <para>The unique name within the instance. It must be 1 to 128 bytes in length after trimming and encoded in UTF-8.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beta-model-group</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
