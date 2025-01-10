// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListHotelSceneItemsRequest : TeaModel {
        /// <summary>
        /// <para>hotelID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80d84ea8ed9e422fbad52715c8fc56f1</para>
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// <para>ListHotelSceneReq</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListHotelSceneReq")]
        [Validation(Required=false)]
        public ListHotelSceneItemsRequestListHotelSceneReq ListHotelSceneReq { get; set; }
        public class ListHotelSceneItemsRequestListHotelSceneReq : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>客用品类</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>棉签</para>
            /// </summary>
            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public string Keywords { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public ListHotelSceneItemsRequestListHotelSceneReqPage Page { get; set; }
            public class ListHotelSceneItemsRequestListHotelSceneReqPage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public int? PageNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>已添加</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GOODS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
