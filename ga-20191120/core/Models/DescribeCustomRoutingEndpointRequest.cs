// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeCustomRoutingEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the endpoint group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epg-bp1j184jhb9i9ubwf****</para>
        /// </summary>
        [NameInMap("EndpointGroup")]
        [Validation(Required=false)]
        public string EndpointGroup { get; set; }

        /// <summary>
        /// <para>The ID of the endpoint.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ep-bp1dmlohjjz4kqaun****</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Global Accelerator (GA) instance is deployed. Set the value to <b>cn-hangzhou</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
