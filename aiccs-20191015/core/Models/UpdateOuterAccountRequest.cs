// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class UpdateOuterAccountRequest : TeaModel {
        /// <summary>
        /// <para>Profile picture.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http://****</para>
        /// </summary>
        [NameInMap("Avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// <para>Extension field. A JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;备注&quot;:&quot;临时技能组&quot;}</para>
        /// </summary>
        [NameInMap("Ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// <para>External account ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("OuterAccountId")]
        [Validation(Required=false)]
        public string OuterAccountId { get; set; }

        /// <summary>
        /// <para>External account name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("OuterAccountName")]
        [Validation(Required=false)]
        public string OuterAccountName { get; set; }

        /// <summary>
        /// <para>External account type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alipay</para>
        /// </summary>
        [NameInMap("OuterAccountType")]
        [Validation(Required=false)]
        public string OuterAccountType { get; set; }

        /// <summary>
        /// <para>External department ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("OuterDepartmentId")]
        [Validation(Required=false)]
        public string OuterDepartmentId { get; set; }

        /// <summary>
        /// <para>External department type: invalid department type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>type_invalid</para>
        /// </summary>
        [NameInMap("OuterDepartmentType")]
        [Validation(Required=false)]
        public string OuterDepartmentType { get; set; }

        /// <summary>
        /// <para>List of external skill group IDs. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;222&quot;,&quot;333&quot;,&quot;444&quot;]</para>
        /// </summary>
        [NameInMap("OuterGroupIds")]
        [Validation(Required=false)]
        public string OuterGroupIds { get; set; }

        /// <summary>
        /// <para>Skill group type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mybank</para>
        /// </summary>
        [NameInMap("OuterGroupType")]
        [Validation(Required=false)]
        public string OuterGroupType { get; set; }

        /// <summary>
        /// <para>Real name of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("RealName")]
        [Validation(Required=false)]
        public string RealName { get; set; }

    }

}
