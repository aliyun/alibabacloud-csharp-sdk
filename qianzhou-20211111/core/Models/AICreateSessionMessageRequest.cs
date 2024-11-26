// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qianzhou20211111.Models
{
    public class AICreateSessionMessageRequest : TeaModel {
        [NameInMap("context")]
        [Validation(Required=false)]
        public AICreateSessionMessageRequestContext Context { get; set; }
        public class AICreateSessionMessageRequestContext : TeaModel {
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            [NameInMap("kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("session_id")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>QA / K8S_DIAGNOSE</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("employee_id")]
        [Validation(Required=false)]
        public string EmployeeId { get; set; }

    }

}
