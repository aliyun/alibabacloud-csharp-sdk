// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class CreateCdnDeliverTaskRequest : TeaModel {
        /// <summary>
        /// <para>The method that is used to send operations reports. Operations reports are sent to you only by email. The settings must be escaped in JSON.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;email&quot;:{&quot;subject&quot;:&quot;the email subject&quot;,&quot;to&quot;:[&quot;<a href="mailto:username@example.com">username@example.com</a>&quot;,&quot;<a href="mailto:username@example.org">username@example.org</a>&quot;]}}</para>
        /// </summary>
        [NameInMap("Deliver")]
        [Validation(Required=false)]
        public string Deliver { get; set; }

        /// <summary>
        /// <para>The domain names to be tracked. Separate multiple domain names with commas (,). You can specify up to 500 domain names. If you want to specify more than 500 domain names, <a href="https://workorder-intl.console.aliyun.com/?spm=5176.2020520001.aliyun_topbar.18.dbd44bd3e4f845#/ticket/createIndex">submit a ticket</a>.</para>
        /// <remarks>
        /// <para>If you do not specify a domain name, the tracking task is created for all domain names that belong to your Alibaba Cloud account.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example1.com,www.example2.com">www.example1.com,www.example2.com</a></para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The name of the tracking task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Domain name report</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The operations reports that are tracked by the task. The data must be escaped in JSON.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\\&quot;reportId\\&quot;:1,\\&quot;conditions\\&quot;:[{\\&quot;field\\&quot;:\\&quot;prov\\&quot;,\\&quot;op\\&quot;:\\&quot;in\\&quot;,\\&quot;value\\&quot;:[\\&quot;Heilongjiang\\&quot;,\\&quot;Beijing\\&quot;]}]}]</para>
        /// </summary>
        [NameInMap("Reports")]
        [Validation(Required=false)]
        public string Reports { get; set; }

        /// <summary>
        /// <para>The parameters that specify the time interval at which the tracking task sends operations reports. The settings must be escaped in JSON.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\\&quot;schedName\\&quot;:\\&quot;The name of the tracking task\\&quot;,\\&quot;description\\&quot;:\\&quot;The description\\&quot;,\\&quot;crontab\\&quot;:\\&quot;000\<em>\</em>?\\&quot;,\\&quot;frequency\\&quot;:\\&quot;d\\&quot;,\\&quot;status\\&quot;:\\&quot;enable\\&quot;,\\&quot;effectiveFrom\\&quot;:\\&quot;2020-09-17T00:00:00Z\\&quot;,\\&quot;effectiveEnd\\&quot;:\\&quot;2020-11-17T00:00:00Z\\&quot;}&quot;</para>
        /// </summary>
        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public string Schedule { get; set; }

    }

}
