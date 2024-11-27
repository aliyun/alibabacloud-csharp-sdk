// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsConsumerAccumulateRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query the details of each topic to which the consumer group subscribes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The details of each topic are queried. You can obtain the details from the <b>DetailInTopicList</b> response parameter.</description></item>
        /// <item><description><b>false</b>: The details of each topic are not queried. This is the default value. If you use this value, the value of the <b>DetailInTopicList</b> response parameter is empty.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public bool? Detail { get; set; }

        /// <summary>
        /// <para>The ID of the consumer group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GID_test_consumer_id</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MQ_INST_111111111111_DOxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
