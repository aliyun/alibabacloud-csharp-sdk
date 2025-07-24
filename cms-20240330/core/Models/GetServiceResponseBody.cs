// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetServiceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>264C3E89-BE6E-5F82-A484-CE9C2196C7DC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("service")]
        [Validation(Required=false)]
        public GetServiceResponseBodyService Service { get; set; }
        public class GetServiceResponseBodyService : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;language&quot;:&quot;java&quot;}</para>
            /// </summary>
            [NameInMap("attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-05-13T03:32:55Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>by6rjzro2j@0fe8dfa799e5906</para>
            /// </summary>
            [NameInMap("pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-heyuan</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cwzxvuc6uo@4bc6b15ad81f166174ffb</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo-app</para>
            /// </summary>
            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("serviceStatus")]
            [Validation(Required=false)]
            public string ServiceStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TRACE</para>
            /// </summary>
            [NameInMap("serviceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default-cms-1106439496876715-cn-hangzhou</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

    }

}
