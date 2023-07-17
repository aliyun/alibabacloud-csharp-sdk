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
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// updateHotelSceneReq
        /// </summary>
        [NameInMap("UpdateHotelSceneOperateReq")]
        [Validation(Required=false)]
        public UpdateHotelSceneItemRequestUpdateHotelSceneOperateReq UpdateHotelSceneOperateReq { get; set; }
        public class UpdateHotelSceneItemRequestUpdateHotelSceneOperateReq : TeaModel {
            [NameInMap("IsUseTemplateAnswer")]
            [Validation(Required=false)]
            public bool? IsUseTemplateAnswer { get; set; }

            [NameInMap("OperateType")]
            [Validation(Required=false)]
            public string OperateType { get; set; }

        }

        /// <summary>
        /// UpdateHotelSceneReq
        /// </summary>
        [NameInMap("UpdateHotelSceneReq")]
        [Validation(Required=false)]
        public UpdateHotelSceneItemRequestUpdateHotelSceneReq UpdateHotelSceneReq { get; set; }
        public class UpdateHotelSceneItemRequestUpdateHotelSceneReq : TeaModel {
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

            [NameInMap("Price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
