// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DeleteAppRecordTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can create and query the ID in the console. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac7N****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The idempotency parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53200b81-b761-4c10-842a-a0726d97xxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The template information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public DeleteAppRecordTemplateRequestTemplate Template { get; set; }
        public class DeleteAppRecordTemplateRequestTemplate : TeaModel {
            /// <summary>
            /// <para>The template ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2xh6****</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

    }

}
