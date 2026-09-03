// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeZonesRequest : TeaModel {
        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to retrieve the list of regions supported by Alibaba Cloud Workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether the zone supports VPC access.</para>
        /// </summary>
        [NameInMap("VpcAccessZone")]
        [Validation(Required=false)]
        public bool? VpcAccessZone { get; set; }

        /// <summary>
        /// <para>The type of zone to query. Default value: <c>AvailabilityZone</c>, which indicates a standard cloud zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AvailabilityZone</para>
        /// </summary>
        [NameInMap("ZoneType")]
        [Validation(Required=false)]
        public string ZoneType { get; set; }

    }

}
