// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SetDesktopGroupTimerRequest : TeaModel {
        /// <summary>
        /// <para>The cron expression for the scheduled task. This parameter is required when <c>TimerType</c> is set to 2, 3, or 4.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 0 2 ? * 1-7</para>
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <para>The ID of the cloud computer share.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-dbdkfmh883****</para>
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully execute the scheduled task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The type of the disk that you want to reset.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>does not reset disks.</description></item>
        /// <item><description>resets only the system disk.</description></item>
        /// <item><description>resets only the user disk.</description></item>
        /// <item><description>resets the system disk and the user disk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ResetType")]
        [Validation(Required=false)]
        public int? ResetType { get; set; }

        /// <summary>
        /// <para>The type of the scheduled task.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: scheduled reset</description></item>
        /// <item><description>2: scheduled startup</description></item>
        /// <item><description>3: scheduled stop</description></item>
        /// <item><description>4: scheduled restart</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TimerType")]
        [Validation(Required=false)]
        public int? TimerType { get; set; }

    }

}
