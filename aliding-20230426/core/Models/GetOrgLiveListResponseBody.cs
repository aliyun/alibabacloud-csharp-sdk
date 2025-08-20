// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetOrgLiveListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetOrgLiveListResponseBodyResult Result { get; set; }
        public class GetOrgLiveListResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>新建的直播列表</para>
            /// </summary>
            [NameInMap("NewLive")]
            [Validation(Required=false)]
            public GetOrgLiveListResponseBodyResultNewLive NewLive { get; set; }
            public class GetOrgLiveListResponseBodyResultNewLive : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasMore")]
                [Validation(Required=false)]
                public bool? HasMore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("LiveList")]
                [Validation(Required=false)]
                public List<GetOrgLiveListResponseBodyResultNewLiveLiveList> LiveList { get; set; }
                public class GetOrgLiveListResponseBodyResultNewLiveLiveList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>nickName</para>
                    /// </summary>
                    [NameInMap("AnchorNickname")]
                    [Validation(Required=false)]
                    public string AnchorNickname { get; set; }

                    [NameInMap("AnchorUnionId")]
                    [Validation(Required=false)]
                    public string AnchorUnionId { get; set; }

                    [NameInMap("AnchorUnionIdInAlibaba")]
                    [Validation(Required=false)]
                    public string AnchorUnionIdInAlibaba { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ersqqdddf</para>
                    /// </summary>
                    [NameInMap("AnchorUserId")]
                    [Validation(Required=false)]
                    public string AnchorUserId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1398324600000</para>
                    /// </summary>
                    [NameInMap("LiveEndTime")]
                    [Validation(Required=false)]
                    public long? LiveEndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1398321600000</para>
                    /// </summary>
                    [NameInMap("LiveStartTime")]
                    [Validation(Required=false)]
                    public long? LiveStartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>4d38xxxxx</para>
                    /// </summary>
                    [NameInMap("LiveUuid")]
                    [Validation(Required=false)]
                    public string LiveUuid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>群OpenConversationId</para>
                    /// </summary>
                    [NameInMap("ShareOpenConversationIds")]
                    [Validation(Required=false)]
                    public List<string> ShareOpenConversationIds { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>直播标题</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public long? PageNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public long? PageSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>修改的直播列表</para>
            /// </summary>
            [NameInMap("UpdateLive")]
            [Validation(Required=false)]
            public GetOrgLiveListResponseBodyResultUpdateLive UpdateLive { get; set; }
            public class GetOrgLiveListResponseBodyResultUpdateLive : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasMore")]
                [Validation(Required=false)]
                public bool? HasMore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("LiveList")]
                [Validation(Required=false)]
                public List<GetOrgLiveListResponseBodyResultUpdateLiveLiveList> LiveList { get; set; }
                public class GetOrgLiveListResponseBodyResultUpdateLiveLiveList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>nickName</para>
                    /// </summary>
                    [NameInMap("AnchorNickname")]
                    [Validation(Required=false)]
                    public string AnchorNickname { get; set; }

                    [NameInMap("AnchorUnionId")]
                    [Validation(Required=false)]
                    public string AnchorUnionId { get; set; }

                    [NameInMap("AnchorUnionIdInAlibaba")]
                    [Validation(Required=false)]
                    public string AnchorUnionIdInAlibaba { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>012345</para>
                    /// </summary>
                    [NameInMap("AnchorUserId")]
                    [Validation(Required=false)]
                    public string AnchorUserId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1398324600000</para>
                    /// </summary>
                    [NameInMap("LiveEndTime")]
                    [Validation(Required=false)]
                    public long? LiveEndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1398321600000</para>
                    /// </summary>
                    [NameInMap("LiveStartTime")]
                    [Validation(Required=false)]
                    public long? LiveStartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>4d38xxxxx</para>
                    /// </summary>
                    [NameInMap("LiveUuid")]
                    [Validation(Required=false)]
                    public string LiveUuid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>直播标题</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public long? PageNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public long? PageSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
