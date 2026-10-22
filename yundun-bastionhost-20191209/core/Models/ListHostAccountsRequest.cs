// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostAccountsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the host account to query. The name can be up to 128 characters in length. Only exact match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("HostAccountName")]
        [Validation(Required=false)]
        public string HostAccountName { get; set; }

        /// <summary>
        /// <para>The ID of the host whose accounts you want to query. You can call the <a href="https://help.aliyun.com/document_detail/200665.html">ListHosts</a> operation to query the host ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// <para>The array of host IDs whose accounts you want to query. &gt; If the HostId parameter is specified and its value is not 0, this parameter is ignored. This parameter takes effect only when the value of the HostId parameter is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;2&quot;,&quot;3&quot;]</para>
        /// </summary>
        [NameInMap("HostIds")]
        [Validation(Required=false)]
        public string HostIds { get; set; }

        /// <summary>
        /// <para>The ID of the Bastionhost instance to which the host belongs. You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-st220aw****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paging query. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page in a paging query. <br>The maximum value of the PageSize parameter is 100. Default value: 20. If you leave this parameter empty, 20 entries are returned by default. &gt; Specify a value for the PageSize parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

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
        /// <para>The protocol name of the host account to query. <br>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SSH</description></item>
        /// <item><description>RDP</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SSH</para>
        /// </summary>
        [NameInMap("ProtocolName")]
        [Validation(Required=false)]
        public string ProtocolName { get; set; }

        /// <summary>
        /// <para>The region ID of the Bastionhost instance to which the host belongs. For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
