// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudOutboundObClidReportRequest : TeaModel {
        /// <summary>
        /// <para>说明：根据区号查询指定区域的预览外呼被叫号码统计支持按照多个区号进行查询，多个区号之间使用英文逗号&quot;,&quot;分隔，默认查询账户下所有地区的预览外呼被叫号码统计</para>
        /// 
        /// <b>Example:</b>
        /// <para>010</para>
        /// </summary>
        [NameInMap("AreaCodes")]
        [Validation(Required=false)]
        public string AreaCodes { get; set; }

        /// <summary>
        /// <para>统计时段结束时间；取值：0~23,默认值为24时</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("EndHour")]
        [Validation(Required=false)]
        public long? EndHour { get; set; }

        /// <summary>
        /// <para>说明：统计日期的结束时间，格式：yyyy-MM-dd</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-06-13</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>呼叫中心 id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7000002</para>
        /// </summary>
        [NameInMap("EnterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        /// <summary>
        /// <para>查询条数；取值：最大不能超过1000，默认10</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>查询起始位置；取值：大于等于0，默认0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

        /// <summary>
        /// <para>统计时段开始时间；取值：0~23,默认值为0时</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StartHour")]
        [Validation(Required=false)]
        public long? StartHour { get; set; }

        /// <summary>
        /// <para>说明：统计日期的开始时间，格式：yyyy-MM-dd</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-06-13</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>统计方法；说明：0：分时1：分日2：汇总11：中继群组汇总</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StatisticMethod")]
        [Validation(Required=false)]
        public long? StatisticMethod { get; set; }

        /// <summary>
        /// <para>统计类型；说明：统计报表时间类型，1：日报表2：周报表3：月报表4：自定义时间</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TimeRangeType")]
        [Validation(Required=false)]
        public long? TimeRangeType { get; set; }

    }

}
