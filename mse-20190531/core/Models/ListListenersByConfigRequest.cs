// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListListenersByConfigRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The ID of the data.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zeekr-clueboss.yml</para>
        /// </summary>
        [NameInMap("DataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        [NameInMap("ExtGrayRules")]
        [Validation(Required=false)]
        public List<ListListenersByConfigRequestExtGrayRules> ExtGrayRules { get; set; }
        public class ListListenersByConfigRequestExtGrayRules : TeaModel {
            [NameInMap("GrayRule")]
            [Validation(Required=false)]
            public string GrayRule { get; set; }

            [NameInMap("GrayRuleName")]
            [Validation(Required=false)]
            public string GrayRuleName { get; set; }

            [NameInMap("GrayRulePriority")]
            [Validation(Required=false)]
            public int? GrayRulePriority { get; set; }

            [NameInMap("GrayRuleType")]
            [Validation(Required=false)]
            public string GrayRuleType { get; set; }

        }

        /// <summary>
        /// <para>The name of the group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod</para>
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-cn-m7r1yurp00e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aaeb4d28-c9eb-4fa2-85f5-d03ce7ee8df1</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The extended request parameters in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\\&quot;appGroup\\&quot;:\\&quot;emas-zfive_prehost\\&quot;,\\&quot;appName\\&quot;:\\&quot;emas-zfive\\&quot;,\\&quot;appStage\\&quot;:\\&quot;PRE_PUBLISH\\&quot;,\\&quot;appUnit\\&quot;:\\&quot;\\&quot;,\\&quot;bucId\\&quot;:\\&quot;225902\\&quot;,\\&quot;bucName\\&quot;:\\&quot;Wireless\\&quot;,\\&quot;provider\\&quot;:\\&quot;aliyun\\&quot;}</para>
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

    }

}
