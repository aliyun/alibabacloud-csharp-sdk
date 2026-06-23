// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteAlertContactGroupResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<DeleteAlertContactGroupResponseBody> Body { get; set; }
        public class DeleteAlertContactGroupResponseBody : TeaModel {
            /// <summary>
            /// <para>Deletion status.</para>
            /// <list type="bullet">
            /// <item><description>true: Deletion successful.</description></item>
            /// <item><description>false: Deletion failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

            /// <summary>
            /// <para>The message returned when execution fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Delete contact group resource failed.</para>
            /// </summary>
            [NameInMap("msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// <para>Alert contact group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("contact_group_id")]
            [Validation(Required=false)]
            public string ContactGroupId { get; set; }

        }

    }

}
