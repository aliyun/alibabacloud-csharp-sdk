// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDeviceServiceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2bac6f4-75dc-455e-8389-2dc8e47526d3</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>This parameter does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chongqing-10</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5sg1owx0g4ojy66ab2tez77r2</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2661b1dd-3453-418d-8182-bb34f79e8d3c</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the Edge Node Service (ENS) node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chongqing-11</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Service ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-cxxxxx</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

    }

}
