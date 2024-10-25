// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RescaleDeviceServiceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7aedc50b-b1cb-4a7c-9e3d-4cf3c9ee55a4</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-5rynw9g1ow1e928lb83bqmbnf</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The type of the network. The value must be of the enumerated data type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b> (default): Internet</description></item>
        /// <item><description><b>2</b>: internal network</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IpType")]
        [Validation(Required=false)]
        public int? IpType { get; set; }

        /// <summary>
        /// <para>The region level of the scale-out. Set the value to RegionId. RegionId specifies that resource scale-out is performed based on the ID of the edge node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RegionId</para>
        /// </summary>
        [NameInMap("RescaleLevel")]
        [Validation(Required=false)]
        public string RescaleLevel { get; set; }

        /// <summary>
        /// <para>The scaling operation. Set the value to Add to add new resources.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Add</para>
        /// </summary>
        [NameInMap("RescaleType")]
        [Validation(Required=false)]
        public string RescaleType { get; set; }

        /// <summary>
        /// <para>The information about the resource specification template. The value must be a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;imageId\&quot;:\&quot;m-5s4z4c10avgwvwtn33gl2vgob\&quot;,\&quot;ipType\&quot;:2,\&quot;specName\&quot;:\&quot;ens.pfb-c3m7.medium\&quot;}</para>
        /// </summary>
        [NameInMap("ResourceInfo")]
        [Validation(Required=false)]
        public string ResourceInfo { get; set; }

        /// <summary>
        /// <para>The required resources. The value must be a JSON string.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;regionCode\&quot;: \&quot;cn-wuxi-telecom_unicom_cmcc-3\&quot;,    \&quot;ispCode\&quot;: \&quot;telecom\&quot;,    \&quot;count\&quot;: 2	},{    \&quot;regionCode\&quot;: \&quot;cn-shanghai-cmcc\&quot;,    \&quot;count\&quot;: 4	}]</para>
        /// </summary>
        [NameInMap("ResourceSelector")]
        [Validation(Required=false)]
        public string ResourceSelector { get; set; }

        /// <summary>
        /// <para>The resource specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ens.a6e.large</para>
        /// </summary>
        [NameInMap("ResourceSpec")]
        [Validation(Required=false)]
        public string ResourceSpec { get; set; }

        /// <summary>
        /// <para>The ID of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-01c6dd6e93f040698566</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The timeout period for asynchronous scale-out. Unit: seconds. Default value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

    }

}
