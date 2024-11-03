// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainBpsDataByTimeStampRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name. You can specify only one domain name in each request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The names of the Internet service providers (ISPs). Separate multiple ISPs with commas (,).</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/91077.html">DescribeCdnRegionAndIsp</a> operation to query regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uni***,tele***</para>
        /// </summary>
        [NameInMap("IspNames")]
        [Validation(Required=false)]
        public string IspNames { get; set; }

        /// <summary>
        /// <para>The regions. Separate multiple regions with commas (,).</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/91077.html">DescribeCdnRegionAndIsp</a> operation to query regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liaoning,guangxi</para>
        /// </summary>
        [NameInMap("LocationNames")]
        [Validation(Required=false)]
        public string LocationNames { get; set; }

        /// <summary>
        /// <para>The point in time to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The data is collected every 5 minutes.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-11-30T05:40:00Z</para>
        /// </summary>
        [NameInMap("TimePoint")]
        [Validation(Required=false)]
        public string TimePoint { get; set; }

    }

}
