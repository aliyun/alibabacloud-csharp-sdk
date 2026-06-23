// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CheckClickhouseToRDSResponseBody : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>This parameter is returned only if the connection fails (<b>Status</b> is <b>false</b>).</para>
        /// </description></item>
        /// <item><description><para>It indicates the reason for the connection failure.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NotSameVpc</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A82758F8-E793-5610-BE11-0E46664305C2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether a connection can be established. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: A connection can be established.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: A connection cannot be established.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public bool? Status { get; set; }

    }

}
