// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudAgentMonitorStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>说明：根据座席工号查询指定座席的统计项名称支持按照多个座席工号进行查询，多个座席工号之间使用英文逗号&quot;,&quot;分隔，默认查询账户下所有座席的统计信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// </summary>
        [NameInMap("Cnos")]
        [Validation(Required=false)]
        public string Cnos { get; set; }

        /// <summary>
        /// <para>统计时间段；正整数，1～24，最大值是24时</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("EndHour")]
        [Validation(Required=false)]
        public long? EndHour { get; set; }

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
        /// <para>统计项名称；取队列实时统计的统计字段名称，多个队列统计项之间使用英文逗号&quot;,&quot;分隔，默认查询所有统计项</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        /// <summary>
        /// <para>说明：根据外呼组编号查询指定座席的统计项名称支持按照多个外呼组编号进行查询，多个座席工号之间使用英文逗号&quot;,&quot;分隔，默认查询账户下所有座席的统计信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>WH123</para>
        /// </summary>
        [NameInMap("Gno")]
        [Validation(Required=false)]
        public string Gno { get; set; }

        /// <summary>
        /// <para>是否需要返回队列名称；0：不需要（默认） 1：需要</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsNeedQueueName")]
        [Validation(Required=false)]
        public string IsNeedQueueName { get; set; }

        /// <summary>
        /// <para>是否需要外呼组查询；说明：0 关闭外呼组查询，1 开启外呼组查询。默认为关闭状态</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsUseGno")]
        [Validation(Required=false)]
        public long? IsUseGno { get; set; }

        /// <summary>
        /// <para>条数；正整数，默认值是10，最大值是500</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>查询页码数的起始条数；正整数，默认值是0；与limit同步使用，例：offset=50,limit=10,表示查询第6页，每页10条数据，即总记录的第51-60条数据</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        /// <summary>
        /// <para>统计时间段；正整数，0～23，最大值是23时</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StartHour")]
        [Validation(Required=false)]
        public long? StartHour { get; set; }

    }

}
