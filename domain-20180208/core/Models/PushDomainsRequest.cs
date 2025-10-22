// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class PushDomainsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;example1.cn&quot;, &quot;example2.cn&quot;]</para>
        /// </summary>
        [NameInMap("DomainList")]
        [Validation(Required=false)]
        public List<string> DomainList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NL123456</para>
        /// </summary>
        [NameInMap("OutBizId")]
        [Validation(Required=false)]
        public string OutBizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>外站用户xxx转移</para>
        /// </summary>
        [NameInMap("PublishRemark")]
        [Validation(Required=false)]
        public string PublishRemark { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>破天荒的土豆</para>
        /// </summary>
        [NameInMap("ReceiverAccount")]
        [Validation(Required=false)]
        public string ReceiverAccount { get; set; }

    }

}
