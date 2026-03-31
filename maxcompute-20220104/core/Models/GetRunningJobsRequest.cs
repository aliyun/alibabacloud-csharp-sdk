// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetRunningJobsRequest : TeaModel {
        /// <summary>
        /// <para>The time when the query starts. This parameter specifies the time when a job is submitted.</para>
        /// <list type="bullet">
        /// <item><description>The time range that is specified by the <b>from</b> and <b>to</b> request parameters is a closed interval. The start time and end time are included in the range. If the value of <b>from</b> is the same as the value of <b>to</b>, the time range is invalid, and a null value is returned.</description></item>
        /// <item><description>The value is a UNIX timestamp that represents the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683785928</para>
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public long? From { get; set; }

        /// <summary>
        /// <para>The list of job executors.</para>
        /// </summary>
        [NameInMap("jobOwnerList")]
        [Validation(Required=false)]
        public List<string> JobOwnerList { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The list of nicknames of quotas that are used by jobs.</para>
        /// </summary>
        [NameInMap("quotaNicknameList")]
        [Validation(Required=false)]
        public List<string> QuotaNicknameList { get; set; }

        /// <summary>
        /// <para>The time when the query ends. This parameter specifies the time when a job is submitted.</para>
        /// <list type="bullet">
        /// <item><description>The time interval that is specified by the <b>from</b> and <b>to</b> request parameters is a closed interval. The start time and end time are included in the interval. If the value of <b>from</b> is the same as the value of <b>to</b>, the interval is invalid, and a null value is returned.</description></item>
        /// <item><description>The value is a UNIX timestamp that represents the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683612946</para>
        /// </summary>
        [NameInMap("to")]
        [Validation(Required=false)]
        public long? To { get; set; }

    }

}
