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
        public List<ListListenersByConfigRequestExtGrayRules> ExtGrayRules { get; set; }
        public class ListListenersByConfigRequestExtGrayRules : TeaModel {
            /// <summary>
            /// <para>The canary release rule. If it is a Beta canary release, this field contains the IP addresses of the canary release clients, separated by commas. If it is a tag-based canary release, this field contains tag_name=tag_value, with multiple tag values separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("GrayRule")]
            [Validation(Required=false)]
            public string GrayRule { get; set; }

            /// <summary>
            /// <para>The name of the canary release version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("GrayRuleName")]
            [Validation(Required=false)]
            public string GrayRuleName { get; set; }

            /// <summary>
            /// <para>The priority of the canary release version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("GrayRulePriority")]
            [Validation(Required=false)]
            public int? GrayRulePriority { get; set; }

            /// <summary>
            /// <para>The type of the canary release rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tags</para>
            /// </summary>
            [NameInMap("GrayRuleType")]
            [Validation(Required=false)]
            public string GrayRuleType { get; set; }

        }

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
