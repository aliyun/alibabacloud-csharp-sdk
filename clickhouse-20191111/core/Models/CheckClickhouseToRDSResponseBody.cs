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
        /// <item><description>This parameter is not returned when <b>Status</b> is <b>true</b>.</description></item>
        /// <item><description>When <b>Status</b> is <b>false</b>, this parameter indicates the cause of the connection failure.</description></item>
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
        /// <para>Indicates whether the connection is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The connection is successful.</description></item>
        /// <item><description><b>false</b>: The connection fails.</description></item>
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
