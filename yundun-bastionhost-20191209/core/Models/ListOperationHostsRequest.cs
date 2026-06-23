// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListOperationHostsRequest : TeaModel {
        /// <summary>
        /// <para>The address of the host. You can specify a domain name or an IP address. Only exact matches are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.162.XX.XX</para>
        /// </summary>
        [NameInMap("HostAddress")]
        [Validation(Required=false)]
        public string HostAddress { get; set; }

        /// <summary>
        /// <para>The name of the host. Only exact matches are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The ID of the Bastionhost instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain this parameter.</para>
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
        /// <para>The operating system of the host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Linux</b></para>
        /// </description></item>
        /// <item><description><para><b>Windows</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Linux</para>
        /// </summary>
        [NameInMap("OSType")]
        [Validation(Required=false)]
        public string OSType { get; set; }

        /// <summary>
        /// <para>The number of the page to return. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.<br> The maximum value is 100. The default value is 20. If you do not specify this parameter, the default value is used.<br></para>
        /// <remarks>
        /// <para>Specify a value for this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Bastionhost instance resides.</para>
        /// <remarks>
        /// <para>For more information about regions and zones, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The source of the host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Local</b>: a local host</para>
        /// </description></item>
        /// <item><description><para><b>Ecs</b>: an ECS instance</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Local</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The ID of the ECS instance. Only exact matches are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp19ienyt0yax748****</para>
        /// </summary>
        [NameInMap("SourceInstanceId")]
        [Validation(Required=false)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// <para>The state of the host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b>: The host is running.</para>
        /// </description></item>
        /// <item><description><para><b>Release</b>: The host is released.</para>
        /// </description></item>
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
