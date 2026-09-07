// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListCmsInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n9p9o9o3se</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The type of integrated cloud service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>direct</c>: An integration for cloud products that are monitored by the product itself.</para>
        /// </description></item>
        /// <item><description><para><c>cms</c>: An integration with CloudMonitor.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>direct</para>
        /// </summary>
        [NameInMap("TypeFilter")]
        [Validation(Required=false)]
        public string TypeFilter { get; set; }

    }

}
