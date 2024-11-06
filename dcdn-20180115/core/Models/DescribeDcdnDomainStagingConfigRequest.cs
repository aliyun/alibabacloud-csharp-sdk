// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainStagingConfigRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The names of the features to query. You can separate multiple features with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliauth</para>
        /// </summary>
        [NameInMap("FunctionNames")]
        [Validation(Required=false)]
        public string FunctionNames { get; set; }

    }

}
