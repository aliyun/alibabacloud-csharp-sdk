// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DeleteDomainAcceleratorRelationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the GA instance to be disassociated. You can specify up to 50 IDs.</para>
        /// <para>If you leave this parameter empty, all GA instances associated with the specified domain name are disassociated.</para>
        /// </summary>
        [NameInMap("AcceleratorIds")]
        [Validation(Required=false)]
        public List<string> AcceleratorIds { get; set; }

        /// <summary>
        /// <para>The accelerated domain name to be disassociated.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Global Accelerator (GA) instance is deployed. Set the value to <b>cn-hangzhou</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
