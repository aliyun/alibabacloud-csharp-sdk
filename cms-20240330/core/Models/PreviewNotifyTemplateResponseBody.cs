// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class PreviewNotifyTemplateResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public PreviewNotifyTemplateResponseBodyData Data { get; set; }
        public class PreviewNotifyTemplateResponseBodyData : TeaModel {
            [NameInMap("failed")]
            [Validation(Required=false)]
            public Dictionary<string, object> Failed { get; set; }

            [NameInMap("success")]
            [Validation(Required=false)]
            public Dictionary<string, object> Success { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>请求ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>452faed9-ab3b-4340-8a92-bc7d9b98f17a</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
