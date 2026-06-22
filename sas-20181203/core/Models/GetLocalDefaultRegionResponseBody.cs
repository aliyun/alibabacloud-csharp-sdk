// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetLocalDefaultRegionResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique identifier that Alibaba Cloud generates for the request.</para>
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
        /// <item><description><b>0</b>: No default site exists. You can select one.</description></item>
        /// <item><description><b>1</b>: The current site is already the default site.</description></item>
        /// <item><description><b>2</b>: Another site is already set as the default site.</description></item>
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
