// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetLiveStreamPreloadTasksRequest : TeaModel {
        /// <summary>
        /// <para>The prefetch area. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>domestic: the Chinese mainland.</description></item>
        /// <item><description>overseas: outside the Chinese mainland, including Hong Kong (China), Macao (China), and Taiwan (China).</description></item>
        /// <item><description>global: global acceleration.</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, the default prefetch area is the acceleration region configured for your domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>domestic</para>
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// <para>The streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The live stream URLs. You can specify multiple URLs separated by commas (,). A maximum of 100 URLs can be specified.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PlayUrl")]
        [Validation(Required=false)]
        public string PlayUrl { get; set; }

        /// <summary>
        /// <para>The end time of the prefetch task in UTC. Example: 2016-06-30T19:00:00Z. The interval between EndTime and StartTime cannot exceed 6 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-30T19:00:00Z</para>
        /// </summary>
        [NameInMap("PreloadedEndTime")]
        [Validation(Required=false)]
        public string PreloadedEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the prefetch task in UTC. Example: 2016-06-29T19:00:00Z. If you do not specify this parameter, the default prefetch duration is 1 hour.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-29T19:00:00Z</para>
        /// </summary>
        [NameInMap("PreloadedStartTime")]
        [Validation(Required=false)]
        public string PreloadedStartTime { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
