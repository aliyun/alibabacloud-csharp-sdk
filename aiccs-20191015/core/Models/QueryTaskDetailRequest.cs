// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryTaskDetailRequest : TeaModel {
        [NameInMap("Ani")]
        [Validation(Required=false)]
        public string Ani { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("DepartmentIdList")]
        [Validation(Required=false)]
        public string DepartmentIdList { get; set; }

        [NameInMap("Dnis")]
        [Validation(Required=false)]
        public string Dnis { get; set; }

        [NameInMap("EndReasonList")]
        [Validation(Required=false)]
        public string EndReasonList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OutboundTaskId")]
        [Validation(Required=false)]
        public string OutboundTaskId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PriorityList")]
        [Validation(Required=false)]
        public string PriorityList { get; set; }

        [NameInMap("ServicerId")]
        [Validation(Required=false)]
        public string ServicerId { get; set; }

        [NameInMap("ServicerName")]
        [Validation(Required=false)]
        public string ServicerName { get; set; }

        [NameInMap("Sid")]
        [Validation(Required=false)]
        public string Sid { get; set; }

        [NameInMap("SkillGroup")]
        [Validation(Required=false)]
        public string SkillGroup { get; set; }

        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public string StatusList { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
