// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyPrivateDnsEndpointRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pd-12345</para>
        /// </summary>
        [NameInMap("AccessInstanceId")]
        [Validation(Required=false)]
        public string AccessInstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AccessInstanceName")]
        [Validation(Required=false)]
        public string AccessInstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.1.1.1</para>
        /// </summary>
        [NameInMap("PrimaryDns")]
        [Validation(Required=false)]
        public string PrimaryDns { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("PrivateDnsType")]
        [Validation(Required=false)]
        public string PrivateDnsType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.1.1.2</para>
        /// </summary>
        [NameInMap("StandbyDns")]
        [Validation(Required=false)]
        public string StandbyDns { get; set; }

    }

}
