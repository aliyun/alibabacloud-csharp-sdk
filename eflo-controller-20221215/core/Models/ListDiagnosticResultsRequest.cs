// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListDiagnosticResultsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NetDiag</para>
        /// </summary>
        [NameInMap("DiagType")]
        [Validation(Required=false)]
        public string DiagType { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a3f2224a5ec7224116c4f5246120abe4</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-acfmywpvugkh7kq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
