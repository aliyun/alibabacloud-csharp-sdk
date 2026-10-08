// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class CheckDomainSunriseClaimResponseBody : TeaModel {
        /// <summary>
        /// <para>The trademark keyword key provided by the TMDB database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017092100/8/2/1/kDfu9htHGEx_y-LJ3XSlKMZ70000020001</para>
        /// </summary>
        [NameInMap("ClaimKey")]
        [Validation(Required=false)]
        public string ClaimKey { get; set; }

        /// <summary>
        /// <para>Unique request access token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BA7A4FD4-EB9A-4A20-BB0C-9AEB15634DC1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not a trademark keyword or not in the claim domain lifecycle.</description></item>
        /// <item><description><b>1</b>: In the sunrise domain lifecycle.</description></item>
        /// <item><description><b>2</b>: In the claim domain lifecycle.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public int? Result { get; set; }

    }

}
