// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class SwitchMainOrgResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public SwitchMainOrgResponseBodyContent Content { get; set; }
        public class SwitchMainOrgResponseBodyContent : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public object Data { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorCtx")]
        [Validation(Required=false)]
        public Dictionary<string, object> ErrorCtx { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
