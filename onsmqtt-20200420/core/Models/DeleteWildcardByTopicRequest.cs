// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class DeleteWildcardByTopicRequest : TeaModel {
        /// <summary>
        /// <para>The first-level topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("FirstTopic")]
        [Validation(Required=false)]
        public string FirstTopic { get; set; }

        /// <summary>
        /// <para>The ID of the instance to which the group ID that you want to delete belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mqtt-cn-0pp1ldu****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The wildcard subscriptions to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test/#</para>
        /// </summary>
        [NameInMap("Wildcards")]
        [Validation(Required=false)]
        public string Wildcards { get; set; }

    }

}
