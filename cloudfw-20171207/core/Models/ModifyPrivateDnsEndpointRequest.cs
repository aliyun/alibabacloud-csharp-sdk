// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyPrivateDnsEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pd-12345</para>
        /// </summary>
        [NameInMap("AccessInstanceId")]
        [Validation(Required=false)]
        public string AccessInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the private instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("AccessInstanceName")]
        [Validation(Required=false)]
        public string AccessInstanceName { get; set; }

        /// <summary>
        /// <para>The primary DNS server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.1.1</para>
        /// </summary>
        [NameInMap("PrimaryDns")]
        [Validation(Required=false)]
        public string PrimaryDns { get; set; }

        /// <summary>
        /// <para>The private DNS type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PrivateZone</b></para>
        /// </description></item>
        /// <item><description><para><b>Custom</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("PrivateDnsType")]
        [Validation(Required=false)]
        public string PrivateDnsType { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <para>The secondary DNS server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.1.2</para>
        /// </summary>
        [NameInMap("StandbyDns")]
        [Validation(Required=false)]
        public string StandbyDns { get; set; }

    }

}
