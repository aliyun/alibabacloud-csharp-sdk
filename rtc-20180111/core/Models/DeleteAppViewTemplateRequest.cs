// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DeleteAppViewTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can create and query the ID in the console. Only a single ID can be specified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wv7N****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The template information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public DeleteAppViewTemplateRequestTemplate Template { get; set; }
        public class DeleteAppViewTemplateRequestTemplate : TeaModel {
            /// <summary>
            /// <para>The template ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xd4c****</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

    }

}
