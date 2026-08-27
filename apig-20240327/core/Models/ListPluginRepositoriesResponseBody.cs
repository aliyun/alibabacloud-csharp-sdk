// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListPluginRepositoriesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListPluginRepositoriesResponseBodyData> Data { get; set; }
        public class ListPluginRepositoriesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>664f1e2xxxx</para>
            /// </summary>
            [NameInMap("organizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my-org</para>
            /// </summary>
            [NameInMap("organizationName")]
            [Validation(Required=false)]
            public string OrganizationName { get; set; }

            [NameInMap("repositories")]
            [Validation(Required=false)]
            public List<ListPluginRepositoriesResponseBodyDataRepositories> Repositories { get; set; }
            public class ListPluginRepositoriesResponseBodyDataRepositories : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>12345678</para>
                /// </summary>
                [NameInMap("repositoryId")]
                [Validation(Required=false)]
                public string RepositoryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>my-custom-plugin</para>
                /// </summary>
                [NameInMap("repositoryName")]
                [Validation(Required=false)]
                public string RepositoryName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FCA83-0416-588D-9763-2474980495F1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
