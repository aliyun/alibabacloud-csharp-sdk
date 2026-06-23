// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateScheduledPreloadExecutionRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the scheduled prefetch plan, in ISO 8601 format (such as 2024-01-01T00:00:00+Z).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-05-31T18:10:48.849+08:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The prefetch plan ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66599bd7397885b43804901c</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The execution interval between each batch of the scheduled prefetch plan, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The number of URLs to prefetch per batch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SliceLen")]
        [Validation(Required=false)]
        public int? SliceLen { get; set; }

        /// <summary>
        /// <para>The start time of the scheduled prefetch plan, in ISO 8601 format (such as 2024-01-01T00:00:00+Z).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-05-31T17:10:48.849+08:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
