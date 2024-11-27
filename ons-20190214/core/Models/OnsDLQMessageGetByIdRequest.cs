// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsDLQMessageGetByIdRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the consumer group whose dead-letter message you want to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GID_test_group_id</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

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
        /// <para>The ID of the dead-letter message that you want to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0BC16699165C03B925DB8A404E2D****</para>
        /// </summary>
        [NameInMap("MsgId")]
        [Validation(Required=false)]
        public string MsgId { get; set; }

    }

}
