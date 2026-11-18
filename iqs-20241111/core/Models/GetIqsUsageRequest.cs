// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class GetIqsUsageRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud RAM user or the API key caller identifier to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>138608930460****</para>
        /// </summary>
        [NameInMap("callerId")]
        [Validation(Required=false)]
        public string CallerId { get; set; }

        /// <summary>
        /// <para>The end date for the usage query, inclusive. The format is YYYYMMDD. The date must be within the last 60 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20241017</para>
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The start date for the usage query, inclusive. The format is YYYYMMDD. The date must be within the last 60 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20241011</para>
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
