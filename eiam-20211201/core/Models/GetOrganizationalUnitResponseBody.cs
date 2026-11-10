// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetOrganizationalUnitResponseBody : TeaModel {
        /// <summary>
        /// <para>The organizational unit data object.</para>
        /// </summary>
        [NameInMap("OrganizationalUnit")]
        [Validation(Required=false)]
        public GetOrganizationalUnitResponseBodyOrganizationalUnit OrganizationalUnit { get; set; }
        public class GetOrganizationalUnitResponseBodyOrganizationalUnit : TeaModel {
            /// <summary>
            /// <para>The time when the organizational unit was created. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the organizational unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test organization</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Specifies whether the organizational unit is a leaf node. A value of true indicates that the organizational unit has no child nodes. A value of false indicates that the organizational unit has child nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Leaf")]
            [Validation(Required=false)]
            public bool? Leaf { get; set; }

            /// <summary>
            /// <para>The external ID of the organizational unit. It is used to map external data to IDaaS organizational units. The default value is the IDaaS organizational unit ID. Note: The external ID must be unique within the same source type and source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
            /// </summary>
            [NameInMap("OrganizationalUnitExternalId")]
            [Validation(Required=false)]
            public string OrganizationalUnitExternalId { get; set; }

            /// <summary>
            /// <para>The organizational unit ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
            /// </summary>
            [NameInMap("OrganizationalUnitId")]
            [Validation(Required=false)]
            public string OrganizationalUnitId { get; set; }

            /// <summary>
            /// <para>The name of the organizational unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_organizationalUnit_name</para>
            /// </summary>
            [NameInMap("OrganizationalUnitName")]
            [Validation(Required=false)]
            public string OrganizationalUnitName { get; set; }

            /// <summary>
            /// <para>The source ID of the organizational unit. For self-managed organizational units, the default value is the instance ID. For other types, the value corresponds to the enterprise ID of the respective source. For example, for DingTalk, the value is the corpId of the DingTalk enterprise.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("OrganizationalUnitSourceId")]
            [Validation(Required=false)]
            public string OrganizationalUnitSourceId { get; set; }

            /// <summary>
            /// <para>The account source type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>build_in: Self-managed.</description></item>
            /// <item><description>ding_talk: Imported from DingTalk.</description></item>
            /// <item><description>ad: Imported from AD.</description></item>
            /// <item><description>ldap: Imported from LDAP.</description></item>
            /// <item><description>we_com: Imported from WeCom.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>build_in</para>
            /// </summary>
            [NameInMap("OrganizationalUnitSourceType")]
            [Validation(Required=false)]
            public string OrganizationalUnitSourceType { get; set; }

            /// <summary>
            /// <para>The ID of the parent organizational unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// <para>The time when the organizational unit was last updated. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
