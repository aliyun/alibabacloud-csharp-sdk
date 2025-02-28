// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteAlertContactResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public DeleteAlertContactResponseBody Body { get; set; }
        public class DeleteAlertContactResponseBody : TeaModel {
            [NameInMap("result")]
            [Validation(Required=false)]
            public List<DeleteAlertContactResponseBodyResult> Result { get; set; }
            public class DeleteAlertContactResponseBodyResult : TeaModel {
                /// <summary>
                /// <para>The deletion status.</para>
                /// <list type="bullet">
                /// <item><description>true: The alert contact was deleted.</description></item>
                /// <item><description>false: The alert contact failed to be deleted.</description></item>
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
                /// <para>Delete contact resource failed.</para>
                /// </summary>
                [NameInMap("msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// <para>An alert contact ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("contact_id")]
                [Validation(Required=false)]
                public string ContactId { get; set; }

            }

        }

    }

}
