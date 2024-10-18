// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetGroupLiveListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetGroupLiveListResponseBodyResult Result { get; set; }
        public class GetGroupLiveListResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>直播列表</para>
            /// </summary>
            [NameInMap("GroupLiveList")]
            [Validation(Required=false)]
            public List<GetGroupLiveListResponseBodyResultGroupLiveList> GroupLiveList { get; set; }
            public class GetGroupLiveListResponseBodyResultGroupLiveList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>nickName</para>
                /// </summary>
                [NameInMap("AnchorNickname")]
                [Validation(Required=false)]
                public string AnchorNickname { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Eijxx</para>
                /// </summary>
                [NameInMap("AnchorUnionId")]
                [Validation(Required=false)]
                public string AnchorUnionId { get; set; }

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
