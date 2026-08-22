// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAlertTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The request status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAlertTypeResponseBodyData> Data { get; set; }
        public class DescribeAlertTypeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The threat type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WEBSHELL</para>
            /// </summary>
            [NameInMap("AlertType")]
            [Validation(Required=false)]
            public string AlertType { get; set; }

            /// <summary>
            /// <para>The threat type category identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>identity_access</para>
            /// </summary>
            [NameInMap("AlertTypeCategory")]
            [Validation(Required=false)]
            public string AlertTypeCategory { get; set; }

            /// <summary>
            /// <para>The threat type category name in the language of the current request. Empty if no translation is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Identity and Access</para>
            /// </summary>
            [NameInMap("AlertTypeCategoryMds")]
            [Validation(Required=false)]
            public string AlertTypeCategoryMds { get; set; }

            /// <summary>
            /// <para>The display order of the threat type category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AlertTypeCategoryOrder")]
            [Validation(Required=false)]
            public int? AlertTypeCategoryOrder { get; set; }

            /// <summary>
            /// <para>The Medusa code of the threat type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>siem_rule_type_process_abnormal_command</para>
            /// </summary>
            [NameInMap("AlertTypeMds")]
            [Validation(Required=false)]
            public string AlertTypeMds { get; set; }

            /// <summary>
            /// <para>The English name of the threat type. Empty if no translation is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unusual Logon</para>
            /// </summary>
            [NameInMap("AlertTypeNameEn")]
            [Validation(Required=false)]
            public string AlertTypeNameEn { get; set; }

            /// <summary>
            /// <para>The Chinese name of the threat type. Empty if no translation is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>异常登录</para>
            /// </summary>
            [NameInMap("AlertTypeNameZh")]
            [Validation(Required=false)]
            public string AlertTypeNameZh { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: successful.</description></item>
        /// <item><description>false: failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
