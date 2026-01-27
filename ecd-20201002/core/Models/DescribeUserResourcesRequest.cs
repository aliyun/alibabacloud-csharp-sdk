// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class DescribeUserResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The access type. If you leave this parameter empty, both types will be displayed.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>INTERNET: access over the Internet.</description></item>
        /// <item><description>VPC: access over an enterprise virtual private cloud (VPC).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INTERNET</para>
        /// </summary>
        [NameInMap("AccessType")]
        [Validation(Required=false)]
        public string AccessType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the immediate refresh feature.</para>
        /// <remarks>
        /// <para> To ensure the operation response speed, we recommend that you set the value to <c>false</c>.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false</description></item>
        /// <item><description>true</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRefresh")]
        [Validation(Required=false)]
        public bool? AutoRefresh { get; set; }

        /// <summary>
        /// <para>The level-2 resource category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public int? CategoryId { get; set; }

        /// <summary>
        /// <para>The level-1 resource category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CategoryType")]
        [Validation(Required=false)]
        public int? CategoryType { get; set; }

        /// <summary>
        /// <para>The client ID. The system generates a unique ID for each client. This parameter is non-sensitive and does not need encryption.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54c17e1d-2d72-4b87-aa33-25f3b3f2****</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The client type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>html5: the web client.</description></item>
        /// <item><description>android: the Android client.</description></item>
        /// <item><description>windows: the Windows client.</description></item>
        /// <item><description>ios: the iOS client.</description></item>
        /// <item><description>macos: the macOS client.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>windows</para>
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public string ClientType { get; set; }

        /// <summary>
        /// <para>The client version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7.6.0-R-20241112.222305</para>
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether to enable geo-redundant forwarding. Set the value to <c>false</c>.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>false: disables geo-redundant forwarding.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DualCenterForward")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? DualCenterForward { get; set; }

        /// <summary>
        /// <para>The client language.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>en_US: English.</description></item>
        /// <item><description>zh_CN: Simplified Chinese.</description></item>
        /// <item><description>ja_JP: Japanese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The ID of the region where end users log on to clients. This parameter applies to office network ID-based logons. For organization ID-based logons, you can leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("LoginRegionId")]
        [Validation(Required=false)]
        public string LoginRegionId { get; set; }

        /// <summary>
        /// <para>The logon token. You can call the <c>GetLoginToken</c> or <c>RefreshLoginToken</c> operation to retrieve the logon token.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v18101ac6a9e69c66b04a163031680463660b4b216cd758f34b60b9ad6a7c7f7334b83dd8f75eef4209c68f9f1080b****</para>
        /// </summary>
        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The office network IDs. This parameter is required for logons by using enterprise Active Directory (AD) accounts.</para>
        /// </summary>
        [NameInMap("OfficeSiteIds")]
        [Validation(Required=false)]
        public List<string> OfficeSiteIds { get; set; }

        /// <summary>
        /// <para>The sorting field. If you do not specify this parameter, resources are sorted by creation time by default.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateTime: the time when resources are created.</description></item>
        /// <item><description>AssignTime: the time when resources are assigned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AssignTime</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The service types. If you leave this parameter empty, services of all supported types will be queried.</para>
        /// </summary>
        [NameInMap("ProductTypes")]
        [Validation(Required=false)]
        public List<string> ProductTypes { get; set; }

        /// <summary>
        /// <para>The protocol type. You can specify this parameter to filter cloud computers.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HDX: High-definition Experience (HDX).</description></item>
        /// <item><description>ASP: Adaptive Streaming Protocol (ASP).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASP</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>是否查询云桌面套餐包信息，默认为true。</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("QueryDesktopDurationList")]
        [Validation(Required=false)]
        public bool? QueryDesktopDurationList { get; set; }

        /// <summary>
        /// <para>是否查询云电脑定时任务信息，默认为true。</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("QueryDesktopTimers")]
        [Validation(Required=false)]
        public bool? QueryDesktopTimers { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the image version information of cloud computers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("QueryFotaUpdate")]
        [Validation(Required=false)]
        public bool? QueryFotaUpdate { get; set; }

        /// <summary>
        /// <para>Specifies whether to refresh over-the-air (OTA) information in real time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RefreshFotaUpdate")]
        [Validation(Required=false)]
        public bool? RefreshFotaUpdate { get; set; }

        /// <summary>
        /// <para>The resource IDs. You can specify up to 100 resource IDs.</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>The resource name. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The resource types. If you leave this parameter empty, resources of all supported types will be queried.</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public List<string> ResourceTypes { get; set; }

        /// <summary>
        /// <para>The client usage scenario. Set the value to <c>desktop</c>.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>desktop: cloud computers.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desktop</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>The ID of the searched region. You can specify this parameter to filter cloud resources in specific regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SearchRegionId")]
        [Validation(Required=false)]
        public string SearchRegionId { get; set; }

        /// <summary>
        /// <para>The session ID. You can call the <c>GetLoginToken</c> operation to retrieve the session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cd45e873-650d-4d70-acb9-f996187a****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The sorting method.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC (default): the ascending order.</description></item>
        /// <item><description>DESC: the descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

    }

}
