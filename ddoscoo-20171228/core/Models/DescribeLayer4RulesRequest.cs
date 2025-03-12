// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeLayer4RulesRequest : TeaModel {
        /// <summary>
        /// <para>The type of forwarding protocol. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>tcp</b>: Indicates TCP protocol.</description></item>
        /// <item><description><b>udp</b>: Indicates UDP protocol.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("ForwardProtocol")]
        [Validation(Required=false)]
        public string ForwardProtocol { get; set; }

        /// <summary>
        /// <para>The forwarding port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>233</para>
        /// </summary>
        [NameInMap("FrontendPort")]
        [Validation(Required=false)]
        public int? FrontendPort { get; set; }

        /// <summary>
        /// <para>The ID of the DDoS protection instance to be queried.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/91478.html">DescribeInstances</a> to query all DDoS protection instance IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-zvp2ay9b****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>In paginated queries, specifies which page of data to return. The minimum value is <b>1</b>, indicating the first page of data.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// <para>In paginated queries, specifies the number of results per page. The maximum value is <b>50</b>, indicating that each page can contain up to 50 results.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The source IP address of the request. You do not need to fill this in; it is automatically obtained by the system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
