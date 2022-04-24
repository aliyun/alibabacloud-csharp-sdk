// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class UploadLabelDataRequest : TeaModel {
        /// <summary>
        /// 单句的唯一ID
        /// </summary>
        [NameInMap("ChatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// 用户输入的query
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// 是否正确，小蜜未定位到时为空
        /// </summary>
        [NameInMap("Correct")]
        [Validation(Required=false)]
        public bool? Correct { get; set; }

        /// <summary>
        /// 正确的场景key，IsCorrect=true时为空，IsCorrect=false时必填，录入场景id必须是双方合作范围内由小蜜定位的场景
        /// </summary>
        [NameInMap("CorrectSceneKey")]
        [Validation(Required=false)]
        public string CorrectSceneKey { get; set; }

        /// <summary>
        /// 机器人code
        /// </summary>
        [NameInMap("RobotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        /// <summary>
        /// 小蜜定位的场景key，小蜜未定位到场景时为空
        /// </summary>
        [NameInMap("SceneKey")]
        [Validation(Required=false)]
        public string SceneKey { get; set; }

        /// <summary>
        /// 卖家ID
        /// </summary>
        [NameInMap("SellerId")]
        [Validation(Required=false)]
        public string SellerId { get; set; }

        /// <summary>
        /// 卖家nick
        /// </summary>
        [NameInMap("SellerNick")]
        [Validation(Required=false)]
        public string SellerNick { get; set; }

        /// <summary>
        /// 消息发送时间戳
        /// </summary>
        [NameInMap("SendTime")]
        [Validation(Required=false)]
        public long? SendTime { get; set; }

        /// <summary>
        /// 买卖家之间的会话ID
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// 卖家小二ID
        /// </summary>
        [NameInMap("StaffId")]
        [Validation(Required=false)]
        public string StaffId { get; set; }

        /// <summary>
        /// 卖家小二nick
        /// </summary>
        [NameInMap("StaffNick")]
        [Validation(Required=false)]
        public string StaffNick { get; set; }

        /// <summary>
        /// 买家ID
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 买家nick
        /// </summary>
        [NameInMap("UserNick")]
        [Validation(Required=false)]
        public string UserNick { get; set; }

    }

}
