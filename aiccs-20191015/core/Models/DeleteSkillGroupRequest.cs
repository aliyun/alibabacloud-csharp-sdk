// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class DeleteSkillGroupRequest : TeaModel {
        /// <summary>
        /// <para>External skill group ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("OuterGroupId")]
        [Validation(Required=false)]
        public string OuterGroupId { get; set; }

        /// <summary>
        /// <para>External skill group type. Valid enumeration values are: 1: Hotline, 2: Online, 4: Ticket</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("OuterGroupType")]
        [Validation(Required=false)]
        public string OuterGroupType { get; set; }

    }

}
