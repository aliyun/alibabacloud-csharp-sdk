// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudAgentWorkloadReportRequest : TeaModel {
        /// <summary>
        /// <para>座席号；说明：根据座席工号查询指定座席的工作量统计支持按照多个座席工号进行查询，多个座席工号之间使用英文逗号&quot;,&quot;分隔，默认查询账户下所有座席的工作量统计</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111,2222</para>
        /// </summary>
        [NameInMap("Cnos")]
        [Validation(Required=false)]
        public string Cnos { get; set; }

        /// <summary>
        /// <para>说明：统计日期的结束时间，格式：yyyy-MM-dd</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-15</para>
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
        /// <para>说明：根据外呼编号查询指定座席的工作量统计,默认查询账户下所有座席的工作量统计</para>
        /// 
        /// <b>Example:</b>
        /// <para>WH12</para>
        /// </summary>
        [NameInMap("Gnos")]
        [Validation(Required=false)]
        public string Gnos { get; set; }

        /// <summary>
        /// <para>查询条数；取值：最大不能超过1000，默认10</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

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
        /// <para>查询起始位置；取值：大于等于0，默认0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

        /// <summary>
        /// <para>说明：统计日期的开始时间，格式：yyyy-MM-dd</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-13</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>统计方法；说明：0：分时1：分日2：汇总 10：队列汇总</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StatisticMethod")]
        [Validation(Required=false)]
        public long? StatisticMethod { get; set; }

        /// <summary>
        /// <para>说明：统计报表类型，1：日报表2：周报表3：月报表4：自定义时间</para>
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
