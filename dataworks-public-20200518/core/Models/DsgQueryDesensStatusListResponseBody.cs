// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgQueryDesensStatusListResponseBody : TeaModel {
        /// <summary>
        /// <para>Response data details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DsgQueryDesensStatusListResponseBodyData Data { get; set; }
        public class DsgQueryDesensStatusListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Data masking rule type.</para>
            /// </summary>
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<DsgQueryDesensStatusListResponseBodyDataPageData> PageData { get; set; }
            public class DsgQueryDesensStatusListResponseBodyDataPageData : TeaModel {
                /// <summary>
                /// <para>Switch status
                /// 1: Enabled
                /// 0: Disabled</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DesensStatus")]
                [Validation(Required=false)]
                public int? DesensStatus { get; set; }

                /// <summary>
                /// <para>Represents project space name or workspace ID depending on the scenario</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("HandleSpace")]
                [Validation(Required=false)]
                public string HandleSpace { get; set; }

                /// <summary>
                /// <para>Switch ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>56207</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Workspace unique identifier</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_space</para>
                /// </summary>
                [NameInMap("WorkspaceIdentifier")]
                [Validation(Required=false)]
                public string WorkspaceIdentifier { get; set; }

                /// <summary>
                /// <para>Workspace name</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_space</para>
                /// </summary>
                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

            /// <summary>
            /// <para>Page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>Number of records displayed per page
            /// .</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400010</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Error message
        /// .</para>
        /// 
        /// <b>Example:</b>
        /// <para>param error</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AASFDFSDFG-DFSDF-DFSDFD-SDFSDF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
