// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetLiveEdgeTransferRequest : TeaModel {
        /// <summary>
        /// <para>The application name to which the live stream belongs. Regular expressions are supported for configuration with exceptions. For more information, see <b>AppName and StreamName Parameter Configuration Instructions</b> below. For example: liveApp****[1,2,3] indicates that the three apps liveApp<b><b>1, liveApp</b></b>2, and liveApp****3 are allowed for stream relay.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter only takes effect for the TargetDomainList in the request parameters.</description></item>
        /// <item><description>When configuring the <c>AppName</c> parameter value using regular expressions, the ^ or $ characters cannot be used, otherwise stream relay will fail.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The ingest domain name. Live stream relay is configured at the granularity of the ingest DomainName. Each domain can have only one live stream relay configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The HTTPDNS interface for obtaining the stream relay target address. The request must contain one of the <c>TargetDomainList</c> and <c>HttpDns</c> parameters, and the two are mutually exclusive.</para>
        /// <remarks>
        /// <para>If <c>HttpDns</c> is set in the request parameters, the <c>TargetDomainList</c> parameter cannot be set, and the <c>AppName</c> and <c>StreamName</c> restrictions do not take effect.</para>
        /// </remarks>
        /// <para>Live stream relay has requirements for the message structure returned by the HTTPDNS interface. For more information, see <b>HTTPDNS Instructions</b> below.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://developer.aliyundoc.com">http://developer.aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("HttpDns")]
        [Validation(Required=false)]
        public string HttpDns { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The stream name. Regular expressions are supported for configuration with exceptions. For more information, see <b>AppName and StreamName Parameter Configuration Instructions</b> below. For example: liveStream****[1,2,3] indicates that the three streams liveStream<b><b>1, liveStream</b></b>2, and liveStream****3 are allowed for stream relay.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter only takes effect for the TargetDomainList in the request parameters.</description></item>
        /// <item><description>When configuring the <c>StreamName</c> parameter value using regular expressions, the ^ or $ characters cannot be used, otherwise stream relay will fail.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>liveStream****</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        /// <summary>
        /// <para>The list of target domains specified by the user for stream relay. Multiple domains are separated by commas (,). The request must contain one of the <c>TargetDomainList</c> and <c>HttpDns</c> parameters, and the two are mutually exclusive.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When <c>TargetDomainList</c> is set in the request parameters, the <c>AppName</c> and <c>StreamName</c> parameters take effect.</description></item>
        /// <item><description>When <c>TargetDomainList</c> is set in the request parameters, the <c>HttpDns</c> parameter cannot be set.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>learn.aliyundoc.com,guide.aliyundoc.com</para>
        /// </summary>
        [NameInMap("TargetDomainList")]
        [Validation(Required=false)]
        public string TargetDomainList { get; set; }

        /// <summary>
        /// <para>Specifies whether to pass through ingest parameters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>yes</b>: Ingest parameters are passed through.</description></item>
        /// <item><description><b>no</b> (default): Ingest parameters are not passed through.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>yes</para>
        /// </summary>
        [NameInMap("TransferArgs")]
        [Validation(Required=false)]
        public string TransferArgs { get; set; }

    }

}
