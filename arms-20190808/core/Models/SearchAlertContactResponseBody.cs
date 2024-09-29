// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchAlertContactResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned struct.</para>
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchAlertContactResponseBodyPageBean PageBean { get; set; }
        public class SearchAlertContactResponseBodyPageBean : TeaModel {
            /// <summary>
            /// <para>The information about the alert contacts.</para>
            /// </summary>
            [NameInMap("Contacts")]
            [Validation(Required=false)]
            public List<SearchAlertContactResponseBodyPageBeanContacts> Contacts { get; set; }
            public class SearchAlertContactResponseBodyPageBeanContacts : TeaModel {
                /// <summary>
                /// <para>The ID of the alert contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("ContactId")]
                [Validation(Required=false)]
                public long? ContactId { get; set; }

                /// <summary>
                /// <para>The name of the alert contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John Doe</para>
                /// </summary>
                [NameInMap("ContactName")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                /// <summary>
                /// <para>The contact group to which the contact belongs. If your contacts are added to multiple contact groups, the contact groups are separated by vertical bars (|).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default Group | SRE Group</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The timestamp generated when the alert contact was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1572349025000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The webhook URL of the DingTalk chatbot.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=91f2f6">https://oapi.dingtalk.com/robot/send?access_token=91f2f6</a>****</para>
                /// </summary>
                [NameInMap("DingRobot")]
                [Validation(Required=false)]
                public string DingRobot { get; set; }

                /// <summary>
                /// <para>The email address of the alert contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:someone@example.com">someone@example.com</a></para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The mobile number of the alert contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1381111*****</para>
                /// </summary>
                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmxyexli2****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Indicates whether the alert contact receives system notifications. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: The alert contact receives system notifications.</description></item>
                /// <item><description><c>false</c>: The alert contact does not receive system notifications.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SystemNoc")]
                [Validation(Required=false)]
                public bool? SystemNoc { get; set; }

                /// <summary>
                /// <para>The timestamp generated when the alert contact was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1580258717000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>The ID of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>113197164949****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The information about the webhook.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;body\&quot;:\&quot;{   \\\&quot;msg_type\\\&quot;: \\\&quot;text\\\&quot;,   \\\&quot;content\\\&quot;: {     \\\&quot;text\\\&quot;: \\\&quot;$content\\\&quot;   } }\&quot;,\&quot;header\&quot;:{\&quot;Arms-Content-Type\&quot;:\&quot;json\&quot;},\&quot;method\&quot;:\&quot;post\&quot;,\&quot;params\&quot;:{},\&quot;url\&quot;:\&quot;https://<em><b>&quot;,\&quot;userId\&quot;:\&quot;1131971649</b></em>\&quot;}&quot;,</para>
                /// </summary>
                [NameInMap("Webhook")]
                [Validation(Required=false)]
                public string Webhook { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21E85B16-75A6-429A-9F65-8AAC9A54****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
