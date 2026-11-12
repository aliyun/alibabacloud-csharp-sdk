// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateEnsServiceRequest : TeaModel {
        /// <summary>
        /// <para>The required resource ID. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ens-20190806****</para>
        /// </summary>
        [NameInMap("EnsServiceId")]
        [Validation(Required=false)]
        public string EnsServiceId { get; set; }

        /// <summary>
        /// <para>The operation to perform after previewing the creation of the edge service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Buy</b>: Create.</para>
        /// </description></item>
        /// <item><description><para><b>Upgrade</b>: Update.</para>
        /// </description></item>
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
