// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListTopicsRequest : TeaModel {
        /// <summary>
        /// <para>The start time for discovery. Specify the time in UTC format (yyyy-MM-dd\&quot;T\&quot;HH:mm:ssZ).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-03-24T00:00:00+0800</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public string BeginTime { get; set; }

        /// <summary>
        /// <para>The end time for discovery. Specify the time in UTC format (yyyy-MM-dd\&quot;T\&quot;HH:mm:ssZ).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-03-25T23:00:00+0800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The instance ID associated with the event. This parameter is mutually exclusive with NodeId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the node associated with the event. This parameter is mutually exclusive with InstanceId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud UID of the event owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>952795****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1. Minimum value: 1. Maximum value: 30.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The status of the event. Valid values: IGNORE (ignored), NEW (newly discovered), FIXING (being processed), and RECOVER (recovered). Separate multiple event statuses with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>IGNORE,NEW,FIXING,RECOVER</para>
        /// </summary>
        [NameInMap("TopicStatuses")]
        [Validation(Required=false)]
        public string TopicStatuses { get; set; }

        /// <summary>
        /// <para>The type of the event. Valid values: SLOW (slow) and ERROR (error). Separate multiple event types with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR,SLOW</para>
        /// </summary>
        [NameInMap("TopicTypes")]
        [Validation(Required=false)]
        public string TopicTypes { get; set; }

    }

}
