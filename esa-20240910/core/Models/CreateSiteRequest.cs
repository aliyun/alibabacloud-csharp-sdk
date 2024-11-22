// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateSiteRequest : TeaModel {
        /// <summary>
        /// <para>The DNS setup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NS</b></description></item>
        /// <item><description><b>CNAME</b></description></item>
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
        /// <para>The service location. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>domestic</b>: the Chinese mainland</description></item>
        /// <item><description><b>global</b>: global</description></item>
        /// <item><description><b>overseas</b>: outside the Chinese mainland</description></item>
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
        /// <para>The instance ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2852398.html">ListUserRatePlanInstances</a> operation. Specify at least one of the instance ID and website ID. If you specify both of them, the instance ID is used.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbaudit-cn-nwy349jdb03</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. If you leave this parameter empty, the system uses the default resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmw4znnok****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The website name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateSite</para>
        /// </summary>
        [NameInMap("SiteName")]
        [Validation(Required=false)]
        public string SiteName { get; set; }

    }

}
