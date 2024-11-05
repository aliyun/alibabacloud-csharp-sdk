// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListOperationHostsRequest : TeaModel {
        /// <summary>
        /// <para>The address of the host that you want to query. You can set this parameter to a domain name or an IP address. Only exact match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.162.172.132</para>
        /// </summary>
        [NameInMap("HostAddress")]
        [Validation(Required=false)]
        public string HostAddress { get; set; }

        /// <summary>
        /// <para>The name of the host that you want to query. Only exact match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the ID of the bastion host.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-09k22avmw0q</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The operating system of the host that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Linux</b></description></item>
        /// <item><description><b>Windows</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Linux</para>
        /// </summary>
        [NameInMap("OSType")]
        [Validation(Required=false)]
        public string OSType { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.\
        /// Maximum value: 100. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.</para>
        /// <remarks>
        /// <para> We recommend that you do not leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
        /// <remarks>
        /// <para> For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The source of the host that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Local</b></description></item>
        /// <item><description><b>Ecs</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Local</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The ID of the Elastic Compute Service (ECS) instance. Exact match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp19ienyt0yax748****</para>
        /// </summary>
        [NameInMap("SourceInstanceId")]
        [Validation(Required=false)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// <para>The status of the host that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b></description></item>
        /// <item><description><b>Release</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("SourceInstanceState")]
        [Validation(Required=false)]
        public string SourceInstanceState { get; set; }

    }

}
