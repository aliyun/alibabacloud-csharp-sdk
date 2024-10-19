// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyApiGroupVpcWhitelistRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the API group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9b80408147724ddab4c4e2703c6ca019</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The ID of the VPC instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp11w979o2s9rcr962w25</para>
        /// </summary>
        [NameInMap("VpcIds")]
        [Validation(Required=false)]
        public string VpcIds { get; set; }

    }

}
