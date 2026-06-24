// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListPersistentAppInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the query results currently displayed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of query results per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of persistent session application instances.</para>
        /// </summary>
        [NameInMap("PersistentAppInstanceModels")]
        [Validation(Required=false)]
        public List<ListPersistentAppInstancesResponseBodyPersistentAppInstanceModels> PersistentAppInstanceModels { get; set; }
        public class ListPersistentAppInstancesResponseBodyPersistentAppInstanceModels : TeaModel {
            /// <summary>
            /// <para>The delivery group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-0bxls9m9arax6****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The application instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ai-azn3kmwruh1vl****</para>
            /// </summary>
            [NameInMap("AppInstanceId")]
            [Validation(Required=false)]
            public string AppInstanceId { get; set; }

            /// <summary>
            /// <para>The persistent session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p-0cc7s3mw2fg4j****</para>
            /// </summary>
            [NameInMap("AppInstancePersistentId")]
            [Validation(Required=false)]
            public string AppInstancePersistentId { get; set; }

            /// <summary>
            /// <para>The name of the persistent session application instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-persistent-name</para>
            /// </summary>
            [NameInMap("AppInstancePersistentName")]
            [Validation(Required=false)]
            public string AppInstancePersistentName { get; set; }

            /// <summary>
            /// <para>The instance status of the persistent session application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("AppInstancePersistentStatus")]
            [Validation(Required=false)]
            public string AppInstancePersistentStatus { get; set; }

            /// <summary>
            /// <para>The application instance status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("AppInstanceStatus")]
            [Validation(Required=false)]
            public string AppInstanceStatus { get; set; }

            /// <summary>
            /// <para>The list of authorized usernames.</para>
            /// </summary>
            [NameInMap("AuthorizedUsers")]
            [Validation(Required=false)]
            public List<string> AuthorizedUsers { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-13T03:22:18.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
