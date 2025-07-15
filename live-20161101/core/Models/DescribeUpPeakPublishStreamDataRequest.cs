// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeUpPeakPublishStreamDataRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Specifies whether to collect statistics at the domain name level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: collects statistics at the domain name level.</description></item>
        /// <item><description>off (default): collects statistics at the user level.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("DomainSwitch")]
        [Validation(Required=false)]
        public string DomainSwitch { get; set; }

        /// <summary>
        /// <para>The end time of stream pulling. The time must be in UTC. The end time must be later than the start time. The maximum time range that can be specified by StartTime and EndTime is 30 days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-10-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start time of stream pulling. The time must be in UTC. The maximum time range that can be specified by StartTime and EndTime is 30 days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-10-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
