// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetComputeClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster details.</para>
        /// </summary>
        [NameInMap("ClusterConfig")]
        [Validation(Required=false)]
        public GetComputeClusterResponseBodyClusterConfig ClusterConfig { get; set; }
        public class GetComputeClusterResponseBodyClusterConfig : TeaModel {
            /// <summary>
            /// <para>The cluster security control configuration.</para>
            /// </summary>
            [NameInMap("ClusterSafetyControl")]
            [Validation(Required=false)]
            public GetComputeClusterResponseBodyClusterConfigClusterSafetyControl ClusterSafetyControl { get; set; }
            public class GetComputeClusterResponseBodyClusterConfigClusterSafetyControl : TeaModel {
                /// <summary>
                /// <para>The control mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CREATE_COMPUTE_SOURCE</para>
                /// </summary>
                [NameInMap("ClusterSafetyAuthType")]
                [Validation(Required=false)]
                public string ClusterSafetyAuthType { get; set; }

                /// <summary>
                /// <para>The list of whitelisted user group IDs.</para>
                /// </summary>
                [NameInMap("UserGroupIds")]
                [Validation(Required=false)]
                public List<string> UserGroupIds { get; set; }

                /// <summary>
                /// <para>The list of whitelisted user group names.</para>
                /// </summary>
                [NameInMap("UserGroupNames")]
                [Validation(Required=false)]
                public List<string> UserGroupNames { get; set; }

                /// <summary>
                /// <para>The list of whitelisted user IDs.</para>
                /// </summary>
                [NameInMap("UserIds")]
                [Validation(Required=false)]
                public List<string> UserIds { get; set; }

                /// <summary>
                /// <para>The list of whitelisted usernames.</para>
                /// </summary>
                [NameInMap("UserNames")]
                [Validation(Required=false)]
                public List<string> UserNames { get; set; }

            }

            /// <summary>
            /// <para>The cluster description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Des")]
            [Validation(Required=false)]
            public string Des { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30 08:00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30 08:00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102311</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster_test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The cluster owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30012211</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The cluster version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CDH6</para>
            /// </summary>
            [NameInMap("TypeVersion")]
            [Validation(Required=false)]
            public string TypeVersion { get; set; }

        }

        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of the backend exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
