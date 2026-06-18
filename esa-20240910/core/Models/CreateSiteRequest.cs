// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateSiteRequest : TeaModel {
        /// <summary>
        /// <para>The access type for the site. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NS</b>: NS-based access.</para>
        /// </description></item>
        /// <item><description><para><b>CNAME</b>: CNAME-based access.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NS</para>
        /// </summary>
        [NameInMap("AccessType")]
        [Validation(Required=false)]
        public string AccessType { get; set; }

        /// <summary>
        /// <para>The acceleration region. Valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><b>domestic</b>: Chinese mainland only.</para>
        /// </description></item>
        /// <item><description><para><b>global</b>: Global.</para>
        /// </description></item>
        /// <item><description><para><b>overseas</b>: Global (excluding the Chinese mainland).</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>domestic</para>
        /// </summary>
        [NameInMap("Coverage")]
        [Validation(Required=false)]
        public string Coverage { get; set; }

        /// <summary>
        /// <para>The ID of the instance. You can obtain the instance ID by calling the <a href="https://help.aliyun.com/document_detail/2852398.html">ListUserRatePlanInstances</a> operation. You must specify either the instance ID or the site ID. If you specify both, the instance ID takes precedence.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbaudit-cn-nwy349jdb03</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. If you do not specify this parameter, the system automatically uses the ID of the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmw4znnok****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the site.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("SiteName")]
        [Validation(Required=false)]
        public string SiteName { get; set; }

    }

}
