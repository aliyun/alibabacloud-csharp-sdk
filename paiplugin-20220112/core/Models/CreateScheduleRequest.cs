// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class CreateScheduleRequest : TeaModel {
        [NameInMap("AISendEndDate")]
        [Validation(Required=false)]
        public string AISendEndDate { get; set; }

        [NameInMap("AISendStartDate")]
        [Validation(Required=false)]
        public string AISendStartDate { get; set; }

        /// <summary>
        /// 终止时间（UTC+8）。
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// 执行时间 (UTC+8)，为空立即执行。
        /// </summary>
        [NameInMap("ExecuteTime")]
        [Validation(Required=false)]
        public string ExecuteTime { get; set; }

        /// <summary>
        /// 人群ID。
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// 触达计划名称。
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// 重复周期，按重复周期与重复周期单位执行。
        /// </summary>
        [NameInMap("RepeatCycle")]
        [Validation(Required=false)]
        public int? RepeatCycle { get; set; }

        /// <summary>
        /// 重复周期单位，若指定执行时间，则重复周期生效。
        /// - 0: 从不（默认）。
        /// - 1: 小时。
        /// - 2: 天。
        /// - 3: 周。
        /// - 4: 月。
        /// </summary>
        [NameInMap("RepeatCycleUnit")]
        [Validation(Required=false)]
        public int? RepeatCycleUnit { get; set; }

        /// <summary>
        /// 重复次数。
        /// - 0: 不设终止时间（默认）。
        /// - N: 重复N次后终止。
        /// </summary>
        [NameInMap("RepeatTimes")]
        [Validation(Required=false)]
        public int? RepeatTimes { get; set; }

        /// <summary>
        /// 签名。
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// 签名ID，或指定签名。
        /// </summary>
        [NameInMap("SignatureId")]
        [Validation(Required=false)]
        public string SignatureId { get; set; }

        /// <summary>
        /// 模板Code。
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 模板ID，或指定模板Code。
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
