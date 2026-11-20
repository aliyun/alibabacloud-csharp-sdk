// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelGroupDTO : TeaModel {
        /// <summary>
        /// <para>The time when the group was created. Format: yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The time when the group was updated. Format: yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The unique identifier of the group. It starts with the mg_ prefix and remains unchanged after creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mg_a1b2c3d4e5f6g7h8i9j0</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The number of models currently included in the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("modelCount")]
        [Validation(Required=false)]
        public int? ModelCount { get; set; }

        /// <summary>
        /// <para>The array of all member model IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[101, 102, 103]</para>
        /// </summary>
        [NameInMap("modelList")]
        [Validation(Required=false)]
        public List<long?> ModelList { get; set; }

        /// <summary>
        /// <para>The name of the group. If a system group is unnamed, the default platform name is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Professional Edition plan</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The type of the group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>system: The group is automatically created by the system and cannot be edited or deleted.</description></item>
        /// <item><description>manual: The group is manually created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>manual</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
