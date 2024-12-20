// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class AddOuterAccountRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>http://****</para>
        /// </summary>
        [NameInMap("Avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        [NameInMap("Ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1212</para>
        /// </summary>
        [NameInMap("OuterAccountId")]
        [Validation(Required=false)]
        public string OuterAccountId { get; set; }

        [NameInMap("OuterAccountName")]
        [Validation(Required=false)]
        public string OuterAccountName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alipay</para>
        /// </summary>
        [NameInMap("OuterAccountType")]
        [Validation(Required=false)]
        public string OuterAccountType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
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
        /// <b>Example:</b>
        /// <para>[&quot;222&quot;,&quot;333&quot;,&quot;444&quot;]</para>
        /// </summary>
        [NameInMap("OuterGroupIds")]
        [Validation(Required=false)]
        public string OuterGroupIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mybank</para>
        /// </summary>
        [NameInMap("OuterGroupType")]
        [Validation(Required=false)]
        public string OuterGroupType { get; set; }

        [NameInMap("RealName")]
        [Validation(Required=false)]
        public string RealName { get; set; }

    }

}
