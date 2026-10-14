// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RescaleDeviceServiceRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required. If you do not specify this parameter, the service returns error code 100001. You can call ListApplications to obtain the application ID. To create an application, call CreateApplication first.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7aedc50b-b1cb-4a7c-9e3d-4cf3c9ee55a4</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-5rynw9g1ow1e928lb83bqmbnf</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The network type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b> (default): Internet</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: internal network</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IpType")]
        [Validation(Required=false)]
        public int? IpType { get; set; }

        /// <summary>
        /// <para>The region level for scaling out resources. Valid values: RegionId (specifies an edge node ID).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RegionId</para>
        /// </summary>
        [NameInMap("RescaleLevel")]
        [Validation(Required=false)]
        public string RescaleLevel { get; set; }

        /// <summary>
        /// <para>The resource scaling method. Valid values: Add (provisions new resources).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Add</para>
        /// </summary>
        [NameInMap("RescaleType")]
        [Validation(Required=false)]
        public string RescaleType { get; set; }

        /// <summary>
        /// <para>The resource specification template information. The value is a string in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;imageId\&quot;:\&quot;m-5s4z4c10avgwvwtn33gl2vgob\&quot;,\&quot;ipType\&quot;:2,\&quot;specName\&quot;:\&quot;ens.pfb-c3m7.medium\&quot;}</para>
        /// </summary>
        [NameInMap("ResourceInfo")]
        [Validation(Required=false)]
        public string ResourceInfo { get; set; }

        /// <summary>
        /// <para>The region requirements for scaling out resources. The value is a string in JSON array format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;regionCode\&quot;: \&quot;cn-wuxi-telecom_unicom_cmcc-3\&quot;,    \&quot;ispCode\&quot;: \&quot;telecom\&quot;,    \&quot;count\&quot;: 2	},{    \&quot;regionCode\&quot;: \&quot;cn-shanghai-cmcc\&quot;,    \&quot;count\&quot;: 4	}]</para>
        /// </summary>
        [NameInMap("ResourceSelector")]
        [Validation(Required=false)]
        public string ResourceSelector { get; set; }

        /// <summary>
        /// <para>The resource specification name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ens.a6e.large</para>
        /// </summary>
        [NameInMap("ResourceSpec")]
        [Validation(Required=false)]
        public string ResourceSpec { get; set; }

        /// <summary>
        /// <para>The service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-01c6dd6e93f040698566</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The timeout period for asynchronous resource scaling, in seconds. Default value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

    }

}
