// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class PublishFeatureViewTableRequest : TeaModel {
        /// <summary>
        /// <para>Custom configurations for the task, provided as a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The event time of the data to be published, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("EventTime")]
        [Validation(Required=false)]
        public string EventTime { get; set; }

        /// <summary>
        /// <para>The synchronization mode. The following values are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Overwrite</c>: Overwrites all data in the specified partitions.</para>
        /// </description></item>
        /// <item><description><para><c>Merge</c>: Merges the new data with existing data in the specified partitions.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Overwrite</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>Specifies whether to synchronize data from the offline table to the online store.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OfflineToOnline")]
        [Validation(Required=false)]
        public bool? OfflineToOnline { get; set; }

        /// <summary>
        /// <para>The partitions to publish.</para>
        /// </summary>
        [NameInMap("Partitions")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> Partitions { get; set; }

    }

}
