// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class ReposForkCreateCmd : TeaModel {
        [NameInMap("companyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>global-mall</para>
        /// </summary>
        [NameInMap("gitGroup")]
        [Validation(Required=false)]
        public string GitGroup { get; set; }

        [NameInMap("marketId")]
        [Validation(Required=false)]
        public long? MarketId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pbcId")]
        [Validation(Required=false)]
        public long? PbcId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>商城国际化版本</para>
        /// </summary>
        [NameInMap("usage")]
        [Validation(Required=false)]
        public string Usage { get; set; }

        [NameInMap("visible")]
        [Validation(Required=false)]
        public bool? Visible { get; set; }

    }

}
