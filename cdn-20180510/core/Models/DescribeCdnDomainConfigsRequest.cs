// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnDomainConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the configuration. For more information about ConfigId, see <a href="https://help.aliyun.com/document_detail/388994.html">Usage notes on ConfigId</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6295</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>The accelerated domain name. You can specify only one domain name in each request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The names of the features. Separate multiple feature names with commas (,). For more information, see <a href="https://help.aliyun.com/document_detail/388460.html">Parameters for configuring features for domain names</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliauth</para>
        /// </summary>
        [NameInMap("FunctionNames")]
        [Validation(Required=false)]
        public string FunctionNames { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
