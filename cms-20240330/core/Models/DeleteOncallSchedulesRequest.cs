// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DeleteOncallSchedulesRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the on-call schedules.</para>
        /// </summary>
        [NameInMap("oncallScheduleIds")]
        [Validation(Required=false)]
        public List<string> OncallScheduleIds { get; set; }

    }

}
