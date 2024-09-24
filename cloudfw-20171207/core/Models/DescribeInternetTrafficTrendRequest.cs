// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInternetTrafficTrendRequest : TeaModel {
        /// <summary>
        /// <para>The direction of the internet traffic.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>in</b>: inbound traffic</description></item>
        /// <item><description><b>out</b>: outbound traffic</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>in</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1674958929</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The language of the content in the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The source code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yundun</para>
        /// </summary>
        [NameInMap("SourceCode")]
        [Validation(Required=false)]
        public string SourceCode { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101.80.171.196</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The private IP address of the source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.100.134.60</para>
        /// </summary>
        [NameInMap("SrcPrivateIP")]
        [Validation(Required=false)]
        public string SrcPrivateIP { get; set; }

        /// <summary>
        /// <para>The public IP address of the source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.112.210.136</para>
        /// </summary>
        [NameInMap("SrcPublicIP")]
        [Validation(Required=false)]
        public string SrcPublicIP { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1670307484</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The type of the traffic that is captured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>max</b> (default): peak traffic</description></item>
        /// <item><description><b>avg</b>: average traffic</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>max</para>
        /// </summary>
        [NameInMap("TrafficType")]
        [Validation(Required=false)]
        public string TrafficType { get; set; }

    }

}
