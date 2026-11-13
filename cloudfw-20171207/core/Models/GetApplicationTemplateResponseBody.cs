// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class GetApplicationTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The application template details.</para>
        /// </summary>
        [NameInMap("ApplicationTemplate")]
        [Validation(Required=false)]
        public GetApplicationTemplateResponseBodyApplicationTemplate ApplicationTemplate { get; set; }
        public class GetApplicationTemplateResponseBodyApplicationTemplate : TeaModel {
            /// <summary>
            /// <para>The ID of the application template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ati-4f0691c56b8d4f06</para>
            /// </summary>
            [NameInMap("ApplicationTemplateId")]
            [Validation(Required=false)]
            public string ApplicationTemplateId { get; set; }

            /// <summary>
            /// <para>The name of the application template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Application Template 01</para>
            /// </summary>
            [NameInMap("ApplicationTemplateName")]
            [Validation(Required=false)]
            public string ApplicationTemplateName { get; set; }

            /// <summary>
            /// <para>The list of built-in application actions.</para>
            /// </summary>
            [NameInMap("BuiltInApplicationActions")]
            [Validation(Required=false)]
            public List<GetApplicationTemplateResponseBodyApplicationTemplateBuiltInApplicationActions> BuiltInApplicationActions { get; set; }
            public class GetApplicationTemplateResponseBodyApplicationTemplateBuiltInApplicationActions : TeaModel {
                /// <summary>
                /// <para>The action performed on the application. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Allow</b>: Allows the traffic.</description></item>
                /// <item><description><b>Alert</b>: Monitors the traffic.</description></item>
                /// <item><description><b>Deny</b>: Blocks the traffic.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Deny</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The ID of the application in the built-in application signature library.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10012150000</para>
                /// </summary>
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public long? ApplicationId { get; set; }

            }

            /// <summary>
            /// <para>The switch status of built-in application control. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enable</b>: Enabled.</description></item>
            /// <item><description><b>Disable</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("BuiltInApplicationStatus")]
            [Validation(Required=false)]
            public string BuiltInApplicationStatus { get; set; }

            /// <summary>
            /// <para>The creation time of the application template. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1731465600</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The switch status of custom application rules. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enable</b>: Enabled.</description></item>
            /// <item><description><b>Disable</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("CustomRuleStatus")]
            [Validation(Required=false)]
            public string CustomRuleStatus { get; set; }

            /// <summary>
            /// <para>The description of the application template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Office network application control</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The master switch status of the application template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enable</b>: Enabled.</description></item>
            /// <item><description><b>Disable</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("TemplateStatus")]
            [Validation(Required=false)]
            public string TemplateStatus { get; set; }

            /// <summary>
            /// <para>The action for unidentified applications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Allow</b>: Allows the traffic.</description></item>
            /// <item><description><b>Alert</b>: Monitors the traffic.</description></item>
            /// <item><description><b>Deny</b>: Blocks the traffic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Alert</para>
            /// </summary>
            [NameInMap("UnknownAction")]
            [Validation(Required=false)]
            public string UnknownAction { get; set; }

            /// <summary>
            /// <para>The last modification time of the application template. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1731469200</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
