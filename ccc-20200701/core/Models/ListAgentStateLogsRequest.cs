// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListAgentStateLogsRequest : TeaModel {
        /// <summary>
        /// <para>Agent ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent@ccc-test</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>End UNIX timestamp. The default value is the current time. The time difference between EndTime and StartTime must not exceed 7 days. The format is a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1620273600000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Start UNIX timestamp. The default value is the start time of the current day. The earliest allowed value is 180 days before the current date. The format is a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1620230400000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
