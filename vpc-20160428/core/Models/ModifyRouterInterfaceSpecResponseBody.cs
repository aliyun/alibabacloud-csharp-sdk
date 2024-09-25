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
        /// <item><description><b>Mini.2</b>: 2 Mbit/s</description></item>
        /// <item><description><b>Mini.5</b>: 5 Mbit/s</description></item>
        /// <item><description><b>Small.1</b>: 10 Mbit/s</description></item>
        /// <item><description><b>Small.2</b>: 20 Mbit/s</description></item>
        /// <item><description><b>Small.5</b>: 50 Mbit/s</description></item>
        /// <item><description><b>Middle.1</b>: 100 Mbit/s</description></item>
        /// <item><description><b>Middle.2</b>: 200 Mbit/s</description></item>
        /// <item><description><b>Middle.5</b>: 500 Mbit/s</description></item>
        /// <item><description><b>Large.1</b>: 1,000 Mbit/s</description></item>
        /// <item><description><b>Large.2</b>: 2,000 Mbit/s</description></item>
        /// <item><description><b>Large.5</b>: 5,000 Mbit/s</description></item>
        /// <item><description><b>Xlarge.1</b>: 10,000 Mbit/s</description></item>
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
