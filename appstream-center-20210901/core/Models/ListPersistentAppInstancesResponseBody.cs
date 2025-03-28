// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListPersistentAppInstancesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PersistentAppInstanceModels")]
        [Validation(Required=false)]
        public List<ListPersistentAppInstancesResponseBodyPersistentAppInstanceModels> PersistentAppInstanceModels { get; set; }
        public class ListPersistentAppInstancesResponseBodyPersistentAppInstanceModels : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>aig-0bxls9m9arax6****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ai-azn3kmwruh1vl****</para>
            /// </summary>
            [NameInMap("AppInstanceId")]
            [Validation(Required=false)]
            public string AppInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>p-0cc7s3mw2fg4j****</para>
            /// </summary>
            [NameInMap("AppInstancePersistentId")]
            [Validation(Required=false)]
            public string AppInstancePersistentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-persistent-name</para>
            /// </summary>
            [NameInMap("AppInstancePersistentName")]
            [Validation(Required=false)]
            public string AppInstancePersistentName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("AppInstancePersistentStatus")]
            [Validation(Required=false)]
            public string AppInstancePersistentStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("AppInstanceStatus")]
            [Validation(Required=false)]
            public string AppInstanceStatus { get; set; }

            [NameInMap("AuthorizedUsers")]
            [Validation(Required=false)]
            public List<string> AuthorizedUsers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-03-13T03:22:18.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
