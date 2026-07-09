// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class CreateImageDetectionTaskRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The credential type code. This parameter is required when <c>DetectType</c> is set to <c>credential</c>. Valid values: <c>0101</c> (ID card), <c>0102</c> (bank card), <c>0104</c> (teacher qualification certificate), <c>0107</c> (student ID), <c>0108</c> (driver license), <c>0201</c> (storefront photo), <c>0202</c> (counter photo), <c>0203</c> (scene photo), <c>0301</c> (business license).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0101</para>
        /// </summary>
        [NameInMap("CredType")]
        [Validation(Required=false)]
        public string CredType { get; set; }

        /// <summary>
        /// <para>The detection type. Valid values: <c>auto</c> (automatic, default), <c>aigc</c> (AIGC detection only), <c>credential</c> (credential detection only).</para>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("DetectType")]
        [Validation(Required=false)]
        public string DetectType { get; set; }

        /// <summary>
        /// <para>The URL of the image to be detected. Only HTTP and HTTPS protocols are supported. You must specify at least one of <c>ImageUrl</c> and <c>ObjectKey</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/id-card.jpg">https://example.com/id-card.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The <c>ObjectKey</c> of the image to be detected in OSS. When you use <c>ObjectKey</c>, make sure that the key belongs to the namespace of the current caller. You must specify at least one of <c>ImageUrl</c> and <c>ObjectKey</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deepsign/123456789/scan/abc12345.jpg</para>
        /// </summary>
        [NameInMap("ObjectKey")]
        [Validation(Required=false)]
        public string ObjectKey { get; set; }

    }

}
