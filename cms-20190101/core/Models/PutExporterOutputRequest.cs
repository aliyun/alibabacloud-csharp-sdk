// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutExporterOutputRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the data export. The value is a JSONObject string that must contain the following fields:</para>
        /// <list type="bullet">
        /// <item><description>endpoint: the domain name that corresponds to the data of Log Service (SLS).</description></item>
        /// <item><description>project: the project.</description></item>
        /// <item><description>logstore: the Logstore.</description></item>
        /// <item><description>ak: the AccessKey ID.</description></item>
        /// <item><description>as: the AccessKey secret.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;endpoint&quot;: &quot;<a href="http://cn-qingdao-share.log.aliyuncs.com">http://cn-qingdao-share.log.aliyuncs.com</a>&quot;, &quot;project&quot;: &quot;exporter&quot;, &quot;logstore&quot;: &quot;exporter&quot;,&quot;ak&quot;: &quot;LTAIp*******&quot;, &quot;userId&quot;: &quot;17754********&quot;, &quot;as&quot;: &quot;TxHwuJ8yAb3AU******&quot;}</para>
        /// </summary>
        [NameInMap("ConfigJson")]
        [Validation(Required=false)]
        public string ConfigJson { get; set; }

        /// <summary>
        /// <para>The description of the configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CPU metric export</para>
        /// </summary>
        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// <para>The name of the configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exporterConfig</para>
        /// </summary>
        [NameInMap("DestName")]
        [Validation(Required=false)]
        public string DestName { get; set; }

        /// <summary>
        /// <para>The product to which the data is exported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sls</para>
        /// </summary>
        [NameInMap("DestType")]
        [Validation(Required=false)]
        public string DestType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
