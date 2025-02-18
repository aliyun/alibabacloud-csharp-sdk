// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class ShopCreateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>12344335</para>
        /// </summary>
        [NameInMap("afterSaleDingTalkId")]
        [Validation(Required=false)]
        public string AfterSaleDingTalkId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>店铺描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12344335</para>
        /// </summary>
        [NameInMap("operatorDingTalkId")]
        [Validation(Required=false)]
        public string OperatorDingTalkId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12344335</para>
        /// </summary>
        [NameInMap("preSaleDingTalkId")]
        [Validation(Required=false)]
        public string PreSaleDingTalkId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>店铺名称</para>
        /// </summary>
        [NameInMap("shopName")]
        [Validation(Required=false)]
        public string ShopName { get; set; }

    }

}
