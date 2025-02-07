// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SysomOpenAPI.ServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyData> Data { get; set; }
        public class ListInstancesResponseBodyData : TeaModel {
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("instance")]
            [Validation(Required=false)]
            public string Instance { get; set; }

            [NameInMap("kernel_version")]
            [Validation(Required=false)]
            public string KernelVersion { get; set; }

            [NameInMap("meta")]
            [Validation(Required=false)]
            public object Meta { get; set; }

            [NameInMap("os_arch")]
            [Validation(Required=false)]
            public string OsArch { get; set; }

            [NameInMap("os_health_score")]
            [Validation(Required=false)]
            public string OsHealthScore { get; set; }

            [NameInMap("os_name")]
            [Validation(Required=false)]
            public string OsName { get; set; }

            [NameInMap("os_name_id")]
            [Validation(Required=false)]
            public string OsNameId { get; set; }

            [NameInMap("os_version")]
            [Validation(Required=false)]
            public string OsVersion { get; set; }

            [NameInMap("os_version_id")]
            [Validation(Required=false)]
            public string OsVersionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Requests for llm service failed</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9515E5A0-8905-59B0-9BBF-5F0BE568C3A0</para>
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>623</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
