// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListQueueConsumersRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ApsaraMQ for RabbitMQ instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amqp-cn-5yd3aw******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The token that marks the end of the current page of results. To retrieve the next page, include this token in the next request. If this is your first request or the last page is returned, the value is an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of entries to return. If you do not set this parameter, the default value is 1.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("QueryCount")]
        [Validation(Required=false)]
        public int? QueryCount { get; set; }

        /// <summary>
        /// <para>The queue name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>queue-rabbit-springboot-advance5</para>
        /// </summary>
        [NameInMap("Queue")]
        [Validation(Required=false)]
        public string Queue { get; set; }

        /// <summary>
        /// <para>The vhost name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("VirtualHost")]
        [Validation(Required=false)]
        public string VirtualHost { get; set; }

    }

}
