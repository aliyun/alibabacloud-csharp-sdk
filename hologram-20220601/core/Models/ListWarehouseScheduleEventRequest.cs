// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ListWarehouseScheduleEventRequest : TeaModel {
        /// <summary>
        /// <para>The elastic scaling type, including time-based scaling and auto scaling. By default, all types are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>timed</para>
        /// </summary>
        [NameInMap("elasticType")]
        [Validation(Required=false)]
        public string ElasticType { get; set; }

        /// <summary>
        /// <para>The end timestamp. Default value: current time. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1777516201</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 30. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The start timestamp. Default value: three days ago. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1777257001</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
