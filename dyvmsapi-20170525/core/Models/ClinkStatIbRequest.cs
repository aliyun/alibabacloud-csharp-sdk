// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkStatIbRequest : TeaModel {
        /// <summary>
        /// <para>同步日期，时间格式(yyyyMMdd)</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20240303</para>
        /// </summary>
        [NameInMap("Date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// <para>同步日期截止，时间格式(yyyyMMdd) ，默认与date相同，查询时间范围最大支持6个月</para>
        /// 
        /// <b>Example:</b>
        /// <para>20240303</para>
        /// </summary>
        [NameInMap("DateEnd")]
        [Validation(Required=false)]
        public string DateEnd { get; set; }

        /// <summary>
        /// <para>查询结束时间 (单位：小时，范围：0-23)，缺省值为23</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("EndHour")]
        [Validation(Required=false)]
        public long? EndHour { get; set; }

        /// <summary>
        /// <para>查询结束分钟 (单位：分，范围：0、15、30、45、59)，缺省值为59 注：由startHour:startMinute和endHour:endMinute组成的开始时间和结束时间，开始时间不得晚于或等于结束时间。 只使用startHour或endHour时，请注意startMinute与endMinute的缺省值。</para>
        /// 
        /// <b>Example:</b>
        /// <para>59</para>
        /// </summary>
        [NameInMap("EndMinute")]
        [Validation(Required=false)]
        public long? EndMinute { get; set; }

        /// <summary>
        /// <para>呼叫中心 id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8004970</para>
        /// </summary>
        [NameInMap("EnterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        /// <summary>
        /// <para>指定需要显示的字段 (默认全部)</para>
        /// 
        /// <b>Example:</b>
        /// <para>ibTotalCount,ibAnsweredCount</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        /// <summary>
        /// <para>热线号码，指定需要查询的热线号码 (默认全部热线号码)</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx,xxxx</para>
        /// </summary>
        [NameInMap("Hotlines")]
        [Validation(Required=false)]
        public string Hotlines { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>查询开始时间 (单位：小时，范围：0-23)，缺省值为0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StartHour")]
        [Validation(Required=false)]
        public long? StartHour { get; set; }

        /// <summary>
        /// <para>查询开始分钟 (单位：分，范围：0、15、30、45)，缺省值为0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StartMinute")]
        [Validation(Required=false)]
        public long? StartMinute { get; set; }

        /// <summary>
        /// <para>统计方式 (默认为2) 取值范围为[2,3]; 2:汇总统计;3:分时统计 注：分时统计下只会返回存在队列工作情况的数据，若队列在该时段没有工作或来电，则不会返回该时段的数据</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StatisticMethod")]
        [Validation(Required=false)]
        public long? StatisticMethod { get; set; }

    }

}
