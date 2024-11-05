// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostsForUserGroupRequest : TeaModel {
        /// <summary>
        /// <para>The endpoint of the host that you want to query. You can set this parameter to a domain name or an IP address. Only exact match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
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
        /// <para>The ID of the bastion host on which you want to query the hosts that the user group is authorized or not authorized to manage.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the ID of the bastion host.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-st220aw****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies the category of the hosts that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Authorized</b>: queries the hosts that the user group is authorized to manage. This is the default value.</description></item>
        /// <item><description><b>Unauthorized</b>: queries the hosts that the user group is not authorized to manage.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Authorized</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

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
        /// <para>The number of the page. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.\
        /// Maximum value: 100. Default value: 20. If you leave this parameter empty, 20 entries are returned per page.</para>
        /// <remarks>
        /// <para>We recommend that you do not leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host on which you want to query the hosts that the user group is authorized or not authorized to manage.</para>
        /// <remarks>
        /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the user group for which you want to query hosts.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/204509.html">ListUserGroups</a> operation to query the ID of the user group.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

    }

}
