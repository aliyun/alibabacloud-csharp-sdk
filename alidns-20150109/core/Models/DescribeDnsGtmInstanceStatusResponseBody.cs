// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstanceStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of healthy addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AddrAvailableNum")]
        [Validation(Required=false)]
        public int? AddrAvailableNum { get; set; }

        /// <summary>
        /// <para>The number of unhealthy addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AddrNotAvailableNum")]
        [Validation(Required=false)]
        public int? AddrNotAvailableNum { get; set; }

        /// <summary>
        /// <para>The number of unavailable address pool groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AddrPoolGroupNotAvailableNum")]
        [Validation(Required=false)]
        public int? AddrPoolGroupNotAvailableNum { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>389DFFA3-77A5-4A9E-BF3D-147C6F98A5BA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of unavailable access policies for the active address pool group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("StrategyNotAvailableNum")]
        [Validation(Required=false)]
        public int? StrategyNotAvailableNum { get; set; }

        /// <summary>
        /// <para>The number of access policies that are switched to the failover address pool group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SwitchToFailoverStrategyNum")]
        [Validation(Required=false)]
        public int? SwitchToFailoverStrategyNum { get; set; }

    }

}
