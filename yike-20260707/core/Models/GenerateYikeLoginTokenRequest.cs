// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class GenerateYikeLoginTokenRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether automatic creation of a project is enabled. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoCreateProduction")]
        [Validation(Required=false)]
        public string AutoCreateProduction { get; set; }

        /// <summary>
        /// <para>The token expiration time, in seconds. Default value: 30 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Expires")]
        [Validation(Required=false)]
        public string Expires { get; set; }

        /// <summary>
        /// <para>The nickname.</para>
        /// <list type="bullet">
        /// <item><description>Format check: The maximum length is 50 characters.</description></item>
        /// <item><description>Special format validation: Chinese characters, English characters, digits, _ \ / () ] [</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>冯凯</para>
        /// </summary>
        [NameInMap("NickName")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        /// <summary>
        /// <para>The role of the user in the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>common</para>
        /// </summary>
        [NameInMap("ProductionAuth")]
        [Validation(Required=false)]
        public string ProductionAuth { get; set; }

        /// <summary>
        /// <para>The default credits granted to the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("SubUserCredit")]
        [Validation(Required=false)]
        public string SubUserCredit { get; set; }

        /// <summary>
        /// <para>The tenant identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wanyou</para>
        /// </summary>
        [NameInMap("Tenant")]
        [Validation(Required=false)]
        public string Tenant { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>userxxx</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>581236</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
