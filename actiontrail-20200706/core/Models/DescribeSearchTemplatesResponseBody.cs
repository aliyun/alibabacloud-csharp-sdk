// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class DescribeSearchTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of results returned.</para>
        /// <para>Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>787DD24A-E322-5C0D-A730-057FE62B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of template details.</para>
        /// </summary>
        [NameInMap("TemplateList")]
        [Validation(Required=false)]
        public List<DescribeSearchTemplatesResponseBodyTemplateList> TemplateList { get; set; }
        public class DescribeSearchTemplatesResponseBodyTemplateList : TeaModel {
            /// <summary>
            /// <para>The list of dashboards. This parameter is deprecated.</para>
            /// <remarks>
            /// <para>This parameter is deprecated and no longer returns valid data. The returned value is always an empty array <c>[]</c>. Stop using this parameter and remove its dependency from your code.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Charts")]
            [Validation(Required=false)]
            public string Charts { get; set; }

            /// <summary>
            /// <para>The template description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Events of Console Logons by Using Cloud Account</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The filter conditions.<br>This parameter is returned as a JSON-serialized string that contains a structured list of filter conditions. Use a standard JSON deserialization tool for your programming language to parse the string into an array of objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;key&quot;:&quot;event.eventName&quot;,&quot;value&quot;:&quot;ConsoleSignin&quot;,&quot;type&quot;:&quot;system&quot;,&quot;display&quot;:true,&quot;displayKey&quot;:&quot;event.eventName&quot;,&quot;displayValue&quot;:&quot;ConsoleSignin&quot;,&quot;displayValueEn&quot;:&quot;ConsoleSignin&quot;},{&quot;oper&quot;:&quot;AND&quot;,&quot;key&quot;:&quot;event.userIdentity.type&quot;,&quot;value&quot;:&quot;root-account&quot;,&quot;type&quot;:&quot;system&quot;,&quot;display&quot;:true,&quot;displayKey&quot;:&quot;event.userIdentity.type&quot;,&quot;displayValueEn&quot;:&quot;Alibaba Cloud Account&quot;}]</para>
            /// </summary>
            [NameInMap("Params")]
            [Validation(Required=false)]
            public string Params { get; set; }

            /// <summary>
            /// <para>The scenario ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sc-lpYrjKouRfy3MK-wteJW_Q</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// <para>The query statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select &quot;event.userIdentity.accountId&quot; as account_id, count(1) as cnt group by account_id limit 1000</para>
            /// </summary>
            [NameInMap("Sql")]
            [Validation(Required=false)]
            public string Sql { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tpl-wCZAFWx3Spq6CO9Ymp****</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Events of Console Logons by Using Cloud Account</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The identifier for the template category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>identity.rootLogin</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// <para>The template type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>audit</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
