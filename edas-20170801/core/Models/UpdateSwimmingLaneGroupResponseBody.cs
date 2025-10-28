// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateSwimmingLaneGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data that is returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateSwimmingLaneGroupResponseBodyData Data { get; set; }
        public class UpdateSwimmingLaneGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of applications related to the lane group.</para>
            /// </summary>
            [NameInMap("ApplicationList")]
            [Validation(Required=false)]
            public List<UpdateSwimmingLaneGroupResponseBodyDataApplicationList> ApplicationList { get; set; }
            public class UpdateSwimmingLaneGroupResponseBodyDataApplicationList : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>476d26d9-b54c-40b8-8af9-d898cdc2****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-app</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

            }

            /// <summary>
            /// <para>The EDAS ingress gateway information.</para>
            /// </summary>
            [NameInMap("EntryApplication")]
            [Validation(Required=false)]
            public UpdateSwimmingLaneGroupResponseBodyDataEntryApplication EntryApplication { get; set; }
            public class UpdateSwimmingLaneGroupResponseBodyDataEntryApplication : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d52c9de9-53d0-4191-aa72-88974a6f****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-gateway</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the lane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>98</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the lane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou:test</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

        }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7580ED24-A2F0-5ECC-9F2B-B92E2509****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
