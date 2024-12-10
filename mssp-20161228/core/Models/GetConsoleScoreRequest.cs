// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetConsoleScoreRequest : TeaModel {
        /// <summary>
        /// <para>Filter time type, supports filtering by the last 7 days, last 30 days, last half year, or custom. If empty, it represents the last 7 days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>month</para>
        /// </summary>
        [NameInMap("DateType")]
        [Validation(Required=false)]
        public string DateType { get; set; }

        /// <summary>
        /// <para>End date.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1732156885986</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <para>Start date.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1729478485000</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        /// <summary>
        /// <para>Source of alert events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>该字段暂未使用，有问题请联系管理员</para>
        /// </summary>
        [NameInMap("SuspEventSource")]
        [Validation(Required=false)]
        public string SuspEventSource { get; set; }

    }

}
