// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetLiveEdgeTransferRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs. Regular expressions are supported, with a few limits. For more information, see the <b>Description about the AppName and StreamName parameters</b> section. For example, a value of <b>liveApp\<em>\</em>\<em>\</em>[1,2,3]</b> specifies that stream relay is configured for three applications: liveApp\<em>\</em>\<em>\<em>1, liveApp\</em>\</em>\<em>\<em>2, and liveApp\</em>\</em>\<em>\<em>3.</em></em>**</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect for only destination domain names that are specified by the TargetDomainList parameter.</para>
        /// </description></item>
        /// <item><description><para>You cannot use a caret (^) or a dollar sign ($) in a regular expression to configure the <c>AppName</c> parameter. Otherwise, stream relay fails.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The ingest domain. Stream relay is configured based on the ingest domain. Only one stream relay configuration can be set for an ingest domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The HTTPDNS API that is used to obtain the destination URLs. The request must contain the <c>TargetDomainList</c> parameter or the <c>HttpDns</c> parameter. The two parameters are mutually exclusive.</para>
        /// <remarks>
        /// <para> If the <c>HttpDns</c> parameter is configured, you cannot configure the <c>TargetDomainList</c> parameter, and the <c>AppName</c> and <c>StreamName</c> parameters do not take effect.</para>
        /// </remarks>
        /// <para>For information about the requirements on the structure of messages that are returned by the HTTPDNS API, see the <b>Description about the HTTPDNS API</b> section.</para>
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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the ingested stream. Regular expressions are supported, with a few limits. For more information, see the <b>Description about the AppName and StreamName parameters</b> section. For example, a value of <b>liveStream\<em>\</em>\<em>\</em>[1,2,3]</b> specifies that stream relay is configured for three streams: liveStream\<em>\</em>\<em>\<em>1, liveStream\</em>\</em>\<em>\<em>2, and liveStream\</em>\</em>\<em>\<em>3.</em></em>**</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect for only destination domain names that are specified by the TargetDomainList parameter.</para>
        /// </description></item>
        /// <item><description><para>You cannot use a caret (^) or a dollar sign ($) in a regular expression to configure the <c>StreamName</c> parameter. Otherwise, stream relay fails.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>liveStream****</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        /// <summary>
        /// <para>The destination domain names to which you want to relay the ingested stream. Separate multiple domain names with commas (,). The request must contain the <c>TargetDomainList</c> parameter or the <c>HttpDns</c> parameter. The two parameters are mutually exclusive.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The <c>AppName</c> and <c>StreamName</c> parameters take effect only when the <c>TargetDomainList</c> parameter is configured.</para>
        /// </description></item>
        /// <item><description><para>If the <c>TargetDomainList</c> parameter is configured, you cannot configure the <c>HttpDns</c> parameter.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>learn.aliyundoc.com,guide.aliyundoc.com</para>
        /// </summary>
        [NameInMap("TargetDomainList")]
        [Validation(Required=false)]
        public string TargetDomainList { get; set; }

        /// <summary>
        /// <para>Specifies whether to pass through stream ingest parameters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>yes</b>: passes through stream ingest parameters.</description></item>
        /// <item><description><b>no</b>: does not pass through stream ingest parameters.</description></item>
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
