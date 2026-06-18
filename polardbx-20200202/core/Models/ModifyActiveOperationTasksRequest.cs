// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class ModifyActiveOperationTasksRequest : TeaModel {
        /// <summary>
        /// <para>The O&amp;M event ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately execute the event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: immediately execute</description></item>
        /// <item><description>0: execute at the specified time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ImmediateStart")]
        [Validation(Required=false)]
        public long? ImmediateStart { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The switchover start time in the YYYY-MM-DDThh:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-08-15T12:00:00Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

    }

}
