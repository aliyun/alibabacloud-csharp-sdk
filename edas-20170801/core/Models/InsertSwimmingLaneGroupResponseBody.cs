// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertSwimmingLaneGroupResponseBody : TeaModel {
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
        public InsertSwimmingLaneGroupResponseBodyData Data { get; set; }
        public class InsertSwimmingLaneGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of all applications that are related to the lane group.</para>
            /// </summary>
            [NameInMap("ApplicationList")]
            [Validation(Required=false)]
            public InsertSwimmingLaneGroupResponseBodyDataApplicationList ApplicationList { get; set; }
            public class InsertSwimmingLaneGroupResponseBodyDataApplicationList : TeaModel {
                [NameInMap("Application")]
                [Validation(Required=false)]
                public List<InsertSwimmingLaneGroupResponseBodyDataApplicationListApplication> Application { get; set; }
                public class InsertSwimmingLaneGroupResponseBodyDataApplicationListApplication : TeaModel {
                    /// <summary>
                    /// <para>The ID of the application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bdb251cc-02a6-48dd-891b-2ab21b25****</para>
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

            }

            /// <summary>
            /// <para>The information about the Enterprise Distributed Application Service (EDAS) ingress gateway.</para>
            /// </summary>
            [NameInMap("EntryApplication")]
            [Validation(Required=false)]
            public InsertSwimmingLaneGroupResponseBodyDataEntryApplication EntryApplication { get; set; }
            public class InsertSwimmingLaneGroupResponseBodyDataEntryApplication : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bdb251cc-02a6-48dd-891b-2ab21b25c****</para>
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
            /// <para>The ID of the lane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the lane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
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
        /// <para>D5268CAC-D356-5C8D-BC7C-FBE0D13B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
