// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateApplicationTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The list of custom actions to configure for built-in applications. Application IDs in the list must be unique.</para>
        /// </summary>
        [NameInMap("AddBuiltInApplicationCustomActions")]
        [Validation(Required=false)]
        public List<CreateApplicationTemplateRequestAddBuiltInApplicationCustomActions> AddBuiltInApplicationCustomActions { get; set; }
        public class CreateApplicationTemplateRequestAddBuiltInApplicationCustomActions : TeaModel {
            /// <summary>
            /// <para>The action to take on the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Allow</b>: Allow.</description></item>
            /// <item><description><b>Alert</b>: Monitor.</description></item>
            /// <item><description><b>Deny</b>: Block.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Deny</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The ID of the application for which you want to configure a custom action. The application must exist in the built-in application signature library and the ID cannot be 0. You can call the ListApplications operation to query the ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10012150000</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public long? ApplicationId { get; set; }

        }

        /// <summary>
        /// <para>The name of the application template. The name must be 1 to 64 characters in length and can contain Chinese characters, letters, digits, hyphens (-), underscores (_), and periods (.). It cannot contain spaces or be empty.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ApplicationTemplate01</para>
        /// </summary>
        [NameInMap("ApplicationTemplateName")]
        [Validation(Required=false)]
        public string ApplicationTemplateName { get; set; }

        /// <summary>
        /// <para>The switch status of built-in application control. Valid values: <b>Enable</b>, which indicates that built-in application control is enabled. If you specify Disable, an error is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("BuiltInApplicationStatus")]
        [Validation(Required=false)]
        public string BuiltInApplicationStatus { get; set; }

        /// <summary>
        /// <para>The switch status of custom application rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: Enabled.</description></item>
        /// <item><description><b>Disable</b>: Disabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("CustomRuleStatus")]
        [Validation(Required=false)]
        public string CustomRuleStatus { get; set; }

        /// <summary>
        /// <para>The description of the application template. The description can be up to 128 characters in length and can be empty.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("TemplateStatus")]
        [Validation(Required=false)]
        public string TemplateStatus { get; set; }

        /// <summary>
        /// <para>The action to take on unidentified applications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Allow</b>: Allow.</description></item>
        /// <item><description><b>Alert</b>: Monitor.</description></item>
        /// <item><description><b>Deny</b>: Block.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alert</para>
        /// </summary>
        [NameInMap("UnknownAction")]
        [Validation(Required=false)]
        public string UnknownAction { get; set; }

    }

}
