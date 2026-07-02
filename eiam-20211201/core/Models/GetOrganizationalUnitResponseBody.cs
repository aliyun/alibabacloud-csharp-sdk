// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetOrganizationalUnitResponseBody : TeaModel {
        /// <summary>
        /// <para>Organizational unit data object.</para>
        /// </summary>
        [NameInMap("OrganizationalUnit")]
        [Validation(Required=false)]
        public GetOrganizationalUnitResponseBodyOrganizationalUnit OrganizationalUnit { get; set; }
        public class GetOrganizationalUnitResponseBodyOrganizationalUnit : TeaModel {
            /// <summary>
            /// <para>The time when the organizational unit was created, in Unix timestamp format, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Description of the organizational unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test organization</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the organizational unit is a leaf node. A value of true indicates that the organizational unit has no child nodes, and a value of false indicates that the organizational unit has child nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Leaf")]
            [Validation(Required=false)]
            public bool? Leaf { get; set; }

            /// <summary>
            /// <para>Organizational unit external ID, used for mapping between external data and IDaaS organizational units. The default value is the IDaaS organizational unit ID.</para>
            /// <para>Note: The external ID is unique within the same source type and source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
            /// </summary>
            [NameInMap("OrganizationalUnitExternalId")]
            [Validation(Required=false)]
            public string OrganizationalUnitExternalId { get; set; }

            /// <summary>
            /// <para>Organizational unit ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
            /// </summary>
            [NameInMap("OrganizationalUnitId")]
            [Validation(Required=false)]
            public string OrganizationalUnitId { get; set; }

            /// <summary>
            /// <para>Organizational unit name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_organizationalUnit_name</para>
            /// </summary>
            [NameInMap("OrganizationalUnitName")]
            [Validation(Required=false)]
            public string OrganizationalUnitName { get; set; }

            /// <summary>
            /// <para>Organizational unit source ID.</para>
            /// <para>The default value for the self-built type is the instance ID. For other types, the value corresponds to the enterprise ID of the respective source. For example, the DingTalk source corresponds to the corpId of the DingTalk enterprise.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("OrganizationalUnitSourceId")]
            [Validation(Required=false)]
            public string OrganizationalUnitSourceId { get; set; }

            /// <summary>
            /// <para>Account source type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>build_in: self-built.</description></item>
            /// <item><description>ding_talk: imported from DingTalk.</description></item>
            /// <item><description>ad: imported from AD.</description></item>
            /// <item><description>ldap: imported from LDAP.</description></item>
            /// <item><description>we_com: imported from WeCom.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>build_in</para>
            /// </summary>
            [NameInMap("OrganizationalUnitSourceType")]
            [Validation(Required=false)]
            public string OrganizationalUnitSourceType { get; set; }

            /// <summary>
            /// <para>Parent organizational unit ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// <para>The time when the organizational unit was last updated, in Unix timestamp format, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
