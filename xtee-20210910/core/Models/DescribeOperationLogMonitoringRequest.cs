// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeOperationLogMonitoringRequest : TeaModel {
        /// <summary>
        /// <para>Language type of the returned message. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>End date (in yyyy-MM-dd format, and the interval from the start date cannot exceed 90 days)</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-07-30</para>
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>Region code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Start date (in yyyy-MM-dd format, and the interval from the current date cannot exceed 90 days)</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-07-19</para>
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>Operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("userNameSearch")]
        [Validation(Required=false)]
        public string UserNameSearch { get; set; }

    }

}
