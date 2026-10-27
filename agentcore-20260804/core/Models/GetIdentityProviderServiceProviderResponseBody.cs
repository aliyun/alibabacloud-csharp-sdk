// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetIdentityProviderServiceProviderResponseBody : TeaModel {
        /// <summary>
        /// <para>失败时结合 HTTP 状态及 message 处理。</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>结果结构见本接口返回字段；异步写接口的返回表示受理，不保证后台任务已完成。</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetIdentityProviderServiceProviderResponseBodyData Data { get; set; }
        public class GetIdentityProviderServiceProviderResponseBodyData : TeaModel {
            /// <summary>
            /// <para>我方 SAML 断言消费地址，配置到外部 IdP。</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://sp.example.com/saml/acs">https://sp.example.com/saml/acs</a></para>
            /// </summary>
            [NameInMap("acsUrl")]
            [Validation(Required=false)]
            public string AcsUrl { get; set; }

            /// <summary>
            /// <para>我方 SP 的实体标识，配置到外部 IdP；不是外部 IdP Entity ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://sp.example.com/entity">https://sp.example.com/entity</a></para>
            /// </summary>
            [NameInMap("entityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>我方 SP Metadata XML，供外部 IdP 导入；不能作为 IdP XML 提交 SAML 配置。</para>
            /// 
            /// <b>Example:</b>
            /// <para><EntityDescriptor xmlns="urn:oasis:names:tc:SAML:2.0:metadata" entityID="https://sp.example.com/entity"><SPSSODescriptor protocolSupportEnumeration="urn:oasis:names:tc:SAML:2.0:protocol"><AssertionConsumerService Binding="urn:oasis:names:tc:SAML:2.0:bindings:HTTP-POST" Location="https://sp.example.com/saml/acs" index="0"/></SPSSODescriptor></EntityDescriptor></para>
            /// </summary>
            [NameInMap("metadataXml")]
            [Validation(Required=false)]
            public string MetadataXml { get; set; }

            /// <summary>
            /// <para>查询参数必填，仅支持精确值 SAML；响应返回 SAML。</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAML</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>本次请求的处理状态，不等同后台任务最终结果。</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>请求受理或错误消息；异步任务结果需按对应查询接口核对。</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>用于关联本次调用与排障，失败时请保留。</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-example</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>true 表示本次请求处理成功；异步写入仍需继续查询任务结果。</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
