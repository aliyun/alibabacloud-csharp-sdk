// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class AddSkillGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("OuterDepartmentId")]
        [Validation(Required=false)]
        public string OuterDepartmentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>type_invalid</para>
        /// </summary>
        [NameInMap("OuterDepartmentType")]
        [Validation(Required=false)]
        public string OuterDepartmentType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("OuterGroupId")]
        [Validation(Required=false)]
        public string OuterGroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OuterGroupName")]
        [Validation(Required=false)]
        public string OuterGroupName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mybank</para>
        /// </summary>
        [NameInMap("OuterGroupType")]
        [Validation(Required=false)]
        public string OuterGroupType { get; set; }

    }

}
