// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsGroupConsumerUpdateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the consumer group for which you want to configure read permissions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GID_test_groupId</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the instance to which the consumer group you want to configure belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MQ_INST_111111111111_DOxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to authorize the consumer group to read messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The consumer group can read messages.</description></item>
        /// <item><description><b>false</b>: The consumer group cannot read messages.</description></item>
        /// </list>
        /// <para>Default value: <b>true</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ReadEnable")]
        [Validation(Required=false)]
        public bool? ReadEnable { get; set; }

    }

}
