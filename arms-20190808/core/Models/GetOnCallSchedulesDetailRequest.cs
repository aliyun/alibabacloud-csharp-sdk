// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetOnCallSchedulesDetailRequest : TeaModel {
        /// <summary>
        /// <para>The date on which the shift ends. Format: <c>yyyy-MM-dd</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-30</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the scheduling policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The date from which the shift starts. Format: <c>yyyy-MM-dd</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-01</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
