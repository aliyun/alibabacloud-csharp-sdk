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
            /// <para>The deletion status.</para>
            /// <list type="bullet">
            /// <item><description>true: The alert contact group was deleted.</description></item>
            /// <item><description>false: The alert contact group failed to be deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

            /// <summary>
            /// <para>The error message returned if the call fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Delete contact group resource failed.</para>
            /// </summary>
            [NameInMap("msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// <para>The alert contact group ID.</para>
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
