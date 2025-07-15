// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyLiveMessageUserInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The users whose information failed to be modified.</para>
        /// </summary>
        [NameInMap("FailList")]
        [Validation(Required=false)]
        public List<ModifyLiveMessageUserInfoResponseBodyFailList> FailList { get; set; }
        public class ModifyLiveMessageUserInfoResponseBodyFailList : TeaModel {
            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>440</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public int? Code { get; set; }

            /// <summary>
            /// <para>The ID of the group to which the user belongs. For failed modification, the information of the user is not updated when you query the users in the group. You can try again after you check the failure reason and fix the issue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>grouptest2</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The reason why the information of the user failed to be modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group not exists or already deleted</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>Indicates whether the group to which the user belongs is modified. In this case, the group is not modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3271ACD2-F143-1204-AFDB-9A87C131****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The users whose information was modified.</para>
        /// </summary>
        [NameInMap("SuccessList")]
        [Validation(Required=false)]
        public List<ModifyLiveMessageUserInfoResponseBodySuccessList> SuccessList { get; set; }
        public class ModifyLiveMessageUserInfoResponseBodySuccessList : TeaModel {
            /// <summary>
            /// <para>The ID of the group to which the user belongs. For successful modification, the information of the user is updated when you query the users in the group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>grouptest1</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>Indicates whether the group to which the user belongs is modified. In this case, the group is modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
