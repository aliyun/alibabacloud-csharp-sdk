// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListOperationHostsRequest : TeaModel {
        /// <summary>
        /// <para>The address of the host to query. You can use a domain name or an IP address. Fuzzy match is not supported. Only exact match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.162.XX.XX</para>
        /// </summary>
        [NameInMap("HostAddress")]
        [Validation(Required=false)]
        public string HostAddress { get; set; }

        /// <summary>
        /// <para>The name of the host to query. Fuzzy match is not supported. Only exact match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The instance ID of the Bastionhost instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain this parameter.</para>
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
        /// <para>The operating system of the host to query. Valid values:</para>
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
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("OperationProjectId")]
        [Validation(Required=false)]
        public string OperationProjectId { get; set; }

        /// <summary>
        /// <para>The page number of the current page for a paged query. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page for a paged query.<br>Maximum value of PageSize: 100. Default value: 20. If you leave PageSize empty, 20 entries are returned by default.</para>
        /// <remarks>
        /// <para>Do not leave PageSize empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the Bastionhost instance.</para>
        /// <remarks>
        /// <para>For the mappings between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The source of the host to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Local</b>: local host</description></item>
        /// <item><description><b>Ecs</b>: ECS instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Local</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The ECS instance ID. Exact search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp19ienyt0yax748****</para>
        /// </summary>
        [NameInMap("SourceInstanceId")]
        [Validation(Required=false)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// <para>The status of the host to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: Normal</description></item>
        /// <item><description><b>Release</b>: Released</description></item>
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
