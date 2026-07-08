// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsUpPeakPublishStreamDataRequest : TeaModel {
        /// <summary>
        /// <para>Domain name to query. Returns data at the domain granularity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Enables or disables domain-level statistics. Valid values: on or off. When set to on, the response shows domain-level data. When set to off or omitted, the response shows user-level data. Default is user-level data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("DomainSwitch")]
        [Validation(Required=false)]
        public string DomainSwitch { get; set; }

        /// <summary>
        /// <para>End time of stream ingest, in UTC format. The time range between StartTime and EndTime must be within 30 days. EndTime must be later than the current time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Start time of stream ingest, in UTC format. The time range between StartTime and EndTime must be within 30 days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
