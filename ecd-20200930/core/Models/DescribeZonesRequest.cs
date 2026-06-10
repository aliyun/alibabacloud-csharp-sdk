// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeZonesRequest : TeaModel {
        /// <summary>
        /// <para>The region ID. Call <a href="t2167755.xdita#"></a>to get the list of regions supported by EDS.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("VpcAccessZone")]
        [Validation(Required=false)]
        public bool? VpcAccessZone { get; set; }

        /// <summary>
        /// <para>The zone type to query. Default value: <c>AvailabilityZone</c>. This queries standard cloud zones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AvailabilityZone</para>
        /// </summary>
        [NameInMap("ZoneType")]
        [Validation(Required=false)]
        public string ZoneType { get; set; }

    }

}
