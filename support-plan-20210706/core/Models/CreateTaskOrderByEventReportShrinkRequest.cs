// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Support_plan20210706.Models
{
    public class CreateTaskOrderByEventReportShrinkRequest : TeaModel {
        /// <summary>
        /// 告警所属业务
        /// </summary>
        [NameInMap("Business")]
        [Validation(Required=false)]
        public string Business { get; set; }

        /// <summary>
        /// 提交人姓名
        /// </summary>
        [NameInMap("CreateRealName")]
        [Validation(Required=false)]
        public string CreateRealName { get; set; }

        /// <summary>
        /// 提交人userId
        /// </summary>
        [NameInMap("CreateUserId")]
        [Validation(Required=false)]
        public string CreateUserId { get; set; }

        /// <summary>
        /// 告警描述
        /// </summary>
        [NameInMap("EventBody")]
        [Validation(Required=false)]
        public string EventBodyShrink { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [NameInMap("Extinfo")]
        [Validation(Required=false)]
        public string ExtinfoShrink { get; set; }

        /// <summary>
        /// 当eventLevel为warn时，必传
        /// </summary>
        [NameInMap("ImportantDesc")]
        [Validation(Required=false)]
        public string ImportantDesc { get; set; }

        /// <summary>
        /// 建单入群人员
        /// </summary>
        [NameInMap("JoinChildGroupUserIds")]
        [Validation(Required=false)]
        public string JoinChildGroupUserIds { get; set; }

        /// <summary>
        /// 监控集如：视频业务的质量监控
        /// </summary>
        [NameInMap("MonitorCongregation")]
        [Validation(Required=false)]
        public string MonitorCongregation { get; set; }

        /// <summary>
        /// 告警关联主群id
        /// </summary>
        [NameInMap("OpenGroupId")]
        [Validation(Required=false)]
        public string OpenGroupId { get; set; }

        /// <summary>
        /// 问题分类
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
