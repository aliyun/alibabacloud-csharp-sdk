// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class UpdateResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The description of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_new_havpn_tf</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prophet</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Whether to detach the resource group from the currently connected VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Unbind")]
        [Validation(Required=false)]
        public bool? Unbind { get; set; }

        /// <summary>
        /// <para>Information about the VPC connected to the resource group.</para>
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public UserVpc UserVpc { get; set; }

    }

}
