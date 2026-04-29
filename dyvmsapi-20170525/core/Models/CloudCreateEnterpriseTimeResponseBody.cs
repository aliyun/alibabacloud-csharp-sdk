// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudCreateEnterpriseTimeResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CloudCreateEnterpriseTimeResponseBodyData Data { get; set; }
        public class CloudCreateEnterpriseTimeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>创建时间，格式为： yyyy-MM-dd HH:mm:ss</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-20 10:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>星期 周一：2、周二：3、周三：4、周四：5、周五：6、周六：7、周日：1、使用&quot;,&quot;进行分割、type=2时为空串</para>
            /// 
            /// <b>Example:</b>
            /// <para>2,3,4</para>
            /// </summary>
            [NameInMap("DayOfWeek")]
            [Validation(Required=false)]
            public string DayOfWeek { get; set; }

            /// <summary>
            /// <para>结束时间 格式为 HH:mm startTime不能大于endTime</para>
            /// 
            /// <b>Example:</b>
            /// <para>19:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>呼叫中心编号</para>
            /// 
            /// <b>Example:</b>
            /// <para>7000002</para>
            /// </summary>
            [NameInMap("EnterpriseId")]
            [Validation(Required=false)]
            public string EnterpriseId { get; set; }

            /// <summary>
            /// <para>起始日期 格式为：yyyy-MM-dd、type=1时为空串 fromDay不能大于toDay</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-20</para>
            /// </summary>
            [NameInMap("FromDay")]
            [Validation(Required=false)]
            public string FromDay { get; set; }

            /// <summary>
            /// <para>时间条件id</para>
            /// 
            /// <b>Example:</b>
            /// <para>236</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>时间条件名称 、同一呼叫中心下不能重复</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo01</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>优先级、同一呼叫中心下不能重复，值从1开始，值越小优先级越高</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>开始时间 格式为 HH:mm startTime不能大于endTime</para>
            /// 
            /// <b>Example:</b>
            /// <para>06:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>时间类型 1.连续 2.间隔</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TimeType")]
            [Validation(Required=false)]
            public string TimeType { get; set; }

            /// <summary>
            /// <para>终止日期 格式为：yyyy-MM-dd、type=1时为空串 fromDay不能大于toDay</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-25</para>
            /// </summary>
            [NameInMap("ToDay")]
            [Validation(Required=false)]
            public string ToDay { get; set; }

            /// <summary>
            /// <para>时间条件类型 1:按照星期配置 2:按照固定时间配置</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ED18A5AE-9BBC-5851-1111-8E5B8C23CEDE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
