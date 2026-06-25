// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateGreyTagRouteRequest : TeaModel {
        /// <summary>
        /// <para>The canary rules for an application that uses an ALB gateway route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;condition&quot;:&quot;AND&quot;,&quot;items&quot;:[{&quot;cond&quot;:&quot;==&quot;,&quot;name&quot;:&quot;grey&quot;,&quot;operator&quot;:&quot;rawvalue&quot;,&quot;type&quot;:&quot;sourceIp&quot;,&quot;value&quot;:&quot;127.0.0.1&quot;},{&quot;cond&quot;:&quot;==&quot;,&quot;name&quot;:&quot;grey&quot;,&quot;operator&quot;:&quot;rawvalue&quot;,&quot;type&quot;:&quot;cookie&quot;,&quot;value&quot;:&quot;true&quot;},{&quot;cond&quot;:&quot;==&quot;,&quot;name&quot;:&quot;grey&quot;,&quot;operator&quot;:&quot;rawvalue&quot;,&quot;type&quot;:&quot;header&quot;,&quot;value&quot;:&quot;true&quot;}],&quot;path&quot;:&quot;/post-echo/hi&quot;}]</para>
        /// </summary>
        [NameInMap("AlbRules")]
        [Validation(Required=false)]
        public string AlbRules { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7802c49a-67bc-4167-8369-9a9c003c****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The description of the canary rule. The description can be up to 64 characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Canary Release - Regions</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The canary rules for a Dubbo application. This parameter is required for Dubbo applications and cannot be used with the <b>ScRules</b> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;condition&quot;:&quot;OR&quot;,&quot;group&quot;:&quot;DUBBO&quot;,&quot;items&quot;:[{&quot;cond&quot;:&quot;==&quot;,&quot;expr&quot;:&quot;.key1&quot;,&quot;index&quot;:0,&quot;operator&quot;:&quot;rawvalue&quot;,&quot;value&quot;:&quot;value1&quot;},{&quot;cond&quot;:&quot;==&quot;,&quot;expr&quot;:&quot;.key2&quot;,&quot;index&quot;:0,&quot;operator&quot;:&quot;rawvalue&quot;,&quot;value&quot;:&quot;value2&quot;}],&quot;methodName&quot;:&quot;echo&quot;,&quot;serviceName&quot;:&quot;com.alibaba.edas.boot.EchoService&quot;,&quot;version&quot;:&quot;1.0.0&quot;}]</para>
        /// </summary>
        [NameInMap("DubboRules")]
        [Validation(Required=false)]
        public string DubboRules { get; set; }

        /// <summary>
        /// <para>The name of the canary rule. The name can be up to 64 characters long and can contain only lowercase letters, digits, hyphens (-), and Chinese characters. It must start with a lowercase letter and end with a lowercase letter or a digit.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dubbo-echo</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The canary rules for a Spring Cloud application. This parameter is required for Spring Cloud applications and cannot be used with the <b>DubboRules</b> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;condition&quot;:&quot;OR&quot;,&quot;items&quot;:[{&quot;cond&quot;:&quot;==&quot;,&quot;name&quot;:&quot;grey&quot;,&quot;operator&quot;:&quot;rawvalue&quot;,&quot;type&quot;:&quot;param&quot;,&quot;value&quot;:&quot;true&quot;},{&quot;cond&quot;:&quot;==&quot;,&quot;name&quot;:&quot;grey&quot;,&quot;operator&quot;:&quot;rawvalue&quot;,&quot;type&quot;:&quot;cookie&quot;,&quot;value&quot;:&quot;true&quot;},{&quot;cond&quot;:&quot;==&quot;,&quot;name&quot;:&quot;grey&quot;,&quot;operator&quot;:&quot;rawvalue&quot;,&quot;type&quot;:&quot;header&quot;,&quot;value&quot;:&quot;true&quot;}],&quot;path&quot;:&quot;/post-echo/hi&quot;}]</para>
        /// </summary>
        [NameInMap("ScRules")]
        [Validation(Required=false)]
        public string ScRules { get; set; }

    }

}
