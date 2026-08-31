// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListAssetTopicsResponseBody : TeaModel {
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
        /// <para>The paginated result of asset topics.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAssetTopicsResponseBodyData Data { get; set; }
        public class ListAssetTopicsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of topics.</para>
            /// </summary>
            [NameInMap("TopicList")]
            [Validation(Required=false)]
            public List<ListAssetTopicsResponseBodyDataTopicList> TopicList { get; set; }
            public class ListAssetTopicsResponseBodyDataTopicList : TeaModel {
                /// <summary>
                /// <para>The asset type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TABLE</para>
                /// </summary>
                [NameInMap("AssetType")]
                [Validation(Required=false)]
                public string AssetType { get; set; }

                /// <summary>
                /// <para>The last modified time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>The topic administrators.</para>
                /// </summary>
                [NameInMap("Owners")]
                [Validation(Required=false)]
                public List<ListAssetTopicsResponseBodyDataTopicListOwners> Owners { get; set; }
                public class ListAssetTopicsResponseBodyDataTopicListOwners : TeaModel {
                    /// <summary>
                    /// <para>The user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30001011</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    /// <summary>
                    /// <para>The username.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>John</para>
                    /// </summary>
                    [NameInMap("UserName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

                /// <summary>
                /// <para>The topic description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Aggregates assets related to core metrics</para>
                /// </summary>
                [NameInMap("TopicDescription")]
                [Validation(Required=false)]
                public string TopicDescription { get; set; }

                /// <summary>
                /// <para>The topic ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>28440278777</para>
                /// </summary>
                [NameInMap("TopicId")]
                [Validation(Required=false)]
                public long? TopicId { get; set; }

                /// <summary>
                /// <para>The topic name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Core Metrics Topic</para>
                /// </summary>
                [NameInMap("TopicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

                /// <summary>
                /// <para>The visibility scope. Valid values: PUBLIC, SPECIFIED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SPECIFIED</para>
                /// </summary>
                [NameInMap("VisibilityType")]
                [Validation(Required=false)]
                public string VisibilityType { get; set; }

                /// <summary>
                /// <para>The explicitly visible user groups. Returns null for PUBLIC topics.</para>
                /// </summary>
                [NameInMap("VisibleUserGroups")]
                [Validation(Required=false)]
                public List<ListAssetTopicsResponseBodyDataTopicListVisibleUserGroups> VisibleUserGroups { get; set; }
                public class ListAssetTopicsResponseBodyDataTopicListVisibleUserGroups : TeaModel {
                    /// <summary>
                    /// <para>The user group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20001</para>
                    /// </summary>
                    [NameInMap("UserGroupId")]
                    [Validation(Required=false)]
                    public string UserGroupId { get; set; }

                    /// <summary>
                    /// <para>The user group name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Data Governance Group</para>
                    /// </summary>
                    [NameInMap("UserGroupName")]
                    [Validation(Required=false)]
                    public string UserGroupName { get; set; }

                }

                /// <summary>
                /// <para>The explicitly visible users. Returns null for PUBLIC topics.</para>
                /// </summary>
                [NameInMap("VisibleUsers")]
                [Validation(Required=false)]
                public List<ListAssetTopicsResponseBodyDataTopicListVisibleUsers> VisibleUsers { get; set; }
                public class ListAssetTopicsResponseBodyDataTopicListVisibleUsers : TeaModel {
                    /// <summary>
                    /// <para>The user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30001012</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    /// <summary>
                    /// <para>The username.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Jane</para>
                    /// </summary>
                    [NameInMap("UserName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

            }

            /// <summary>
            /// <para>The total number of records that match the query conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-599403204152</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

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
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
