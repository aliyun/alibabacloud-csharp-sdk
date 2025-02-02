// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class SetDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>The binding status of the custom domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BINDING</b>: The domain name has been bound.</description></item>
        /// <item><description><b>BOUND</b>: The domain name has not been bound.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BINDING</para>
        /// </summary>
        [NameInMap("DomainBindingStatus")]
        [Validation(Required=false)]
        public string DomainBindingStatus { get; set; }

        /// <summary>
        /// <para>The validity status of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NORMAL</b>: The domain name is valid.</description></item>
        /// <item><description><b>ABNORMAL</b>: The domain name is invalid. This status affects API calls and must be resolved as soon as possible.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("DomainLegalStatus")]
        [Validation(Required=false)]
        public string DomainLegalStatus { get; set; }

        /// <summary>
        /// <para>The custom domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api.demo.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The remarks on the domain name, such as the cause of an exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("DomainRemark")]
        [Validation(Required=false)]
        public string DomainRemark { get; set; }

        /// <summary>
        /// <para>The status of the domain name that uses the WebSocket feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("DomainWebSocketStatus")]
        [Validation(Required=false)]
        public string DomainWebSocketStatus { get; set; }

        /// <summary>
        /// <para>The ID of the API group. This ID is generated by the system and globally unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>927d50c0f2e54b359919923d908bb015</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AA90E87-3506-5AA6-AFFB-A4D53B4F6231</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The second-level domain name assigned to the API group. This domain name is used to test API calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx-cn-hangzhou.alicloudapi.com</para>
        /// </summary>
        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public string SubDomain { get; set; }

    }

}
