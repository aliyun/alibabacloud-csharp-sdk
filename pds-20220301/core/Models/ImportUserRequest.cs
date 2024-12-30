// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ImportUserRequest : TeaModel {
        /// <summary>
        /// <para>The display name of the authentication type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("authentication_display_name")]
        [Validation(Required=false)]
        public string AuthenticationDisplayName { get; set; }

        /// <summary>
        /// <para>The authentication type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>mobile: mobile number.</description></item>
        /// <item><description>email: email address.</description></item>
        /// <item><description>ding: DingTalk account.</description></item>
        /// <item><description>ram: Alibaba Cloud Resource Access Management (RAM) user.</description></item>
        /// <item><description>wechat: WeCom account.</description></item>
        /// <item><description>ldap: Lightweight Directory Access Protocol (LDAP) account.</description></item>
        /// <item><description>custom: custom account.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mobile</para>
        /// </summary>
        [NameInMap("authentication_type")]
        [Validation(Required=false)]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically create a drive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("auto_create_drive")]
        [Validation(Required=false)]
        public bool? AutoCreateDrive { get; set; }

        /// <summary>
        /// <para>The size of the drive. The value cannot be smaller than -1. A value of -1 specifies that the size is unlimited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("drive_total_size")]
        [Validation(Required=false)]
        public long? DriveTotalSize { get; set; }

        /// <summary>
        /// <para>The additional information.</para>
        /// <para>If authentication_type is set to mobile, set this parameter to a country code. If you do not specify this parameter, 86 is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        /// <summary>
        /// <para>The unique identifier.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>130****</para>
        /// </summary>
        [NameInMap("identity")]
        [Validation(Required=false)]
        public string Identity { get; set; }

        /// <summary>
        /// <para>The nickname of the user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pdsuer</para>
        /// </summary>
        [NameInMap("nick_name")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        /// <summary>
        /// <para>The ID of the group to which the user is added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g12</para>
        /// </summary>
        [NameInMap("parent_group_id")]
        [Validation(Required=false)]
        public string ParentGroupId { get; set; }

    }

}
