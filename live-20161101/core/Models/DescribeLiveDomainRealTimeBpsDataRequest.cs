// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainRealTimeBpsDataRequest : TeaModel {
        /// <summary>
        /// <para>The streaming domain.</para>
        /// <para>Separate multiple domain names with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example1.aliyundoc.com,example2.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time. It must be later than the start time. The format is <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z (UTC).</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, data within one hour of the start time is queried by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2015-11-30T05:40:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The English name of the carrier.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/91077.html">DescribeCdnRegionAndIsp</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba</para>
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// <para>The English name of the region.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/91077.html">DescribeCdnRegionAndIsp</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tianjin</para>
        /// </summary>
        [NameInMap("LocationNameEn")]
        [Validation(Required=false)]
        public string LocationNameEn { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start time. The format is <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-11-30T05:39:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
