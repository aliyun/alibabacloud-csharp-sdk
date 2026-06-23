// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyRouterInterfaceSpecResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EC47282-1B74-4534-BD0E-403F3EE64CAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The specification of the router interface. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Mini.2</b>: 2 Mbps</para>
        /// </description></item>
        /// <item><description><para><b>Mini.5</b>: 5 Mbps</para>
        /// </description></item>
        /// <item><description><para><b>Small.1</b>: 10 Mbps</para>
        /// </description></item>
        /// <item><description><para><b>Small.2</b>: 20 Mbps</para>
        /// </description></item>
        /// <item><description><para><b>Small.5</b>: 50 Mbps</para>
        /// </description></item>
        /// <item><description><para><b>Middle.1</b>: 100 Mbps</para>
        /// </description></item>
        /// <item><description><para><b>Middle.2</b>: 200 Mbps</para>
        /// </description></item>
        /// <item><description><para><b>Middle.5</b>: 500 Mbps</para>
        /// </description></item>
        /// <item><description><para><b>Large.1</b>: 1000 Mbps</para>
        /// </description></item>
        /// <item><description><para><b>Large.2</b>: 2000 Mbps</para>
        /// </description></item>
        /// <item><description><para><b>Large.5</b>: 5000 Mbps</para>
        /// </description></item>
        /// <item><description><para><b>Xlarge.1</b>: 10000 Mbps.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Small.1</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
