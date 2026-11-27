// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class UpdateOuterAccountRequest : TeaModel {
        /// <summary>
        /// <para>The profile picture.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http://****</para>
        /// </summary>
        [NameInMap("Avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// <para>The extension field. A JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Note&quot;:&quot;Temporary skill group&quot;}</para>
        /// </summary>
        [NameInMap("Ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// <para>The external account ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("OuterAccountId")]
        [Validation(Required=false)]
        public string OuterAccountId { get; set; }

        /// <summary>
        /// <para>The external account name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("OuterAccountName")]
        [Validation(Required=false)]
        public string OuterAccountName { get; set; }

        /// <summary>
        /// <para>The external account type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alipay</para>
        /// </summary>
        [NameInMap("OuterAccountType")]
        [Validation(Required=false)]
        public string OuterAccountType { get; set; }

        /// <summary>
        /// <para>The external department ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("OuterDepartmentId")]
        [Validation(Required=false)]
        public string OuterDepartmentId { get; set; }

        /// <summary>
        /// <para>The external department type: invalid department type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>type_invalid</para>
        /// </summary>
        [NameInMap("OuterDepartmentType")]
        [Validation(Required=false)]
        public string OuterDepartmentType { get; set; }

        /// <summary>
        /// <para>The list of external skill group IDs. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;222&quot;,&quot;333&quot;,&quot;444&quot;]</para>
        /// </summary>
        [NameInMap("OuterGroupIds")]
        [Validation(Required=false)]
        public string OuterGroupIds { get; set; }

        /// <summary>
        /// <para>The skill group type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mybank</para>
        /// </summary>
        [NameInMap("OuterGroupType")]
        [Validation(Required=false)]
        public string OuterGroupType { get; set; }

        /// <summary>
        /// <para>The real name of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhang San</para>
        /// </summary>
        [NameInMap("RealName")]
        [Validation(Required=false)]
        public string RealName { get; set; }

    }

}
