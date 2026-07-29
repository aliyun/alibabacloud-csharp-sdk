// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ListWarehouseScheduleEventRequest : TeaModel {
        /// <summary>
        /// <para>The elastic type. If this parameter is omitted, events of all types are returned. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>timed</para>
        /// </summary>
        [NameInMap("elasticType")]
        [Validation(Required=false)]
        public string ElasticType { get; set; }

        /// <summary>
        /// <para>The end timestamp, in seconds. Defaults to the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1777516201</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The page number. Defaults to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default: 30. Maximum: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The start timestamp, in seconds. Defaults to three days ago.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1777257001</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
