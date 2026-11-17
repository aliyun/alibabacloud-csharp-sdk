// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class ShopCreateRequest : TeaModel {
        /// <summary>
        /// <para>The after-sales DingTalk ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12344335</para>
        /// </summary>
        [NameInMap("afterSaleDingTalkId")]
        [Validation(Required=false)]
        public string AfterSaleDingTalkId { get; set; }

        /// <summary>
        /// <para>The shop description.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Shop description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The operations DingTalk ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12344335</para>
        /// </summary>
        [NameInMap("operatorDingTalkId")]
        [Validation(Required=false)]
        public string OperatorDingTalkId { get; set; }

        /// <summary>
        /// <para>The pre-sales DingTalk ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12344335</para>
        /// </summary>
        [NameInMap("preSaleDingTalkId")]
        [Validation(Required=false)]
        public string PreSaleDingTalkId { get; set; }

        /// <summary>
        /// <para>The shop name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Shop name</para>
        /// </summary>
        [NameInMap("shopName")]
        [Validation(Required=false)]
        public string ShopName { get; set; }

    }

}
