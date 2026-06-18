// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DeleteCustomEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the custom endpoint domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxe-8if3zrfsu****hgw</para>
        /// </summary>
        [NameInMap("CustomEndpointId")]
        [Validation(Required=false)]
        public string CustomEndpointId { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-hzravgpt8q****</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The region in which the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
