// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateIncidentRequest : TeaModel {
        /// <summary>
        /// P1	事件级别 P1 P2 P3 P4
        /// </summary>
        [NameInMap("incidentLevel")]
        [Validation(Required=false)]
        public string IncidentLevel { get; set; }

        /// <summary>
        /// 幂等UUID
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 关联服务ID
        /// </summary>
        [NameInMap("relatedServiceId")]
        [Validation(Required=false)]
        public long? RelatedServiceId { get; set; }

        /// <summary>
        /// 影响等级 高：HIGH 低 LOW
        /// </summary>
        [NameInMap("effect")]
        [Validation(Required=false)]
        public string Effect { get; set; }

        /// <summary>
        /// 事件标题
        /// </summary>
        [NameInMap("incidentTitle")]
        [Validation(Required=false)]
        public string IncidentTitle { get; set; }

        /// <summary>
        /// 分派的用户ID
        /// </summary>
        [NameInMap("assignUserId")]
        [Validation(Required=false)]
        public long? AssignUserId { get; set; }

        /// <summary>
        /// 事件描述
        /// </summary>
        [NameInMap("incidentDescription")]
        [Validation(Required=false)]
        public string IncidentDescription { get; set; }

        /// <summary>
        /// 通知渠道     SMS 短信   EMAIL 邮件   PHONE  电话  WEIXIN_GROUP企微群 DING_GROUP 钉钉群
        /// </summary>
        [NameInMap("channels")]
        [Validation(Required=false)]
        public List<string> Channels { get; set; }

    }

}
