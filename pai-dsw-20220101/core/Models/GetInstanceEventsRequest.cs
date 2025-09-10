// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class GetInstanceEventsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-08T15:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("EventLevel")]
        [Validation(Required=false)]
        public string EventLevel { get; set; }

        /// <summary>
        /// <para>The maximum number of events. Default value: 2000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("MaxEventsNum")]
        [Validation(Required=false)]
        public int? MaxEventsNum { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-08T15:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The token used to share the URL.</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
