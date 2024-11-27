// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsDLQMessageResendByIdRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the consumer group in which you want to query dead-letter messages.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GID_test_group_id</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the instance in which the dead-letter message you want to query resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MQ_INST_188077086902****_BXSuW61e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the dead-letter message that you want to send to a consumer group for consumption.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0BC16699343051CD9F1D798E7734****</para>
        /// </summary>
        [NameInMap("MsgId")]
        [Validation(Required=false)]
        public string MsgId { get; set; }

    }

}
