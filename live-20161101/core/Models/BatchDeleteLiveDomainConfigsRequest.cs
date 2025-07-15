// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class BatchDeleteLiveDomainConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The ingest domain or streaming domain. Separate multiple domain names with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo.aliyundoc.com,example.aliyundoc.com,example.com</para>
        /// </summary>
        [NameInMap("DomainNames")]
        [Validation(Required=false)]
        public string DomainNames { get; set; }

        /// <summary>
        /// <para>The names of the features. Separate multiple features with commas (,). For more information, see <b>Features specified by the Functions parameter</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>referer_white_list_set,ip_black_list_set</para>
        /// </summary>
        [NameInMap("FunctionNames")]
        [Validation(Required=false)]
        public string FunctionNames { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
