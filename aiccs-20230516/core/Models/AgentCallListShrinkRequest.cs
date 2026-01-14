// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class AgentCallListShrinkRequest : TeaModel {
        /// <summary>
        /// <para>坐席ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>51</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        /// <summary>
        /// <para>坐席标签</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcd</para>
        /// </summary>
        [NameInMap("AgentTag")]
        [Validation(Required=false)]
        public string AgentTag { get; set; }

        /// <summary>
        /// <para>开始外呼时间</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-03-06 10:10:10</para>
        /// </summary>
        [NameInMap("CallDate")]
        [Validation(Required=false)]
        public string CallDate { get; set; }

        /// <summary>
        /// <para>结束外呼时间</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-03-07 10:10:10</para>
        /// </summary>
        [NameInMap("EndCallDate")]
        [Validation(Required=false)]
        public string EndCallDate { get; set; }

        /// <summary>
        /// <para>号码MD5列表</para>
        /// </summary>
        [NameInMap("NumberMD5s")]
        [Validation(Required=false)]
        public string NumberMD5sShrink { get; set; }

        /// <summary>
        /// <para>号码列表</para>
        /// </summary>
        [NameInMap("Numbers")]
        [Validation(Required=false)]
        public string NumbersShrink { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>页数</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>每页外呼记录数</para>
        /// 
        /// <b>Example:</b>
        /// <para>14</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>用户自定义标签列表</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
