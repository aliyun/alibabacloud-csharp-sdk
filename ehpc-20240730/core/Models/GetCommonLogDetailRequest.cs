// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class GetCommonLogDetailRequest : TeaModel {
        /// <summary>
        /// <para>The start time of the time range within which the logs that you want to query were generated. The time is a timestamp. This value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1703821542</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public long? From { get; set; }

        /// <summary>
        /// <para>Specifies whether to hide the process of each step. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: hides the process and returns only the result log of each step.</description></item>
        /// <item><description>false: does not hide the process and displays the start and result logs of each step.</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HiddenProcess")]
        [Validation(Required=false)]
        public bool? HiddenProcess { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE7****</para>
        /// </summary>
        [NameInMap("LogRequestId")]
        [Validation(Required=false)]
        public string LogRequestId { get; set; }

        /// <summary>
        /// <para>The end time of the time range within which the logs that you want to query were generated. The time is a timestamp. This value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1703821666</para>
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public long? To { get; set; }

    }

}
