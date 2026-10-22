// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostGroupsForUserRequest : TeaModel {
        /// <summary>
        /// <para>The name of the host group to query. The name can be up to 128 characters in length. Only exact match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group</para>
        /// </summary>
        [NameInMap("HostGroupName")]
        [Validation(Required=false)]
        public string HostGroupName { get; set; }

        /// <summary>
        /// <para>The instance ID of the Bastionhost instance to which the user belongs.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain the parameter value.</para>
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
        /// <para>The mode of the host group list to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Authorized</b>: Authorized host groups. This is the default value.</description></item>
        /// <item><description><b>Unauthorized</b>: Unauthorized host groups.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Authorized</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The page number for paging. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>１</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return per page for paging.<br>The maximum value of the PageSize parameter is 100. Default value: 20. If you leave this parameter empty, 20 entries are returned by default.</para>
        /// <remarks>
        /// <para>Specify a value for the PageSize parameter.</para>
        /// </remarks>
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
        /// <para>The region ID of the Bastionhost instance to which the user belongs.</para>
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
        /// <para>The ID of the user to query.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/204522.html">ListUsers</a> operation to obtain the parameter value.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>１</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
