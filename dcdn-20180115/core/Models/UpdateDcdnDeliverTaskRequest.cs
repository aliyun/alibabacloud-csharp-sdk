// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class UpdateDcdnDeliverTaskRequest : TeaModel {
        /// <summary>
        /// <para>The method that is used to send operations reports. Operations reports are sent to you only by email. The settings need to be escaped in JSON.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;email&quot;:{&quot;subject&quot;:&quot;the email subject&quot;,&quot;to&quot;:[&quot;<a href="mailto:username@example.com">username@example.com</a>&quot;,&quot;<a href="mailto:username@example.com">username@example.com</a>&quot;]}}</para>
        /// </summary>
        [NameInMap("Deliver")]
        [Validation(Required=false)]
        public string Deliver { get; set; }

        /// <summary>
        /// <para>The ID of the tracking task that you want to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92</para>
        /// </summary>
        [NameInMap("DeliverId")]
        [Validation(Required=false)]
        public long? DeliverId { get; set; }

        /// <summary>
        /// <para>The domain names from which the tracking task collects data. Separate domain names with commas (,). If you do not specify a domain name, the task collects data from all domain names that belong to your Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The name of the tracking task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Domain name report</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The operations reports that are tracked by the task. The data needs to be escaped in JSON.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\\&quot;reportId\\&quot;:2,\\&quot;conditions\\&quot;:[{\\&quot;field\\&quot;:\\&quot;prov\\&quot;,\\&quot;op\\&quot;:\\&quot;in\\&quot;,\\&quot;value\\&quot;:[\\&quot;Heilongjiang\\&quot;,\\&quot;Beijing\\&quot;]}]}]</para>
        /// </summary>
        [NameInMap("Reports")]
        [Validation(Required=false)]
        public string Reports { get; set; }

        /// <summary>
        /// <para>The parameters that specify the time interval at which the tracking task sends operations reports. The settings need to be escaped in JSON.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;schedName&quot;:&quot;the name of the tracking task&quot;,&quot;description&quot;:&quot;the description&quot;,&quot;crontab&quot;:&quot;000\<em>\</em>?&quot;,&quot;frequency&quot;:&quot;d&quot;,&quot;status&quot;:&quot;enable&quot;,&quot;effectiveFrom&quot;:&quot;2020-09-17T00:00:00Z&quot;,&quot;effectiveEnd&quot;:&quot;2020-11-17T00:00:00Z&quot;}</para>
        /// </summary>
        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public string Schedule { get; set; }

    }

}
