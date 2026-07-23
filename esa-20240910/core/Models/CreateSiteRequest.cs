// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateSiteRequest : TeaModel {
        /// <summary>
        /// <para>The access type of the site. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NS</b>: access by using managed NS.</description></item>
        /// <item><description><b>CNAME</b>: access by configuring a CNAME record.</description></item>
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
        /// <para>The acceleration region. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>domestic</b>: the Chinese mainland only.</description></item>
        /// <item><description><b>global</b>: global.</description></item>
        /// <item><description><b>overseas</b>: global (excluding the Chinese mainland).</description></item>
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
        /// <para>The instance ID. You can call the <a href="https://help.aliyun.com/document_detail/2852398.html">ListUserRatePlanInstances</a> operation to obtain the instance ID. You must specify at least one of the instance ID and site ID. If both are specified, the instance ID takes precedence.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbaudit-cn-nwy349jdb03</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The resource group ID. If you do not specify this parameter, the system automatically uses the default resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmw4znnok****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwner")]
        [Validation(Required=false)]
        public long? ResourceOwner { get; set; }

        /// <summary>
        /// <para>The site name.</para>
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
