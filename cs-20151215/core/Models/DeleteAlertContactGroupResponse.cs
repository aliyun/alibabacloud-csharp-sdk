// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteAlertContactGroupResponse : Darabonba.Model {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<DeleteAlertContactGroupResponseBody> Body { get; set; }
        public class DeleteAlertContactGroupResponseBody : Darabonba.Model {
            /// <summary>
            /// <para>The deletion status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Deleted.</description></item>
            /// <item><description>false: Failed to delete.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

            /// <summary>
            /// <para>The message returned when the operation fails.</para>
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

