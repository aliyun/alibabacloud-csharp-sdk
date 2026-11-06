// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class PreviewTaskParametersRequest : TeaModel {
        /// <summary>
        /// <para>The business date. The value is a 13-digit UNIX timestamp in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1792425600000</para>
        /// </summary>
        [NameInMap("Bizdate")]
        [Validation(Required=false)]
        public long? Bizdate { get; set; }

        /// <summary>
        /// <para>The scheduling CRON expression.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00 00 00 * * ?</para>
        /// </summary>
        [NameInMap("Cron")]
        [Validation(Required=false)]
        public string Cron { get; set; }

        /// <summary>
        /// <para>The list of script parameters. The length cannot exceed 65,535 characters. Separate multiple parameters with spaces, such as para1=$bizdate para2=$[hh24]. An empty string is allowed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>para1=$bizdate para2=$[hh24]</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The number of scheduling cycles to preview. Valid values: 1 to 10. Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("PreviewCount")]
        [Validation(Required=false)]
        public int? PreviewCount { get; set; }

        /// <summary>
        /// <para>The project environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Prod: production</description></item>
        /// <item><description>Dev: development
        /// Default value: Prod.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        /// <summary>
        /// <para>The workspace ID. The workspace must belong to the current tenant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The preview start time for the first scheduling day. The format is HH:mm:ss. Default value: 00:00:00. This parameter takes effect only for non-daily schedules and is used to filter out cycles that occur before this time on the first scheduling day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
