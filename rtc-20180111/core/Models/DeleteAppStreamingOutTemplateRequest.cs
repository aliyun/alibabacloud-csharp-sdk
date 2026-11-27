// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DeleteAppStreamingOutTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can create and query the ID in the console. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wv7N****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The stream ingest template information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StreamingOutTemplate")]
        [Validation(Required=false)]
        public DeleteAppStreamingOutTemplateRequestStreamingOutTemplate StreamingOutTemplate { get; set; }
        public class DeleteAppStreamingOutTemplateRequestStreamingOutTemplate : TeaModel {
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
