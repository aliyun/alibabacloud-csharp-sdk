// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class StartChatRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cf584733-<em><b>-</b></em>-9699-cb77aa3b7aa6</para>
        /// </summary>
        [NameInMap("AccessChannelId")]
        [Validation(Required=false)]
        public string AccessChannelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9XYGTGWtq2wFi_Bpg7aUnIoYi_vG_rO3bjEn0YtsxbHRHrYHlz1LDBLJAyZcLxieRQR4h_6AnWvTjJeNU5jg************Hwej7WgWrmA=</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserList")]
        [Validation(Required=false)]
        public List<StartChatRequestUserList> UserList { get; set; }
        public class StartChatRequestUserList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://xxx.com/image">http://xxx.com/image</a></para>
            /// </summary>
            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            [NameInMap("Nickname")]
            [Validation(Required=false)]
            public string Nickname { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fcd020fe-d8e4-40e5-8c77-1a272a174a7d</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CUSTOMER</para>
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

    }

}
