// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamsTotalCountRequest : TeaModel {
        /// <summary>
        /// <para>The ingest domain or streaming domain. This parameter is required when you query domain-level data. You can specify up to 10 domain names in a batch query. Separate multiple domain names with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time. The end time must be later than the start time. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
        /// <remarks>
        /// <para>The interval between StartTime and EndTime must be within 15 days, and EndTime cannot be later than the current time. Data for the current day can be queried only on the next day.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-07-25T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

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
        /// <para>The start time. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
        /// <remarks>
        /// <para>The maximum query range is the last 1.5 years.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-07-24T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>If you leave this parameter empty, domain-level data is queried by default. Set this parameter to aliuid to query UID-level data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliuid</para>
        /// </summary>
        [NameInMap("Typ")]
        [Validation(Required=false)]
        public string Typ { get; set; }

    }

}
