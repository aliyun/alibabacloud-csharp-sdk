// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateMaterializedViewRecommendRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-8vbwm***</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The description of the recommendation task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task desc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Pattern匹配的最少慢查询个数</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MinRewriteQueryCount")]
        [Validation(Required=false)]
        public int? MinRewriteQueryCount { get; set; }

        /// <summary>
        /// <para>最小可加速的Pattern数量</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MinRewriteQueryPattern")]
        [Validation(Required=false)]
        public int? MinRewriteQueryPattern { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The time range for scanning data. Unit: days. Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ScanQueriesRange")]
        [Validation(Required=false)]
        public int? ScanQueriesRange { get; set; }

        /// <summary>
        /// <para>This parameter is valid only when SchedulingPolicy is set to weekly. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Monday</description></item>
        /// <item><description>Tuesday</description></item>
        /// <item><description>Wednesday</description></item>
        /// <item><description>Thursday</description></item>
        /// <item><description>Friday</description></item>
        /// <item><description>Saturday</description></item>
        /// <item><description>Sunday</description></item>
        /// </list>
        /// <para>Separate multiple days with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Monday;Wednesday</para>
        /// </summary>
        [NameInMap("SchedulingDay")]
        [Validation(Required=false)]
        public string SchedulingDay { get; set; }

        /// <summary>
        /// <para>The scheduling policy of the recommendation task. Valid values:</para>
        /// <para>daily</para>
        /// <para>weekly</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>weekly</para>
        /// </summary>
        [NameInMap("SchedulingPolicy")]
        [Validation(Required=false)]
        public string SchedulingPolicy { get; set; }

        /// <summary>
        /// <para>慢查询阈值</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SlowQueryThreshold")]
        [Validation(Required=false)]
        public int? SlowQueryThreshold { get; set; }

        /// <summary>
        /// <para>The execution time of the recommendation task. Specify the time in the HH:MM:SS format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10:00:00</para>
        /// </summary>
        [NameInMap("SpecifiedTime")]
        [Validation(Required=false)]
        public string SpecifiedTime { get; set; }

        /// <summary>
        /// <para>The name of the recommendation task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task_n1</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
