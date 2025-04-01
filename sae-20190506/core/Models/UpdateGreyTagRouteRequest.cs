// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateGreyTagRouteRequest : TeaModel {
        /// <summary>
        /// <para>The canary release rule of the application for which ALB gateway routing is configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;condition&quot;:&quot;AND&quot;,&quot;items&quot;:[{&quot;cond&quot;:&quot;==&quot;,&quot;name&quot;:&quot;grey&quot;,&quot;operator&quot;:&quot;rawvalue&quot;,&quot;type&quot;:&quot;sourceIp&quot;,&quot;value&quot;:&quot;127.0.0.1&quot;},{&quot;cond&quot;:&quot;==&quot;,&quot;name&quot;:&quot;grey&quot;,&quot;operator&quot;:&quot;rawvalue&quot;,&quot;type&quot;:&quot;cookie&quot;,&quot;value&quot;:&quot;true&quot;},{&quot;cond&quot;:&quot;==&quot;,&quot;name&quot;:&quot;grey&quot;,&quot;operator&quot;:&quot;rawvalue&quot;,&quot;type&quot;:&quot;header&quot;,&quot;value&quot;:&quot;true&quot;}],&quot;path&quot;:&quot;/post-echo/hi&quot;}]</para>
        /// </summary>
        [NameInMap("AlbRules")]
        [Validation(Required=false)]
        public string AlbRules { get; set; }

        /// <summary>
        /// <para>The description of the canary release rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>灰度发布-地域灰度</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The canary release rule of the Dubbo application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;condition&quot;:&quot;OR&quot;,&quot;group&quot;:&quot;DUBBO&quot;,&quot;items&quot;:[{&quot;cond&quot;:&quot;==&quot;,&quot;expr&quot;:&quot;.key1&quot;,&quot;index&quot;:0,&quot;operator&quot;:&quot;rawvalue&quot;,&quot;value&quot;:&quot;value1&quot;},{&quot;cond&quot;:&quot;==&quot;,&quot;expr&quot;:&quot;.key2&quot;,&quot;index&quot;:0,&quot;operator&quot;:&quot;rawvalue&quot;,&quot;value&quot;:&quot;value2&quot;}],&quot;methodName&quot;:&quot;echo&quot;,&quot;serviceName&quot;:&quot;com.alibaba.edas.boot.EchoService&quot;,&quot;version&quot;:&quot;1.0.0&quot;}]</para>
        /// </summary>
        [NameInMap("DubboRules")]
        [Validation(Required=false)]
        public string DubboRules { get; set; }

        /// <summary>
        /// <para>The ID of the canary release rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GreyTagRouteId")]
        [Validation(Required=false)]
        public long? GreyTagRouteId { get; set; }

        /// <summary>
        /// <para>The canary release rule of the Spring Cloud application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;condition&quot;:&quot;OR&quot;,&quot;items&quot;:[{&quot;cond&quot;:&quot;==&quot;,&quot;name&quot;:&quot;grey&quot;,&quot;operator&quot;:&quot;rawvalue&quot;,&quot;type&quot;:&quot;param&quot;,&quot;value&quot;:&quot;true&quot;},{&quot;cond&quot;:&quot;==&quot;,&quot;name&quot;:&quot;grey&quot;,&quot;operator&quot;:&quot;rawvalue&quot;,&quot;type&quot;:&quot;cookie&quot;,&quot;value&quot;:&quot;true&quot;},{&quot;cond&quot;:&quot;==&quot;,&quot;name&quot;:&quot;grey&quot;,&quot;operator&quot;:&quot;rawvalue&quot;,&quot;type&quot;:&quot;header&quot;,&quot;value&quot;:&quot;true&quot;}],&quot;path&quot;:&quot;/post-echo/hi&quot;}]</para>
        /// </summary>
        [NameInMap("ScRules")]
        [Validation(Required=false)]
        public string ScRules { get; set; }

    }

}
