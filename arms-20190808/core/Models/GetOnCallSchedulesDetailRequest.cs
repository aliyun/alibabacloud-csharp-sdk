// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetOnCallSchedulesDetailRequest : TeaModel {
        /// <summary>
        /// <para>The end date of the query range in <c>yyyy-MM-dd</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-30</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the on-call schedule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The start date of the query range in <c>yyyy-MM-dd</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-01</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
