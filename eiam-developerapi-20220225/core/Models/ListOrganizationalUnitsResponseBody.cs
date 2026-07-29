// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class ListOrganizationalUnitsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of data objects.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListOrganizationalUnitsResponseBodyData> Data { get; set; }
        public class ListOrganizationalUnitsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the organization was created. This is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652083425923</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the organization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试组织</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The external ID of the organization. This ID is used to map external data to the organization\&quot;s data in IDaaS. The default value is the IDaaS organization ID.</para>
            /// <para>Note: The external ID must be unique for the same source type and source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
            /// </summary>
            [NameInMap("organizationalUnitExternalId")]
            [Validation(Required=false)]
            public string OrganizationalUnitExternalId { get; set; }

            /// <summary>
            /// <para>The organization ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
            /// </summary>
            [NameInMap("organizationalUnitId")]
            [Validation(Required=false)]
            public string OrganizationalUnitId { get; set; }

            /// <summary>
            /// <para>The organization name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name001</para>
            /// </summary>
            [NameInMap("organizationalUnitName")]
            [Validation(Required=false)]
            public string OrganizationalUnitName { get; set; }

            /// <summary>
            /// <para>The source ID of the organization.</para>
            /// <para>For the \<c>build_in\\</c> type, the default value is the instance ID. For other types, the value is the enterprise ID from the source. For example, if the source is DingTalk, the value is the \<c>corpId\\</c> of the DingTalk enterprise.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("organizationalUnitSourceId")]
            [Validation(Required=false)]
            public string OrganizationalUnitSourceId { get; set; }

            /// <summary>
            /// <para>The source type of the organization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>\<c>build_in\\</c>: The organization is created in IDaaS.</para>
            /// </description></item>
            /// <item><description><para>\<c>ding_talk\\</c>: The organization is imported from DingTalk.</para>
            /// </description></item>
            /// <item><description><para>\<c>ad\\</c>: The organization is imported from Active Directory (AD).</para>
            /// </description></item>
            /// <item><description><para>\<c>ldap\\</c>: The organization is imported from LDAP.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>build_in</para>
            /// </summary>
            [NameInMap("organizationalUnitSourceType")]
            [Validation(Required=false)]
            public string OrganizationalUnitSourceType { get; set; }

            /// <summary>
            /// <para>The parent organization ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
            /// </summary>
            [NameInMap("parentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// <para>The time when the organization was last updated. This is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652083425923</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
