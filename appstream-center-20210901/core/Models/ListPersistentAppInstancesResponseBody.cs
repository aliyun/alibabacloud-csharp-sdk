// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListPersistentAppInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The app instances of the persistent session type.</para>
        /// </summary>
        [NameInMap("PersistentAppInstanceModels")]
        [Validation(Required=false)]
        public List<ListPersistentAppInstancesResponseBodyPersistentAppInstanceModels> PersistentAppInstanceModels { get; set; }
        public class ListPersistentAppInstancesResponseBodyPersistentAppInstanceModels : TeaModel {
            /// <summary>
            /// <para>The ID of the delivery group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-0bxls9m9arax6****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the app instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ai-azn3kmwruh1vl****</para>
            /// </summary>
            [NameInMap("AppInstanceId")]
            [Validation(Required=false)]
            public string AppInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the app instance of the persistent session type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p-0cc7s3mw2fg4j****</para>
            /// </summary>
            [NameInMap("AppInstancePersistentId")]
            [Validation(Required=false)]
            public string AppInstancePersistentId { get; set; }

            /// <summary>
            /// <para>The name of the app instance of the persistent session type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-persistent-name</para>
            /// </summary>
            [NameInMap("AppInstancePersistentName")]
            [Validation(Required=false)]
            public string AppInstancePersistentName { get; set; }

            /// <summary>
            /// <para>The status of the app instance of the persistent session type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>STARTING</description></item>
            /// <item><description>RUNNING</description></item>
            /// <item><description>STOPPED</description></item>
            /// <item><description>UNAVAILABLE</description></item>
            /// <item><description>DELETING</description></item>
            /// <item><description>PENDING</description></item>
            /// <item><description>STOPPING</description></item>
            /// <item><description>DELETED</description></item>
            /// <item><description>REBUILDING</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("AppInstancePersistentStatus")]
            [Validation(Required=false)]
            public string AppInstancePersistentStatus { get; set; }

            /// <summary>
            /// <para>The status of the app instance.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INIT: The app instance is being initialized.</description></item>
            /// <item><description>STARTING: The app instance is being started.</description></item>
            /// <item><description>CLOSING: The app instance is being stopped.</description></item>
            /// <item><description>CLOSED: The app instance is closed.</description></item>
            /// <item><description>RUNNING: The app instance is running.</description></item>
            /// <item><description>idle: The app instance is idle.</description></item>
            /// <item><description>BOUND: The app instance is bound to an app instance group.</description></item>
            /// <item><description>UNAVAILABLE: The app instance is unavailable.</description></item>
            /// <item><description>DELETED: The app instance is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("AppInstanceStatus")]
            [Validation(Required=false)]
            public string AppInstanceStatus { get; set; }

            /// <summary>
            /// <para>The authorized users.</para>
            /// </summary>
            [NameInMap("AuthorizedUsers")]
            [Validation(Required=false)]
            public List<string> AuthorizedUsers { get; set; }

            /// <summary>
            /// <para>The time when the app instance was created.</para>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
