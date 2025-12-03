// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GetGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the group was created. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1652085686179</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The group description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description_demo</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The external ID of the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group_ufdsasn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("groupExternalId")]
        [Validation(Required=false)]
        public string GroupExternalId { get; set; }

        /// <summary>
        /// <para>The group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group_ufdsasn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name_test</para>
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The source ID of the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("groupSourceId")]
        [Validation(Required=false)]
        public string GroupSourceId { get; set; }

        /// <summary>
        /// <para>The source type of the group. Valid values: build_in, ding_talk, ad, and ldap.</para>
        /// 
        /// <b>Example:</b>
        /// <para>build_in</para>
        /// </summary>
        [NameInMap("groupSourceType")]
        [Validation(Required=false)]
        public string GroupSourceType { get; set; }

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
        /// <para>The time when the group was last updated. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1652085686179</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
