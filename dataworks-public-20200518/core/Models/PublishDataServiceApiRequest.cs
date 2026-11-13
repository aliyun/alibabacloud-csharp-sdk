// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class PublishDataServiceApiRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public long? ApiId { get; set; }

        /// <summary>
        /// <para>The list of domain name IDs of the cloud-native API gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-cq1m3utlhtgvgkv7si***, d-i9803utlhtgvgkv7s***</para>
        /// </summary>
        [NameInMap("ApigwDomainIds")]
        [Validation(Required=false)]
        public List<string> ApigwDomainIds { get; set; }

        /// <summary>
        /// <para>The cloud-native API gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-da40itmm1hkgrqjq9***</para>
        /// </summary>
        [NameInMap("ApigwInstanceId")]
        [Validation(Required=false)]
        public string ApigwInstanceId { get; set; }

        /// <summary>
        /// <para>The backend service of the cloud-native API gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>svc-cr6pk4tlhtgm***</para>
        /// </summary>
        [NameInMap("ApigwService")]
        [Validation(Required=false)]
        public string ApigwService { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The tenant ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>, go to the Data Studio page, click the username in the upper-right corner, and choose Menu &gt; User Information to obtain the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10002</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

    }

}
