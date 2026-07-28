// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeZonesRequest : TeaModel {
        /// <summary>
        /// <para>The display language of the zone name <b>LocalName</b> in the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh-cn</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en-us</b>: English.</para>
        /// </description></item>
        /// <item><description><para><b>ja</b>: Japanese.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-cn</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the zones reside. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to obtain the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The type of zones to query. Default value: <b>AvailabilityZone</b>, which indicates a standard cloud zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AvailabilityZone</para>
        /// </summary>
        [NameInMap("ZoneType")]
        [Validation(Required=false)]
        public string ZoneType { get; set; }

    }

}
