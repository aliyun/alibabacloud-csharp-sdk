// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListHotelSceneItemsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0EC7*726E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListHotelSceneItemsResponseBodyResult Result { get; set; }
        public class ListHotelSceneItemsResponseBodyResult : TeaModel {
            [NameInMap("Page")]
            [Validation(Required=false)]
            public ListHotelSceneItemsResponseBodyResultPage Page { get; set; }
            public class ListHotelSceneItemsResponseBodyResultPage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>False</para>
                /// </summary>
                [NameInMap("HasNext")]
                [Validation(Required=false)]
                public bool? HasNext { get; set; }

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

                /// <summary>
                /// <b>Example:</b>
                /// <para>23</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("TotalPage")]
                [Validation(Required=false)]
                public int? TotalPage { get; set; }

            }

            [NameInMap("SceneItemList")]
            [Validation(Required=false)]
            public List<ListHotelSceneItemsResponseBodyResultSceneItemList> SceneItemList { get; set; }
            public class ListHotelSceneItemsResponseBodyResultSceneItemList : TeaModel {
                [NameInMap("BeyondLimitReply")]
                [Validation(Required=false)]
                public string BeyondLimitReply { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>客用品类</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("DeliveryMethod")]
                [Validation(Required=false)]
                public string DeliveryMethod { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://ailabsaicloudservice.alicdn.com/hotel/icon/jiudianmianban_fuwushangpintu/wupin/keyongpinlei/mianqian.png">https://ailabsaicloudservice.alicdn.com/hotel/icon/jiudianmianban_fuwushangpintu/wupin/keyongpinlei/mianqian.png</a></para>
                /// </summary>
                [NameInMap("Icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// <para>id</para>
                /// 
                /// <b>Example:</b>
                /// <para>10336</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("LimitNumber")]
                [Validation(Required=false)]
                public int? LimitNumber { get; set; }

                [NameInMap("LimitSwitch")]
                [Validation(Required=false)]
                public int? LimitSwitch { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>棉签</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PaymentMethod")]
                [Validation(Required=false)]
                public string PaymentMethod { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>160</para>
                /// </summary>
                [NameInMap("Price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                [NameInMap("RobotName")]
                [Validation(Required=false)]
                public string RobotName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>已添加</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>GOODS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1666163226</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

    }

}
