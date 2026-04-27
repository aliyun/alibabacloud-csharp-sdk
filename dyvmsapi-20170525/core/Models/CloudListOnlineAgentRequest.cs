// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudListOnlineAgentRequest : TeaModel {
        /// <summary>
        /// <para>坐席工号，指定座席工号则查询该工号座席的监控信息，可指定多个座席工号，指定多个座席工号使用英文逗号&quot;,&quot;分隔，不指定则查询所有队列监控信息，不指定则查询该账户下所有座席的监控信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111,1112</para>
        /// </summary>
        [NameInMap("Cnos")]
        [Validation(Required=false)]
        public string Cnos { get; set; }

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

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>置忙原因，根据座席置忙原因过滤监控数据，可指定多个置忙原因，指定多个置忙原因使用英文逗号&quot;,&quot;分隔，不指定则默认查询所有设置状态的座席</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("PauseDescription")]
        [Validation(Required=false)]
        public string PauseDescription { get; set; }

        /// <summary>
        /// <para>置忙类型，根据座席置忙类型过滤监控数据，可指定多个置忙类型，指定多个置忙类型使用英文逗号&quot;,&quot;分隔，不指定则默认查询所有设置状态的座席。<br>取值说明1普通，2休息，3 IM，4 强制</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PauseType")]
        [Validation(Required=false)]
        public string PauseType { get; set; }

        /// <summary>
        /// <para>队列号，指定队列号则查询该队列号所对应队列的监控信息，支持同时查询多个队列号对应队列的监控信息，多个队列号使用英文逗号&quot;,&quot;分隔，不指定则查询所有队列监控信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>123,124</para>
        /// </summary>
        [NameInMap("Qnos")]
        [Validation(Required=false)]
        public string Qnos { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>坐席状态，s1:空闲，s2:置忙，s3:整理，s4:呼叫中，s5:响铃，s6通话   可传多个状态码，多个值之间以&quot;,&quot;分隔</para>
        /// 
        /// <b>Example:</b>
        /// <para>s1</para>
        /// </summary>
        [NameInMap("StateCode")]
        [Validation(Required=false)]
        public string StateCode { get; set; }

    }

}
