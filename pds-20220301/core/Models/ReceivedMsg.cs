// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ReceivedMsg : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("has_read")]
        [Validation(Required=false)]
        public bool? HasRead { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("msg_category")]
        [Validation(Required=false)]
        public string MsgCategory { get; set; }

        [NameInMap("msg_content")]
        [Validation(Required=false)]
        public ReceivedMsgMsgContent MsgContent { get; set; }
        public class ReceivedMsgMsgContent : TeaModel {
            [NameInMap("msg_data")]
            [Validation(Required=false)]
            public Dictionary<string, object> MsgData { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50d6f2aaa16525c7d053998e48fac265962f585f</para>
        /// </summary>
        [NameInMap("msg_id")]
        [Validation(Required=false)]
        public string MsgId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>change_user_setting</para>
        /// </summary>
        [NameInMap("msg_sub_category")]
        [Validation(Required=false)]
        public string MsgSubCategory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>edit_user</para>
        /// </summary>
        [NameInMap("msg_type")]
        [Validation(Required=false)]
        public string MsgType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1716363191123</para>
        /// </summary>
        [NameInMap("publish_at")]
        [Validation(Required=false)]
        public long? PublishAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1716363191123</para>
        /// </summary>
        [NameInMap("read_at")]
        [Validation(Required=false)]
        public long? ReadAt { get; set; }

    }

}
