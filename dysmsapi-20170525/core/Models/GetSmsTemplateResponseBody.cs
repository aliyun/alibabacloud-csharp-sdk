// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetSmsTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>应用场景内容。</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com/">http://www.aliyun.com/</a></para>
        /// </summary>
        [NameInMap("ApplyScene")]
        [Validation(Required=false)]
        public string ApplyScene { get; set; }

        /// <summary>
        /// <para>审核信息。</para>
        /// </summary>
        [NameInMap("AuditInfo")]
        [Validation(Required=false)]
        public GetSmsTemplateResponseBodyAuditInfo AuditInfo { get; set; }
        public class GetSmsTemplateResponseBodyAuditInfo : TeaModel {
            /// <summary>
            /// <para>审核时间。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-03 11:20:34</para>
            /// </summary>
            [NameInMap("AuditDate")]
            [Validation(Required=false)]
            public string AuditDate { get; set; }

            /// <summary>
            /// <para>审核未通过的原因。</para>
            /// 
            /// <b>Example:</b>
            /// <para>模板内容中包含错别字。</para>
            /// </summary>
            [NameInMap("RejectInfo")]
            [Validation(Required=false)]
            public string RejectInfo { get; set; }

        }

        /// <summary>
        /// <para>请求状态码。取值：</para>
        /// <list type="bullet">
        /// <item><description>OK：代表请求成功。</description></item>
        /// <item><description>其他错误码，请参见<a href="https://help.aliyun.com/document_detail/101346.html">API错误码</a>。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>创建短信模板的时间。</para>
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
        /// <para>国际/港澳台模板类型。当<b>TemplateType</b>参数返回值为<b>3</b>时，此参数取值：</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>：短信通知。</description></item>
        /// <item><description><b>1</b>：推广短信。</description></item>
        /// <item><description><b>2</b>：验证码。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IntlType")]
        [Validation(Required=false)]
        public int? IntlType { get; set; }

        /// <summary>
        /// <para>状态码的描述。</para>
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
        /// <para>工单号。</para>
        /// <para>审核人员查询审核时会用到此参数。您需要审核加急时需要提供此工单号。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2003019****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>申请模板时，关联的短信签名。</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云</para>
        /// </summary>
        [NameInMap("RelatedSignName")]
        [Validation(Required=false)]
        public string RelatedSignName { get; set; }

        /// <summary>
        /// <para>短信模板申请说明，是模板审核的参考信息之一。</para>
        /// 
        /// <b>Example:</b>
        /// <para>申请验证码模板</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>本次调用请求的ID，是由阿里云为该请求生成的唯一标识符，可用于排查和定位问题。</para>
        /// 
        /// <b>Example:</b>
        /// <para>F655A8D5-B967-440B-8683-DAD6FF8DE990</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SignList")]
        [Validation(Required=false)]
        public GetSmsTemplateResponseBodySignList SignList { get; set; }
        public class GetSmsTemplateResponseBodySignList : TeaModel {
            [NameInMap("SignList")]
            [Validation(Required=false)]
            public List<string> SignList { get; set; }

        }

        /// <summary>
        /// <para>短信模板Code。</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_20375****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>短信模板内容。</para>
        /// 
        /// <b>Example:</b>
        /// <para>您正在申请手机注册，验证码为：${code}，5分钟内有效！</para>
        /// </summary>
        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public string TemplateContent { get; set; }

        /// <summary>
        /// <para>短信模板名称。</para>
        /// 
        /// <b>Example:</b>
        /// <para>验证码</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>模板审核状态。返回值：</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>：审核中。</description></item>
        /// <item><description><b>1</b>：通过审核。</description></item>
        /// <item><description><b>2</b>：未通过审核，会返回审核失败的原因，请参考<a href="https://www.alibabacloud.com/help/en/sms/user-guide/causes-of-application-failures-and-suggestions">短信审核失败的处理建议</a>，调用<a href="https://www.alibabacloud.com/help/en/sms/developer-reference/api-dysmsapi-2017-05-25-updatesmstemplate">UpdateSmsTemplate</a>接口或在<a href="https://dysms.console.aliyun.com/domestic/text/template">模板管理</a>页面修改短信模板。</description></item>
        /// <item><description><b>10</b>：取消审核。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TemplateStatus")]
        [Validation(Required=false)]
        public string TemplateStatus { get; set; }

        /// <summary>
        /// <para>模板标识。取值：</para>
        /// <list type="bullet">
        /// <item><description><para>2：用户自定义创建模板。</para>
        /// </description></item>
        /// <item><description><para>3：系统赠送模板。</para>
        /// </description></item>
        /// <item><description><para>4：测试模板。</para>
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
        /// <para>短信类型。取值：</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>：验证码。</description></item>
        /// <item><description><b>1</b>：短信通知。</description></item>
        /// <item><description><b>2</b>：推广短信。</description></item>
        /// <item><description><b>3</b>：国际/港澳台消息。</description></item>
        /// </list>
        /// <remarks>
        /// <para>仅支持企业认证用户申请推广短信和国际/港澳台消息。个人用户与企业用户权益区别详情请参见<a href="https://www.alibabacloud.com/help/en/sms/user-guide/usage-notes">使用须知</a>。</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// <para>模板变量规则。</para>
        /// <para>模板变量规则详情，请参见<a href="https://www.alibabacloud.com/help/en/sms/templaterule-template-variable-parameter-filling-example">示例文档</a>。</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;code&quot;:&quot;characterWithNumber&quot;}</para>
        /// </summary>
        [NameInMap("VariableAttribute")]
        [Validation(Required=false)]
        public string VariableAttribute { get; set; }

        /// <summary>
        /// <para>各运营商审核状态，仅数字短信会返回该参数。</para>
        /// <para>key代表运营商。取值：</para>
        /// <list type="bullet">
        /// <item><description><para>MOBILE_VENDOR：中国移动。</para>
        /// </description></item>
        /// <item><description><para>TELECOM_VENDOR：中国电信。</para>
        /// </description></item>
        /// <item><description><para>UNICOM_VENDOR：中国联通。</para>
        /// </description></item>
        /// </list>
        /// <para> value代表审核状态。取值： </para>
        /// <list type="bullet">
        /// <item><description><para>0：审核中。</para>
        /// </description></item>
        /// <item><description><para>1：通过。</para>
        /// </description></item>
        /// <item><description><para>2：不通过。</para>
        /// </description></item>
        /// <item><description><para>15：已失效。</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;MOBILE_VENDOR&quot;: 0,
        ///     &quot;TELCOM_VENDOR&quot;: 0,
        ///     &quot;UNICOM_VENDOR&quot;: 0
        ///   }</para>
        /// </summary>
        [NameInMap("VendorAuditStatus")]
        [Validation(Required=false)]
        public Dictionary<string, object> VendorAuditStatus { get; set; }

    }

}
