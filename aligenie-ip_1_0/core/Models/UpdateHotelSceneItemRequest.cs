// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class UpdateHotelSceneItemRequest : TeaModel {
        /// <summary>
        /// hotelID
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// updateHotelSceneReq
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UpdateHotelSceneOperateReq")]
        [Validation(Required=false)]
        public UpdateHotelSceneItemRequestUpdateHotelSceneOperateReq UpdateHotelSceneOperateReq { get; set; }
        public class UpdateHotelSceneItemRequestUpdateHotelSceneOperateReq : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("IsUseTemplateAnswer")]
            [Validation(Required=false)]
            public bool? IsUseTemplateAnswer { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("OperateType")]
            [Validation(Required=false)]
            public string OperateType { get; set; }

        }

        /// <summary>
        /// UpdateHotelSceneReq
        /// 
        /// This parameter is required.
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
            /// This parameter is required.
            /// </summary>
            [NameInMap("DialogueList")]
            [Validation(Required=false)]
            public List<UpdateHotelSceneItemRequestUpdateHotelSceneReqDialogueList> DialogueList { get; set; }
            public class UpdateHotelSceneItemRequestUpdateHotelSceneReqDialogueList : TeaModel {
                [NameInMap("DialogueId")]
                [Validation(Required=false)]
                public string DialogueId { get; set; }

                [NameInMap("NoAnswer")]
                [Validation(Required=false)]
                public string NoAnswer { get; set; }

                [NameInMap("NoAnswerTemplate")]
                [Validation(Required=false)]
                public string NoAnswerTemplate { get; set; }

                [NameInMap("Process")]
                [Validation(Required=false)]
                public int? Process { get; set; }

                [NameInMap("Question")]
                [Validation(Required=false)]
                public string Question { get; set; }

                /// <summary>
                /// itemId
                /// </summary>
                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                [NameInMap("YesAnswer")]
                [Validation(Required=false)]
                public string YesAnswer { get; set; }

                [NameInMap("YesAnswerTemplate")]
                [Validation(Required=false)]
                public string YesAnswerTemplate { get; set; }

            }

            /// <summary>
            /// icon
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// itemID
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
            /// This parameter is required.
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

            [NameInMap("RobotName")]
            [Validation(Required=false)]
            public string RobotName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
