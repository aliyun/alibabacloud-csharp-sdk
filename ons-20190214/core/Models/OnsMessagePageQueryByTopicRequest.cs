// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsMessagePageQueryByTopicRequest : TeaModel {
        /// <summary>
        /// <para>The beginning of the time range to query. The value of this parameter is a UNIX timestamp in milliseconds. If you specify a valid value for the <b>TaskId</b> parameter in the request, this parameter does not take effect. The system uses the value of the BeginTime parameter that you specified in the request when you created the specified query task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1570723200000</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Pages start from page 1. Valid values: 1 to 50.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value of this parameter is a UNIX timestamp in milliseconds. If you specify a valid value for the <b>TaskId</b> parameter in the request, this parameter does not take effect. The system uses the value of the EndTime parameter that you specified in the request when you created the specified query task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1570809600000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the instance to which the message you want to query belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MQ_INST_111111111111_DOxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 5 to 50. Default value: 20. If you specify a valid value for the <b>TaskId</b> parameter in the request, this parameter does not take effect. The system uses the value of the PageSize parameter that you specified in the request for creating the query task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the query task. The first time you call this operation to query the information about messages in a specified topic within a specified time range, this parameter is not required. This parameter is required in subsequent queries for messages on a specified page. You can obtain the task ID from the returned result of the first query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0BC1310300002A9F000021E4D7A48346</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The name of the topic whose messages you want to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-mq_topic</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
