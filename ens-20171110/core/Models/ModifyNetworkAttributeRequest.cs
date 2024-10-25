// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyNetworkAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The description of the network.</para>
        /// <para>The description must be 2 to 256 characters in length. It must start with a letter but cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is my first network</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the network.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n-****</para>
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// <para>The name of the network. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 128 characters in length</description></item>
        /// <item><description>It must start with a letter but cannot start with http:// or https://.</description></item>
        /// <item><description>The name can contain letters, digits, colons (:), underscores (_), and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("NetworkName")]
        [Validation(Required=false)]
        public string NetworkName { get; set; }

    }

}
