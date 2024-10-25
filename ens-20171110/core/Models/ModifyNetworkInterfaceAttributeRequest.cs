// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyNetworkInterfaceAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The description. The description must be 1 to 256 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the ENI.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-5f6533jbifugr5fo***</para>
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// <para>The name of the ENI. The name must be 1 to 128 characters in length, The name cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-01</para>
        /// </summary>
        [NameInMap("NetworkInterfaceName")]
        [Validation(Required=false)]
        public string NetworkInterfaceName { get; set; }

    }

}
