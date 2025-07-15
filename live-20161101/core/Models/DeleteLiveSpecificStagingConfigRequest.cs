// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeleteLiveSpecificStagingConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the configuration that you want to delete. If you want to specify multiple IDs, separate them with commas (,). You can call the <a href="https://help.aliyun.com/document_detail/297374.html">DescribeLiveDomainStagingConfig</a> operation to obtain the configuration ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6295</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>The accelerated domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>developer.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
