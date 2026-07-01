// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetSmsSignResponseBody : TeaModel {
        /// <summary>
        /// <para>APP-ICP备案实体id。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000009***123</para>
        /// </summary>
        [NameInMap("AppIcpRecordId")]
        [Validation(Required=false)]
        public long? AppIcpRecordId { get; set; }

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
        public GetSmsSignResponseBodyAuditInfo AuditInfo { get; set; }
        public class GetSmsSignResponseBodyAuditInfo : TeaModel {
            /// <summary>
            /// <para>审核时间。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-03 12:02:34</para>
            /// </summary>
            [NameInMap("AuditDate")]
            [Validation(Required=false)]
            public string AuditDate { get; set; }

            /// <summary>
            /// <para>审批未通过的原因。</para>
            /// 
            /// <b>Example:</b>
            /// <para>通过资质信息，不能判断是否可以申请此签名。</para>
            /// </summary>
            [NameInMap("RejectInfo")]
            [Validation(Required=false)]
            public string RejectInfo { get; set; }

        }

        /// <summary>
        /// <para>委托授权书审核状态。取值：</para>
        /// <list type="bullet">
        /// <item><description>true：审核通过。</description></item>
        /// <item><description>false：审核未通过（包含审核通过外的其他所有状态）。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AuthorizationLetterAuditPass")]
        [Validation(Required=false)]
        public bool? AuthorizationLetterAuditPass { get; set; }

        /// <summary>
        /// <para>委托授权书ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000********1234</para>
        /// </summary>
        [NameInMap("AuthorizationLetterId")]
        [Validation(Required=false)]
        public long? AuthorizationLetterId { get; set; }

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
        /// <para>短信签名的创建日期和时间。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-03 10:02:34</para>
        /// </summary>
        [NameInMap("CreateDate")]
        [Validation(Required=false)]
        public string CreateDate { get; set; }

        /// <summary>
        /// <para>更多资料信息，补充上传业务证明文件或业务截图文件列表。</para>
        /// </summary>
        [NameInMap("FileUrlList")]
        [Validation(Required=false)]
        public List<string> FileUrlList { get; set; }

        /// <summary>
        /// <para>状态码的描述。</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>工单号。</para>
        /// <para>审核人员查询审核时会用到此参数。您需要审核加急时需要提供此工单号。</para>
        /// 
        /// <b>Example:</b>
        /// <para>20044156924</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>资质ID。申请签名时关联的资质ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2004393****</para>
        /// </summary>
        [NameInMap("QualificationId")]
        [Validation(Required=false)]
        public long? QualificationId { get; set; }

        /// <summary>
        /// <para><b>已废弃，请使用<c>SignIspRegisterDetailList</c>查看各运营商实名报备结果。</b></para>
        /// <para>签名实名制报备结果。取值：</para>
        /// <list type="bullet">
        /// <item><description>0：报备失败。</description></item>
        /// <item><description>1：报备成功。</description></item>
        /// <item><description>2：报备失效。</description></item>
        /// <item><description>-1：无状态。</description></item>
        /// </list>
        /// <para>建议您单击查看<a href="https://help.aliyun.com/document_detail/2873145.html">更多签名实名制报备内容及建议操作</a>。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RegisterResult")]
        [Validation(Required=false)]
        public int? RegisterResult { get; set; }

        /// <summary>
        /// <para>短信签名场景说明，长度不超过200个字符。</para>
        /// 
        /// <b>Example:</b>
        /// <para>登录场景验证码</para>
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

        /// <summary>
        /// <para>短信签名Code。</para>
        /// 
        /// <b>Example:</b>
        /// <para>SIGN_100000077042023_17174665*****_ZM2kG</para>
        /// </summary>
        [NameInMap("SignCode")]
        [Validation(Required=false)]
        public string SignCode { get; set; }

        /// <summary>
        /// <para>运营商报备状态列表。获取此参数返回数据需要<a href="https://api.aliyun.com/api-tools/sdk/Dysmsapi?version=2017-05-25&language=java-tea&tab=primer-doc">更新SDK</a>至4.1.2版本或以上。</para>
        /// </summary>
        [NameInMap("SignIspRegisterDetailList")]
        [Validation(Required=false)]
        public List<GetSmsSignResponseBodySignIspRegisterDetailList> SignIspRegisterDetailList { get; set; }
        public class GetSmsSignResponseBodySignIspRegisterDetailList : TeaModel {
            /// <summary>
            /// <para>运营商类型。取值：</para>
            /// <list type="bullet">
            /// <item><description><b>mobile</b>：中国移动；</description></item>
            /// <item><description><b>unicom</b>：中国联通；</description></item>
            /// <item><description><b>telecom</b>：中国电信。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>telecom</para>
            /// </summary>
            [NameInMap("OperatorCode")]
            [Validation(Required=false)]
            public string OperatorCode { get; set; }

            /// <summary>
            /// <para>运营商反馈时间，格式为yyyy-MM-dd HH:mm:ss。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-13 15:55:26</para>
            /// </summary>
            [NameInMap("OperatorCompleteTime")]
            [Validation(Required=false)]
            public string OperatorCompleteTime { get; set; }

            /// <summary>
            /// <para>报备状态。取值：</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>：报备失败，原因可能为资质信息与工信注册信息不一致或运营商侧无法支持等。建议您登录<a href="https://dysms.console.aliyun.com/domestic/text/sign">短信服务控制台</a>查看具体失败原因，并依据提示进行操作；</description></item>
            /// <item><description><b>1</b>：已报备待验证，当前至少有一个子端口号运营商已返回报备通过，建议您少量多次向不同运营商手机号发送验证码、通知短信进行验证；</description></item>
            /// <item><description><b>2</b>：报备失效，签名超过 6 个月无发送记录时，报备结果失效。如您需要重新启用该签名，请在<a href="https://dysms.console.aliyun.com/domestic/text/sign">短信服务控制台</a>重新发起报备；</description></item>
            /// <item><description><b>3</b>：报备成功，当前至少有一个子端口号运营商已返回报备通过，经验证短信发送成功率符合预期，建议您持续关注发送成功率；</description></item>
            /// <item><description><b>-1</b>：报备中，当前尚未收到运营商反馈的报备结果，建议您等待签名报备状态变更为“已报备待验证”后再批量发送，当前可少量多次尝试使用该签名发送，观察短信发送效果；</description></item>
            /// <item><description><b>-2</b>：未报备，原因可能为当前签名未关联实名资质或关联资质信息不全，建议您修改当前资质或编辑签名绑定其他资质以重新发起报备。</description></item>
            /// </list>
            /// <para>建议您单击查看<a href="https://help.aliyun.com/document_detail/2873145.html">更多签名实名制报备内容及建议操作</a>。</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RegisterStatus")]
            [Validation(Required=false)]
            public int? RegisterStatus { get; set; }

            /// <summary>
            /// <para>报备状态原因列表。</para>
            /// </summary>
            [NameInMap("RegisterStatusReasons")]
            [Validation(Required=false)]
            public List<GetSmsSignResponseBodySignIspRegisterDetailListRegisterStatusReasons> RegisterStatusReasons { get; set; }
            public class GetSmsSignResponseBodySignIspRegisterDetailListRegisterStatusReasons : TeaModel {
                /// <summary>
                /// <para>报备状态原因码。取值：</para>
                /// <list type="bullet">
                /// <item><description><b>UNBINDING_QUA</b>：签名未关联资质；</description></item>
                /// <item><description><b>BINDING_INCOMPLETE_QUA</b>：关联资质信息不全；</description></item>
                /// <item><description><b>NON_REGISTER</b>：未发起报备；</description></item>
                /// <item><description><b>REGISTERING</b>：签名报备中；</description></item>
                /// <item><description><b>DETECTING</b>：未发起探测或探测中；</description></item>
                /// <item><description><b>DETECT_SUCCESS</b>：报备成功；</description></item>
                /// <item><description><b>QUALIFICATION_ERROR</b>：资质原因；</description></item>
                /// <item><description><b>SIGNATURE_ERROR</b>：签名原因；</description></item>
                /// <item><description><b>SIGNATURE_QUALIFICATION_ERROR</b>：签名与资质关系不符；</description></item>
                /// <item><description><b>ONE_CODE_MULTIPLE_SIGN</b>：扩展码原因；</description></item>
                /// <item><description><b>OTHERS_ERROR</b>：其他原因；</description></item>
                /// <item><description><b>REGISTER_TIMEOUT</b>：报备超时；</description></item>
                /// <item><description><b>NO_SEND_RECORD</b>：签名超过6个月无发送记录；</description></item>
                /// <item><description><b>EXT_CODE_RECYCLE</b>：扩展码收回。</description></item>
                /// <item><description><b>SUBPORT_RECYCLE</b>：子端口被运营商治理。</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>REGISTER_TIMEOUT</para>
                /// </summary>
                [NameInMap("ReasonCode")]
                [Validation(Required=false)]
                public string ReasonCode { get; set; }

                /// <summary>
                /// <para>原因说明列表。可能返回0个或者多个原因说明，返回原因码不一定会返回原因说明。</para>
                /// </summary>
                [NameInMap("ReasonDescList")]
                [Validation(Required=false)]
                public List<string> ReasonDescList { get; set; }

            }

        }

        /// <summary>
        /// <para>短信签名名称。</para>
        /// 
        /// <b>Example:</b>
        /// <para>登录验证</para>
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// <para>签名审核状态。取值：</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>：审核中。</description></item>
        /// <item><description><b>1</b>：审核通过。</description></item>
        /// <item><description><b>2</b>：审核失败，请在返回参数<c>AuditInfo.RejectInfo</c>中查看审核失败原因。</description></item>
        /// <item><description><b>10</b>：取消审核。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SignStatus")]
        [Validation(Required=false)]
        public long? SignStatus { get; set; }

        /// <summary>
        /// <para>签名标识。取值：</para>
        /// <list type="bullet">
        /// <item><description>2：用户自定义创建签名。</description></item>
        /// <item><description>3：系统赠送签名。</description></item>
        /// <item><description>4：测试签名。</description></item>
        /// <item><description>5：试用签名。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SignTag")]
        [Validation(Required=false)]
        public string SignTag { get; set; }

        /// <summary>
        /// <para>签名使用场景。</para>
        /// 
        /// <b>Example:</b>
        /// <para>已注册商标名称。</para>
        /// </summary>
        [NameInMap("SignUsage")]
        [Validation(Required=false)]
        public string SignUsage { get; set; }

        /// <summary>
        /// <para>签名为自用或他用。</para>
        /// <list type="bullet">
        /// <item><description><para>false：自用（默认值）。</para>
        /// </description></item>
        /// <item><description><para>true：他用。</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ThirdParty")]
        [Validation(Required=false)]
        public bool? ThirdParty { get; set; }

        /// <summary>
        /// <para>商标实体id。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000009081***</para>
        /// </summary>
        [NameInMap("TrademarkId")]
        [Validation(Required=false)]
        public long? TrademarkId { get; set; }

    }

}
