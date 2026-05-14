// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkListClientsRequest : TeaModel {
        /// <summary>
        /// <para>是否激活，1: 激活；0: 未激活</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Active")]
        [Validation(Required=false)]
        public long? Active { get; set; }

        /// <summary>
        /// <para>绑定电话</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("BindTel")]
        [Validation(Required=false)]
        public string BindTel { get; set; }

        /// <summary>
        /// <para>外显号码</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Clid")]
        [Validation(Required=false)]
        public string Clid { get; set; }

        /// <summary>
        /// <para>创建时间查询范围-结束时间,秒级时间戳</para>
        /// 
        /// <b>Example:</b>
        /// <para>1775024775</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

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
        /// <para>查询记录条数，默认值为 10，最大范围 100</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>偏移量，默认值为 0，最大范围 10000</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>队列号</para>
        /// 
        /// <b>Example:</b>
        /// <para>12112</para>
        /// </summary>
        [NameInMap("Qno")]
        [Validation(Required=false)]
        public string Qno { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>创建时间查询范围-开始时间,秒级时间戳</para>
        /// 
        /// <b>Example:</b>
        /// <para>1775024775</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>修改时间查询范围-结束时间,秒级时间戳</para>
        /// 
        /// <b>Example:</b>
        /// <para>1775024775</para>
        /// </summary>
        [NameInMap("UpdateEndTime")]
        [Validation(Required=false)]
        public long? UpdateEndTime { get; set; }

        /// <summary>
        /// <para>修改时间查询范围-开始时间,秒级时间戳</para>
        /// 
        /// <b>Example:</b>
        /// <para>1775024775</para>
        /// </summary>
        [NameInMap("UpdateStartTime")]
        [Validation(Required=false)]
        public long? UpdateStartTime { get; set; }

    }

}
