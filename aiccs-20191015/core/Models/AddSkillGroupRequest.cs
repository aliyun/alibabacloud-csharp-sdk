// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class AddSkillGroupRequest : TeaModel {
        /// <summary>
        /// <para>ID of the external department.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("OuterDepartmentId")]
        [Validation(Required=false)]
        public string OuterDepartmentId { get; set; }

        /// <summary>
        /// <para>Type of the external department.</para>
        /// 
        /// <b>Example:</b>
        /// <para>type_invalid</para>
        /// </summary>
        [NameInMap("OuterDepartmentType")]
        [Validation(Required=false)]
        public string OuterDepartmentType { get; set; }

        /// <summary>
        /// <para>ID of the external skill group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("OuterGroupId")]
        [Validation(Required=false)]
        public string OuterGroupId { get; set; }

        /// <summary>
        /// <para>Name of the external skill group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>热线技能组</para>
        /// </summary>
        [NameInMap("OuterGroupName")]
        [Validation(Required=false)]
        public string OuterGroupName { get; set; }

        /// <summary>
        /// <para>Type of the external skill group.</para>
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
