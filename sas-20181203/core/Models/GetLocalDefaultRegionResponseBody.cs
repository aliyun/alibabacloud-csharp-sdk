// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetLocalDefaultRegionResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F6D23860-55C2-55AA-B484-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The access type of the multi-cloud site. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The current site is not the default site of the multi-cloud site. You can specify a site as the default site of the multi-cloud site.</description></item>
        /// <item><description><b>1</b>: The current site is the default site of the multi-cloud site.</description></item>
        /// <item><description><b>2</b>: Another site is set as the default site of the multi-cloud site.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
