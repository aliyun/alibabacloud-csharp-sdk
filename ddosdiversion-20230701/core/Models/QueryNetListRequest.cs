// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DdosDiversion20230701.Models
{
    public class QueryNetListRequest : TeaModel {
        /// <summary>
        /// <para>The primary CIDR block of the anti-DDoS diversion instance for which an extended CIDR block is configured. If no extended CIDR blocks are configured for the anti-DDoS diversion instance, leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX/22</para>
        /// </summary>
        [NameInMap("MainNet")]
        [Validation(Required=false)]
        public string MainNet { get; set; }

        /// <summary>
        /// <para>The scheduling mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>manual: manual scheduling.</para>
        /// </description></item>
        /// <item><description><para>netflow-auto: automatic scheduling.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>netflow-auto</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The CIDR block of the anti-DDoS diversion instance.</para>
        /// <remarks>
        /// <para>If no extended CIDR blocks are configured for the anti-DDoS diversion instance, this parameter specifies the CIDR block of the instance. If an extended CIDR block is configured for the anti-DDoS diversion instance, this parameter specifies the extended CIDR block that is configured for the instance. If this parameter is specified, the MainNet parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX/24</para>
        /// </summary>
        [NameInMap("Net")]
        [Validation(Required=false)]
        public string Net { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Num")]
        [Validation(Required=false)]
        public long? Num { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>The ID of the anti-DDoS diversion instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddos_diversion_public_cn-xxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("SaleId")]
        [Validation(Required=false)]
        public string SaleId { get; set; }

    }

}
