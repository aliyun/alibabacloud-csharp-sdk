// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateFirstRankRequest : TeaModel {
        /// <summary>
        /// <para>The request body that contains the parameters of the rough sort expression.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public FirstRank Body { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
