// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeSdlLastPayloadRequest : TeaModel {
        /// <summary>
        /// <para>The destination IP address. This is an optional parameter used to filter by destination IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.100.102.XXX</para>
        /// </summary>
        [NameInMap("DstIp")]
        [Validation(Required=false)]
        public string DstIp { get; set; }

        /// <summary>
        /// <para>The end time of the query (UNIX timestamp in seconds). This parameter is required. If this parameter is not specified, the API returns an error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1534408267</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The type of sensitive credential. This parameter is required. If this parameter is not specified, the API returns an error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id_card</para>
        /// </summary>
        [NameInMap("SensitiveCategory")]
        [Validation(Required=false)]
        public string SensitiveCategory { get; set; }

        /// <summary>
        /// <para>The source IP address. This is an optional parameter used to filter by source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>121.40.84.XXX</para>
        /// </summary>
        [NameInMap("SrcIp")]
        [Validation(Required=false)]
        public string SrcIp { get; set; }

        /// <summary>
        /// <para>The start time of the query (UNIX timestamp in seconds). This parameter is required. If this parameter is not specified, the API returns an error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656837360</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
