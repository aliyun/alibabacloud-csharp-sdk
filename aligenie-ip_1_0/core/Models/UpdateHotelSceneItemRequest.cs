// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class UpdateHotelSceneItemRequest : TeaModel {
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
        /// <para>updateHotelSceneReq</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateHotelSceneOperateReq")]
        [Validation(Required=false)]
        public UpdateHotelSceneItemRequestUpdateHotelSceneOperateReq UpdateHotelSceneOperateReq { get; set; }
        public class UpdateHotelSceneItemRequestUpdateHotelSceneOperateReq : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsUseTemplateAnswer")]
            [Validation(Required=false)]
            public bool? IsUseTemplateAnswer { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OPEN</para>
            /// </summary>
            [NameInMap("OperateType")]
            [Validation(Required=false)]
            public string OperateType { get; set; }

        }

        /// <summary>
        /// <para>UpdateHotelSceneReq</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateHotelSceneReq")]
        [Validation(Required=false)]
        public UpdateHotelSceneItemRequestUpdateHotelSceneReq UpdateHotelSceneReq { get; set; }
        public class UpdateHotelSceneItemRequestUpdateHotelSceneReq : TeaModel {
            [NameInMap("BeyondLimitReply")]
            [Validation(Required=false)]
            public string BeyondLimitReply { get; set; }

            [NameInMap("DeliveryMethod")]
            [Validation(Required=false)]
            public string DeliveryMethod { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DialogueList")]
            [Validation(Required=false)]
            public List<UpdateHotelSceneItemRequestUpdateHotelSceneReqDialogueList> DialogueList { get; set; }
            public class UpdateHotelSceneItemRequestUpdateHotelSceneReqDialogueList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>335</para>
                /// </summary>
                [NameInMap("DialogueId")]
                [Validation(Required=false)]
                public string DialogueId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>对不起，暂时不提供此物品</para>
                /// </summary>
                [NameInMap("NoAnswer")]
                [Validation(Required=false)]
                public string NoAnswer { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("NoAnswerTemplate")]
                [Validation(Required=false)]
                public string NoAnswerTemplate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Process")]
                [Validation(Required=false)]
                public int? Process { get; set; }

                [NameInMap("Question")]
                [Validation(Required=false)]
                public string Question { get; set; }

                /// <summary>
                /// <para>itemId</para>
                /// 
                /// <b>Example:</b>
                /// <para>10337</para>
                /// </summary>
                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>纸巾1.5元，请问需要么？</para>
                /// </summary>
                [NameInMap("YesAnswer")]
                [Validation(Required=false)]
                public string YesAnswer { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("YesAnswerTemplate")]
                [Validation(Required=false)]
                public string YesAnswerTemplate { get; set; }

            }

            /// <summary>
            /// <para>icon</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://ailabsaicloudservice.alicdn.com/hotel/icon/jiudianmianban_fuwushangpintu/wupin/keyongpinlei/mianqian.png">https://ailabsaicloudservice.alicdn.com/hotel/icon/jiudianmianban_fuwushangpintu/wupin/keyongpinlei/mianqian.png</a></para>
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <para>itemID</para>
            /// 
            /// <b>Example:</b>
            /// <para>10337</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("LimitNumber")]
            [Validation(Required=false)]
            public long? LimitNumber { get; set; }

            [NameInMap("LimitSwitch")]
            [Validation(Required=false)]
            public int? LimitSwitch { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PaymentMethod")]
            [Validation(Required=false)]
            public string PaymentMethod { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>165</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

            [NameInMap("RobotName")]
            [Validation(Required=false)]
            public string RobotName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>已添加</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
