// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class PublishLiveStagingConfigToProductionRequest : TeaModel {
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

        /// <summary>
        /// <para>The name of the feature. For more information about how to obtain the feature name, see <a href="https://help.aliyun.com/document_detail/297374.html">DescribeLiveDomainStagingConfig</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliauth</para>
        /// </summary>
        [NameInMap("FunctionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
