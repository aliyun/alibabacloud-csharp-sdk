// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateEnsServiceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource that you want to obtain. You can specify only one ID in a request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ens-20190806****</para>
        /// </summary>
        [NameInMap("EnsServiceId")]
        [Validation(Required=false)]
        public string EnsServiceId { get; set; }

        /// <summary>
        /// <para>The operation to perform after you preview the created edge service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Buy</b>: create</description></item>
        /// <item><description><b>Upgrade</b>: change</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Buy</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

    }

}
