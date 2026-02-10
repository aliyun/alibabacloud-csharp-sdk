// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetSmsTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>Application scenario content.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com/">http://www.aliyun.com/</a></para>
        /// </summary>
        [NameInMap("ApplyScene")]
        [Validation(Required=false)]
        public string ApplyScene { get; set; }

        /// <summary>
        /// <para>Audit information.</para>
        /// </summary>
        [NameInMap("AuditInfo")]
        [Validation(Required=false)]
        public GetSmsTemplateResponseBodyAuditInfo AuditInfo { get; set; }
        public class GetSmsTemplateResponseBodyAuditInfo : TeaModel {
            /// <summary>
            /// <para>Audit date and time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-03 11:20:34</para>
            /// </summary>
            [NameInMap("AuditDate")]
            [Validation(Required=false)]
            public string AuditDate { get; set; }

            /// <summary>
            /// <para>Reasons for failed audit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>模板内容中包含错别字。</para>
            /// </summary>
            [NameInMap("RejectInfo")]
            [Validation(Required=false)]
            public string RejectInfo { get; set; }

        }

        /// <summary>
        /// <para>Request status code.</para>
        /// <list type="bullet">
        /// <item><description>OK indicates a successful request.</description></item>
        /// <item><description>For other error codes, please refer to <a href="https://help.aliyun.com/document_detail/101346.html">API Error Codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The time when the SMS template was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-03 10:02:34</para>
        /// </summary>
        [NameInMap("CreateDate")]
        [Validation(Required=false)]
        public string CreateDate { get; set; }

        [NameInMap("FileUrlList")]
        [Validation(Required=false)]
        public GetSmsTemplateResponseBodyFileUrlList FileUrlList { get; set; }
        public class GetSmsTemplateResponseBodyFileUrlList : TeaModel {
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public List<string> FileUrl { get; set; }

        }

        /// <summary>
        /// <para>International/Hong Kong, Macao, and Taiwan template type. When the <b>TemplateType</b> parameter is <b>3</b>, this parameter is required for international/Hong Kong, Macao, and Taiwan templates, with values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Verification code.</description></item>
        /// <item><description><b>1</b>: SMS notification.</description></item>
        /// <item><description><b>2</b>: Promotional SMS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IntlType")]
        [Validation(Required=false)]
        public int? IntlType { get; set; }

        /// <summary>
        /// <para>Description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("MoreDataFileUrlList")]
        [Validation(Required=false)]
        public GetSmsTemplateResponseBodyMoreDataFileUrlList MoreDataFileUrlList { get; set; }
        public class GetSmsTemplateResponseBodyMoreDataFileUrlList : TeaModel {
            [NameInMap("MoreDataFileUrl")]
            [Validation(Required=false)]
            public List<string> MoreDataFileUrl { get; set; }

        }

        /// <summary>
        /// <para>Work order number.</para>
        /// <para>This parameter is used by auditors when querying the audit. You need to provide this work order number when requesting expedited review.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2003019****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The SMS signature associated with the template when applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云</para>
        /// </summary>
        [NameInMap("RelatedSignName")]
        [Validation(Required=false)]
        public string RelatedSignName { get; set; }

        /// <summary>
        /// <para>Explanation for the SMS template application, which is one of the reference information for template review.</para>
        /// 
        /// <b>Example:</b>
        /// <para>申请验证码模板</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The ID of this call request, which is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting and issue定位.</para>
        /// 
        /// <b>Example:</b>
        /// <para>819BE656-D2E0-4858-8B21-B2E47708****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>SMS template code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_20375****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>Content of the SMS template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>您正在申请手机注册，验证码为：${code}，5分钟内有效！</para>
        /// </summary>
        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public string TemplateContent { get; set; }

        /// <summary>
        /// <para>Name of the SMS template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>验证码</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>Template review status. Return values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Under review.</description></item>
        /// <item><description><b>1</b>: Approved.</description></item>
        /// <item><description><b>2</b>: Not approved, with reasons for failure returned. Please refer to <a href="https://help.aliyun.com/zh/sms/user-guide/causes-of-application-failures-and-suggestions?spm=a2c4g.11186623.0.0.41fd339f3bPSCQ">Handling Suggestions for Failed SMS Reviews</a>, invoke the <a href="https://help.aliyun.com/zh/sms/developer-reference/api-dysmsapi-2017-05-25-updatesmstemplate?spm">UpdateSmsTemplate</a> API or modify the SMS template on the <a href="https://dysms.console.aliyun.com/domestic/text/template">Template Management</a> page.</description></item>
        /// <item><description><b>10</b>: Review canceled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TemplateStatus")]
        [Validation(Required=false)]
        public string TemplateStatus { get; set; }

        /// <summary>
        /// <para>Template identifier, indicating whether the template is user-defined or system-provided. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2</b>: User-defined template.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: System-provided template.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TemplateTag")]
        [Validation(Required=false)]
        public int? TemplateTag { get; set; }

        /// <summary>
        /// <para>SMS type. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Verification code.</description></item>
        /// <item><description><b>1</b>: SMS notification.</description></item>
        /// <item><description><b>2</b>: Promotional SMS.</description></item>
        /// <item><description><b>3</b>: International/Hong Kong, Macao, and Taiwan messages.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Only enterprise-certified users can apply for promotional SMS and international/Hong Kong, Macao, and Taiwan messages. For details on the differences between personal and enterprise user rights, please refer to <a href="https://help.aliyun.com/zh/sms/user-guide/usage-notes?spm=a2c4g.11186623.0.0.67447f576NJnE8">Usage Notes</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// <para>Template variable rules.</para>
        /// <para>For detailed rules of template variables, refer to the <a href="https://help.aliyun.com/zh/sms/templaterule-template-variable-parameter-filling-example">Example Document</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;code&quot;:&quot;characterWithNumber&quot;}</para>
        /// </summary>
        [NameInMap("VariableAttribute")]
        [Validation(Required=false)]
        public string VariableAttribute { get; set; }

        [NameInMap("VendorAuditStatus")]
        [Validation(Required=false)]
        public Dictionary<string, object> VendorAuditStatus { get; set; }

    }

}
