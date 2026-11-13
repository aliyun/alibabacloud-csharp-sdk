// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ListApplicationTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of application templates.</para>
        /// </summary>
        [NameInMap("ApplicationTemplates")]
        [Validation(Required=false)]
        public List<ListApplicationTemplateResponseBodyApplicationTemplates> ApplicationTemplates { get; set; }
        public class ListApplicationTemplateResponseBodyApplicationTemplates : TeaModel {
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
            /// <para>Application template 01</para>
            /// </summary>
            [NameInMap("ApplicationTemplateName")]
            [Validation(Required=false)]
            public string ApplicationTemplateName { get; set; }

            /// <summary>
            /// <para>The statistics on built-in applications in the template, categorized by the final effective action.</para>
            /// </summary>
            [NameInMap("BuiltInApplicationActionStatistics")]
            [Validation(Required=false)]
            public ListApplicationTemplateResponseBodyApplicationTemplatesBuiltInApplicationActionStatistics BuiltInApplicationActionStatistics { get; set; }
            public class ListApplicationTemplateResponseBodyApplicationTemplatesBuiltInApplicationActionStatistics : TeaModel {
                /// <summary>
                /// <para>The number of built-in applications whose final effective action is Alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("AlertApplicationCount")]
                [Validation(Required=false)]
                public long? AlertApplicationCount { get; set; }

                /// <summary>
                /// <para>The number of built-in applications whose final effective action is Allow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("AllowApplicationCount")]
                [Validation(Required=false)]
                public long? AllowApplicationCount { get; set; }

                /// <summary>
                /// <para>The number of built-in applications whose final effective action is Deny.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("DenyApplicationCount")]
                [Validation(Required=false)]
                public long? DenyApplicationCount { get; set; }

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
            /// <para>The number of custom application rules under the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CustomRuleCount")]
            [Validation(Required=false)]
            public long? CustomRuleCount { get; set; }

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
            /// <para>The overall switch status of the application template. Valid values:</para>
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
            /// <item><description><b>Allow</b>: Allow.</description></item>
            /// <item><description><b>Alert</b>: Monitor.</description></item>
            /// <item><description><b>Deny</b>: Block.</description></item>
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
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of application templates that meet the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
