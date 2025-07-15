// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveEdgeTransferResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The ingest domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The HTTPDNS API that is used to obtain the destination URLs.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://developer.aliyundoc.com/">http://developer.aliyundoc.com/</a>****</para>
        /// </summary>
        [NameInMap("HttpDns")]
        [Validation(Required=false)]
        public string HttpDns { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53FCB985-C67C-467B-B2B3-398430A21E14</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The name of the ingested stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveStream****</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        /// <summary>
        /// <para>The destination domain names to which the ingested stream is relayed. Multiple domain names are separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>learn.aliyundoc.com,guide.aliyundoc.com</para>
        /// </summary>
        [NameInMap("TargetDomainList")]
        [Validation(Required=false)]
        public string TargetDomainList { get; set; }

        /// <summary>
        /// <para>Indicates whether stream ingest parameters are passed through. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>yes</b>: Stream ingest parameters are passed through.</description></item>
        /// <item><description><b>no</b>: Stream ingest parameters are not passed through.</description></item>
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
