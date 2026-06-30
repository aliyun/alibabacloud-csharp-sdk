// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DisassociateResourcesRequest : TeaModel {
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
        /// <para>Linked instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cd498437eb9a346c38be8482689800e91</para>
        /// </summary>
        [NameInMap("AssociatedResourceId")]
        [Validation(Required=false)]
        public string AssociatedResourceId { get; set; }

        /// <summary>
        /// <para>Region ID of the linked instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("AssociatedResourceRegionId")]
        [Validation(Required=false)]
        public string AssociatedResourceRegionId { get; set; }

        /// <summary>
        /// <para>Resource type of the linked peripheral resource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WAF</para>
        /// </summary>
        [NameInMap("AssociatedResourceType")]
        [Validation(Required=false)]
        public string AssociatedResourceType { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run of the request. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Sends a dry run request without detaching the resource. The system checks whether required parameters are specified, whether the request format is valid, and whether business limits are met. If the check fails, an error is returned. If the check passes, an HTTP 2xx status code is returned.  </description></item>
        /// <item><description><b>false</b> (default): Sends a normal request. If the check passes, an HTTP 2xx status code is returned and the endpoint group is created immediately.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Region ID of the Alibaba Cloud Global Accelerator (GA) instance. Valid value: <b>cn-hangzhou</b> only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
