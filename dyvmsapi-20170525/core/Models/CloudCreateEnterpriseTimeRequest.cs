// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudCreateEnterpriseTimeRequest : TeaModel {
        /// <summary>
        /// <para>当type=1 时必选,周一：2、周二：3、周三：4、周四：5、周五：6、周六：7、周日：1。星期值以,分隔 例如： 2,3,4代表周一周二周三、type=2时为空串</para>
        /// 
        /// <b>Example:</b>
        /// <para>2,3,4</para>
        /// </summary>
        [NameInMap("DayOfWeek")]
        [Validation(Required=false)]
        public string DayOfWeek { get; set; }

        /// <summary>
        /// <para>结束时间；格式为 HH:mm 例如、 19:00 startTime不能大于endTime</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19:00</para>
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
        /// <para>起始日期；当type=2 时必选，格式为：yyyy-MM-dd 、type=1时为空串 fromDay不能大于toDay</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-20</para>
        /// </summary>
        [NameInMap("FromDay")]
        [Validation(Required=false)]
        public string FromDay { get; set; }

        /// <summary>
        /// <para>时间条件名称；同一呼叫中心下不能重复</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo01</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>时间条件优先级；同一呼叫中心下不能重复，值从1开始，值越小优先级越高</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>开始时间；格式为 HH:mm 例如、 06:00 startTime不能大于endTime</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>时间类型 1.连续 2.间隔</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TimeType")]
        [Validation(Required=false)]
        public long? TimeType { get; set; }

        /// <summary>
        /// <para>终止日期；当type=2 时必选，格式为：yyyy-MM-dd 、type=1时为空串 fromDay不能大于toDay</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-25</para>
        /// </summary>
        [NameInMap("ToDay")]
        [Validation(Required=false)]
        public string ToDay { get; set; }

        /// <summary>
        /// <para>条件类型 1:按照星期配置 2:按照固定时间配置</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

    }

}
