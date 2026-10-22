// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyHostsActiveAddressTypeRequest : TeaModel {
        /// <summary>
        /// <para>The new endpoint type of the host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Public</b>: Internet</description></item>
        /// <item><description><b>Private</b>: private network</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Private</para>
        /// </summary>
        [NameInMap("ActiveAddressType")]
        [Validation(Required=false)]
        public string ActiveAddressType { get; set; }

        /// <summary>
        /// <para>The IDs of the hosts whose endpoint types you want to modify. The value is a character string in JSON format. You can specify up to 100 host IDs.
        /// You can invoke the <a href="https://help.aliyun.com/document_detail/200665.html">ListHosts</a> operation to obtain the value of this parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;1&quot;,&quot;2&quot;]</para>
        /// </summary>
        [NameInMap("HostIds")]
        [Validation(Required=false)]
        public string HostIds { get; set; }

        /// <summary>
        /// <para>The instance ID of the Bastionhost instance to which the host whose endpoint type you want to modify belongs.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain the value of this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-st220aw***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The area ID of the Bastionhost instance to which the host whose endpoint type you want to modify belongs.</para>
        /// <remarks>
        /// <para>For more information about the mapping between area IDs and area names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and active zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
