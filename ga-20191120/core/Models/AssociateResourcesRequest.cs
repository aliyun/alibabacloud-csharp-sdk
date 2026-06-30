// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class AssociateResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Alibaba Cloud Global Accelerator (GA) instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp1odcab8tmno0hdq****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>Association pattern:  </para>
        /// <list type="bullet">
        /// <item><description><b>Managed</b>: Managed mode. GA restricts user operations based on management policies. Currently, no resources use this type.  </description></item>
        /// <item><description><b>Associated</b> (default): Loose coupling association. GA does not restrict user operations. WAF uses loose coupling.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Associated</para>
        /// </summary>
        [NameInMap("AssociatedMode")]
        [Validation(Required=false)]
        public string AssociatedMode { get; set; }

        /// <summary>
        /// <para>Resource ID of the linked instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_xx</para>
        /// </summary>
        [NameInMap("AssociatedResourceId")]
        [Validation(Required=false)]
        public string AssociatedResourceId { get; set; }

        /// <summary>
        /// <para>Region of the linked instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("AssociatedResourceRegionId")]
        [Validation(Required=false)]
        public string AssociatedResourceRegionId { get; set; }

        /// <summary>
        /// <para>Resource type of the linked instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WAF</para>
        /// </summary>
        [NameInMap("AssociatedResourceType")]
        [Validation(Required=false)]
        public string AssociatedResourceType { get; set; }

        /// <summary>
        /// <para>Indicates whether to perform a dry run of the request. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Sends a dry run request without associating resources. Checks include required parameters, request format, and business restrictions. If the check fails, an error is returned. If the check passes, an HTTP 2xx status code is returned.  </description></item>
        /// <item><description><b>false</b> (Default Value): Sends a normal request. If the check passes, an HTTP 2xx status code is returned and the endpoint group is created immediately.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Region ID of the basic Alibaba Cloud Global Accelerator (GA) instance. Valid value: <b>cn-hangzhou</b> only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
