// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetLiveStreamPreloadTasksRequest : TeaModel {
        /// <summary>
        /// <para>The acceleration region where you want to prefetch the live content. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>domestic: regions in the Chinese mainland.</description></item>
        /// <item><description>overseas: regions outside the Chinese mainland.</description></item>
        /// <item><description>global: regions in and outside the Chinese mainland.</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, the acceleration region configured for the domain name is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>domestic</para>
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// <para>The streaming domain name.</para>
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
        /// <para>The streaming URL. You can specify up to 100 streaming URLs in a request. Separate multiple streaming URLs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PlayUrl")]
        [Validation(Required=false)]
        public string PlayUrl { get; set; }

        /// <summary>
        /// <para>The end time of the prefetch task. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. Example: 2016-06-30T19:00:00Z. The interval between the start time and end time cannot exceed 6 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-30T19:00:00Z</para>
        /// </summary>
        [NameInMap("PreloadedEndTime")]
        [Validation(Required=false)]
        public string PreloadedEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the prefetch task. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. Example: 2016-06-29T19:00:00Z. If you do not specify this parameter, the prefetch task runs for 1 hour by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-29T19:00:00Z</para>
        /// </summary>
        [NameInMap("PreloadedStartTime")]
        [Validation(Required=false)]
        public string PreloadedStartTime { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
