// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsConsumerGetConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the consumer group whose client connection status you want to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GID_test_consumer_id</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the instance to which the consumer group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MQ_INST_111111111111_DOxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
