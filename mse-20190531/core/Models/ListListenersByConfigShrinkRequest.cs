// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListListenersByConfigShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The data ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zeekr-clueboss.yml</para>
        /// </summary>
        [NameInMap("DataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        /// <summary>
        /// <para>The list of additional canary release rules. When performing listener matching, the additional canary release rules are merged with existing rules for matching.</para>
        /// </summary>
        [NameInMap("ExtGrayRules")]
        [Validation(Required=false)]
        public string ExtGrayRulesShrink { get; set; }

        /// <summary>
        /// <para>The group.</para>
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
        /// <para>The namespace ID. Default value: public.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aaeb4d28-c9eb-4fa2-85f5-d03ce7ee8df1</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated and does not need to be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>...</para>
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

    }

}
