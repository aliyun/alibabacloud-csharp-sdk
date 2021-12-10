// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class DeleteServiceHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// 用于确保实际更改的资源和期望更改的资源是一致的，该值来自Create，Get和Update API的响应
        /// </summary>
        [NameInMap("If-Match")]
        [Validation(Required=false)]
        public string IfMatch { get; set; }

        [NameInMap("X-Fc-Account-Id")]
        [Validation(Required=false)]
        public string XFcAccountId { get; set; }

        [NameInMap("X-Fc-Code-Checksum")]
        [Validation(Required=false)]
        public string XFcCodeChecksum { get; set; }

        [NameInMap("X-Fc-Date")]
        [Validation(Required=false)]
        public string XFcDate { get; set; }

        [NameInMap("X-Fc-Invocation-Type")]
        [Validation(Required=false)]
        public string XFcInvocationType { get; set; }

        [NameInMap("X-Fc-Log-Type")]
        [Validation(Required=false)]
        public string XFcLogType { get; set; }

        [NameInMap("X-Fc-Trace-Id")]
        [Validation(Required=false)]
        public string XFcTraceId { get; set; }

    }

}
